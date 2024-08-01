﻿namespace Ecommerce.Domain.IRepositories.IUnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IProductRepository ProductRepository { get; }
    ICategoryRepository CategoryRepository { get; }
    ISubCategoryRepository SubCategoryRepository { get; }
    Task<int> SaveChangesAsync();

}
