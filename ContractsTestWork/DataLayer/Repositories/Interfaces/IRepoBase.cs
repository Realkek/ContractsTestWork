﻿namespace ContractsTestWork.DataLayer.Repositories.Interfaces;

public interface IRepoBase<T>
{
    Task<T> GetItem(Guid id);
    Task<IEnumerable<T>> GetItems();
    Task Add(T item);
    Task Update(T item);
}