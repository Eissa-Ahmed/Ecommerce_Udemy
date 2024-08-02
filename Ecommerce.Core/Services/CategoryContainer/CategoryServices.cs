﻿namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        return await _unitOfWork.CategoryRepository.CreateAsync(category);
    }

    public async Task DeleteAsync(string name)
    {
        ISpecification<Category> specification = new CategorySpecification(name);
        Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specification);
        await _unitOfWork.CategoryRepository.DeleteAsync(category!);
    }

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        return await _unitOfWork.CategoryRepository.GetAllAsync(specification);
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        await _unitOfWork.CategoryRepository.UpdateAsync(category);
        return category;
    }
}
