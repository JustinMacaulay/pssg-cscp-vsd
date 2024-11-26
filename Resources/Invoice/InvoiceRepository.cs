﻿namespace Resources;

public class InvoiceRepository : BaseRepository<Vsd_Invoice, Invoice>, IInvoiceRepository
{
    private readonly DatabaseContext _databaseContext;

    public InvoiceRepository(DatabaseContext databaseContext, IMapper mapper) : base(databaseContext, mapper) 
    {
        _databaseContext = databaseContext;
    }

    // NOTE not fully tested
    public override Guid Insert(Invoice invoice)
    {
        var entity = _mapper.Map<Vsd_Invoice>(invoice);
        _databaseContext.AddObject(entity);
        if (invoice.InvoiceLineDetails != null)
        {
            foreach (var invoiceLineDetailDto in invoice.InvoiceLineDetails)
            {
                var invoiceLineDetail = _mapper.Map<Vsd_InvoiceLineDetail>(invoiceLineDetailDto);
                invoiceLineDetail.Vsd_InvoiceId = null;     // let Dynamics generate the invoice id and use it to link the entities
                _databaseContext.AddRelatedObject(entity, Vsd_Invoice.Fields.Vsd_Vsd_Invoice_Vsd_InvoiceLineDetail.ToLower(), invoiceLineDetail);
            }
        }
        _databaseContext.SaveChanges();
        return entity.Id;
    }

    public IEnumerable<Invoice> Query(InvoiceQuery invoiceQuery)
    {
        var queryResults = _databaseContext.Vsd_InvoiceSet
            .WhereIf(invoiceQuery.ProgramId != null, c => c.Vsd_ProgramId.Id == invoiceQuery.ProgramId)
            .WhereIf(invoiceQuery.Origin != null, c => c.Vsd_Origin == (Vsd_Invoice_Vsd_Origin?)invoiceQuery.Origin)
            .WhereIf(invoiceQuery.InvoiceDate != null, c => c.Vsd_InvoicedAte == invoiceQuery.InvoiceDate)
            .ToList();
        return _mapper.Map<IEnumerable<Invoice>>(queryResults);
    }

    public override bool TryDeleteRange(IEnumerable<Invoice> invoices, bool isRecursive = false)
    {
        // NOTE you can optimize these by removing the foreach queries and using Invoice.InvoiceLineDetailId instead but you will need to map InvoiceLineDetailId first on Query method
        //foreach (var invoice in invoices)
        //{
        //    var invoiceLineDetails = _databaseContext.Vsd_InvoiceLineDetailSet.Where(x => x.Vsd_InvoiceId.Id == invoice.Id).ToList();
        //    foreach (var invoiceLineDetail in invoiceLineDetails)
        //    {
        //        // TODO a false here should return false for this method
        //        _databaseContext.DeleteObject(invoiceLineDetail);
        //        _databaseContext.SaveChanges();
        //        _databaseContext.Detach(invoiceLineDetail);
        //    }
        //}

        return base.TryDeleteRange(invoices);
    }
}
