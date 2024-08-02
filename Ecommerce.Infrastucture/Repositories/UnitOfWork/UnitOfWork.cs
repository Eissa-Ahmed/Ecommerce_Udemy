﻿namespace Ecommerce.Infrastucture.Repositories.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IProductRepository ProductRepository { get; private set; }

    public ICategoryRepository CategoryRepository { get; private set; }


    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        ProductRepository = new ProductRepository(context);
        CategoryRepository = new CategoryRepository(context);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
