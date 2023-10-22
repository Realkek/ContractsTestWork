namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IRepositoryUpdate <T>
{
    Task Update(T item);
}