﻿using Ecommerce.Infrastucture.Specification.ModelsSpecifications.CategorySpecification;

namespace Ecommerce.Application.Services.CategoryContainer;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryServices(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<Category> AddSubCategoryInCategoryAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task<Category> CreateAsync(Category category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    /*    public async Task<Category> AddSubCategoryInCategoryAsync(Category category) // NotCompleted => Check Parent Category is Not Conatin a Products
        {
            Category result = await _unitOfWork.CategoryRepository.CreateAsync(category);
            return result;
        }

        public async Task<Category> CreateAsync(Category category)
        {
            Category result = await _unitOfWork.CategoryRepository.CreateAsync(category);
            return result;
        }

        public async Task DeleteAsync(string id)
        {
            Category? category = await GetByIdAsync(id);
            await _unitOfWork.CategoryRepository.DeleteAsync(category!);
        }*/

    public async Task<IReadOnlyList<Category>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategoryGetAllSpecification();
        IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specification);
        return Helper.GetCategories(categories.ToList());
    }

    public Task<Category> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Category> TransferProductsFromCurrentCategoryToNestedCategory(string idCurrentCategory, string idNestedCategory)
    {
        throw new NotImplementedException();
    }

    public Task<Category> UpdateNameAsync(string id, string name)
    {
        throw new NotImplementedException();
    }

    /*  public async Task<Category> GetByIdAsync(string id)
      {
          List<Expression<Func<Category, bool>>> criterias = new List<Expression<Func<Category, bool>>>()
          {
              i => i.Id == id,
          };

          ISpecification<Category> specificationCategory = new CategorySpecification(criterias);
          ISpecification<Category> specificationCategories = new CategorySpecification();
          Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationCategory);
          IReadOnlyList<Category> categories = await _unitOfWork.CategoryRepository.GetAllAsync(specificationCategories);
          return Helper.GetCategory(category!, categories.ToList());
      }

      public Task<Category> TransferProductsFromCurrentCategoryToNestedCategory(string idCurrentCategory, string idNestedCategory) // NotCompleted
      {
          throw new NotImplementedException();
      }

      public async Task<Category> UpdateNameAsync(string id, string name)
      {
          List<Expression<Func<Category, bool>>> criterias = new List<Expression<Func<Category, bool>>>()
          {
              i => i.Id == id
          };
          ISpecification<Category> specificationCategory = new CategorySpecification(criterias, applyTracking: true);
          Category? category = await _unitOfWork.CategoryRepository.GetByIdAsync(specificationCategory);
          category!.Name = name;
          await _unitOfWork.SaveChangesAsync();
          return await GetByIdAsync(id);
      }*/
}
