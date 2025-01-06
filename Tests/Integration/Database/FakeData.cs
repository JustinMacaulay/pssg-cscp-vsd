﻿public static partial class FakeData
{
    public static List<Contract> Contracts = new List<Contract>
    {
        new Contract
        {
            Id = new Guid("ce4f37e8-7043-41b2-a0e7-23fb93fa53c9"),
            StateCode = StateCode.Active,
            StatusCode = ContractStatusCode.DulyExecuted,
            MethodOfPayment = MethodOfPayment.Cheque,
            ContractType = ContractType.TuaVictimServicesVawp,
            //ProgramId = new Guid("05dcfc76-77d1-471f-9b7a-a79332186fac"),
        },
    };

    public static List<InvoiceLineDetail> InvoiceLineDetails = new List<InvoiceLineDetail>
    {
        new InvoiceLineDetail
        {
            Id = new Guid("00000000-e81b-ec11-b82d-00505683fbf4"),
            // NOTE this is an id that exists on DEV, change this if you need reliable test data
            InvoiceId = new Guid("520fd904-b48e-ec11-b82c-005056830319"),
            Owner = new DynamicReference(new Guid("46fd16c0-fc6e-ea11-b818-00505683fbf4"), Database.Model.Account.EntityLogicalName),
            InvoiceType = InvoiceType.OtherPayments,
            ProgramUnit = ProgramUnit.Cpu,
            Approved = YesNo.Yes,
            AmountSimple = 100.00m,
            ProvinceStateId = new Guid("FDE4DBCA-989A-E811-8155-480FCFF4F6A1"),
            TaxExemption = TaxExemption.NoTax,
        }
    };
}
