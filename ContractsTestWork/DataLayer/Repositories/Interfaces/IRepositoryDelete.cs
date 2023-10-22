namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IRepositoryDelete<T>
{
    Task Delete(T item);
}