﻿namespace Ecommerce.Application.Services.IServices.ICategoryContainer;

public interface ICategoryServices
{
    Task<IReadOnlyList<Category>> GetAllAsync();
    Task<Category> GetByIdAsync(string name);
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task DeleteAsync(string name);
}