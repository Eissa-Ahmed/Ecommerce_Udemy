using AutoMapper;
using Ecommerce.Application.Model;

namespace Ecommerce.Application.Services;

public sealed class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CategoryServices(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<CategoryModel>> GetAllAsync()
    {
        ISpecification<Category> specification = new CategorySpecification();
        var result = await _unitOfWork.CategoryRepository.GetAllAsync2();
        return _mapper.Map<IReadOnlyList<CategoryModel>>(result);
    }
}
