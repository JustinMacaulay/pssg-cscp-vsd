namespace Shared.Database;

public abstract class BaseRepository<TEntity, TDto> 
    where TEntity : Entity
    where TDto : IDto
{
    // TODO check if this acts like a singleton otherwise check if we can have concurrency issues
    protected readonly OrganizationServiceContext _databaseContext;
    protected readonly IMapper _mapper;

    public BaseRepository(OrganizationServiceContext databaseContext, IMapper mapper)
    {
        _databaseContext = databaseContext;
        _mapper = mapper;
    }

    public virtual Guid Insert(TDto dto)
    {
        var entity = Map(dto);
        _databaseContext.AddObject(entity);
        _databaseContext.SaveChanges();
        return entity.Id;
    }

    public virtual Guid Upsert(TDto dto)
    {
        var entity = Map(dto);
        var existingEntity = _databaseContext
            .CreateQuery<TEntity>()
            .FirstOrDefault(x => x.Id == entity.Id);
        if (existingEntity != null)
        {
            _databaseContext.Detach(existingEntity);
            _databaseContext.Attach(entity);
            _databaseContext.UpdateObject(entity);
        }
        else
        {
            _databaseContext.AddObject(entity);
        }
        _databaseContext.SaveChanges();
        return entity.Id;
    }

    public virtual bool Update(TDto dto)
    {
        if (dto.Id == Guid.Empty)
        {
            throw new ArgumentException("Id cannot be empty");
        }
        var entity = Map(dto);
        return Update(entity);
    }

    public virtual bool Update(TEntity entity)
    {
        if (entity.Id == Guid.Empty)
        {
            throw new ArgumentException("Id cannot be empty");
        }
        if (!_databaseContext.IsAttached(entity))
        {
            _databaseContext.Attach(entity);
        }
        _databaseContext.UpdateObject(entity);
        return !_databaseContext
            .SaveChanges()
            .HasError;     
    }

    public virtual bool TryDelete(Guid id)
    {
        var dto = Activator.CreateInstance<TDto>();
        dto.Id = id;
        return TryDelete(dto);
    }

    public virtual bool TryDelete(TDto dto, bool isRecursive = false)
    {
        try
        {
            var entity = Map(dto);
            if (!_databaseContext.IsAttached(entity))
            {
                _databaseContext.Attach(entity);
            }
            _databaseContext.DeleteObject(entity, isRecursive);
            _databaseContext.SaveChanges();
            _databaseContext.Detach(entity);
            return true;
        }
        catch
        {
            return false;
        }
    }

    // safe delete, use TryDelete for faster deletes
    public virtual bool Delete(Guid id)
    {
        var entity = _databaseContext
            .CreateQuery<TEntity>()
            .FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
            return false;
        }
        _databaseContext.DeleteObject(entity);
        _databaseContext.SaveChanges();
        _databaseContext.Detach(entity);
        return true;
    }

    public virtual bool TryDeleteRange(IEnumerable<TDto> dtos, bool isRecursive = false)
    {
        bool result = true;
        foreach (var dto in dtos)
        {
            if (!TryDelete(dto, isRecursive))
            {
                result = false;
            }
        }
        return result;
    }

    private TEntity Map(TDto dto)
    {
        return _mapper.Map<TEntity>(dto);
    }
}
