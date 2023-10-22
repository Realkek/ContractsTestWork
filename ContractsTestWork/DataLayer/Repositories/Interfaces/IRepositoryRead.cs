namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IRepositoryRead <T> 
{
    Task<T> GetItem(Guid id);
    Task<IEnumerable<T>> GetItems();
}