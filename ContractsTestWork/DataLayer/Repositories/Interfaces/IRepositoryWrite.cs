namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IRepositoryWrite <T>
{
    Task Add(T item);
}