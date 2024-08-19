﻿namespace Ecommerce.Application.Services.ProductContainer;

public sealed class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileFactory _fileFactory;

    public ProductService(IUnitOfWork unitOfWork, IFileFactory fileFactory)
    {
        _unitOfWork = unitOfWork;
        _fileFactory = fileFactory;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        product.MainImage = product.Images.First().Name;
        await _unitOfWork.ProductRepository.CreateAsync(product);
        return await GetByIdAsync(product.Id);
    }

    public async Task<Pagination<Product>> GetAllAsync(ProductGetAllParams productGetAllParams)
    {

        ISpecification<Product> ProductSpecification = new ProductGetAllSpecification(productGetAllParams);

        IReadOnlyList<Product> products = await _unitOfWork.ProductRepository.GetAllAsync(ProductSpecification);

        int totalCount = await _unitOfWork.ProductRepository.CountAsync();
        return new Pagination<Product>(products.ToList(), productGetAllParams.PageNumber, productGetAllParams.PageSize, totalCount);
    }
    public async Task<Product> GetByIdAsync(string id)
    {
        ISpecification<Product> ProductSpecification = new ProductGetByIdSpecification(id);
        return await _unitOfWork.ProductRepository.GetByIdAsync(ProductSpecification);
        throw new NotImplementedException();
    }

    private void OrderByProduct(string? sortByPrice, out Expression<Func<Product, object>>? orderBy, out Expression<Func<Product, object>>? orderByDesc)
    {
        orderBy = null;
        orderByDesc = null;
        if (sortByPrice is not null)
        {
            if (sortByPrice == "ASC")
                orderBy = i => i.Price;
            else
                orderByDesc = i => i.Price;
        }
    }
}
