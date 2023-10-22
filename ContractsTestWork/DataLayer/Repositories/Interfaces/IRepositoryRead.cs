namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IRepositoryRead <T> 
{
    Task<T> GetItem(int id);
    Task<IEnumerable<T>> GetItems();
}