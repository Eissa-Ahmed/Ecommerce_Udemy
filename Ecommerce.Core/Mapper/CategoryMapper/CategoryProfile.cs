namespace Ecommerce.Application.Mapper.CategoryMapper;

public partial class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        ApplyCategoryGetAllMapper();
        ApplyCategoryGetByIdMapper();
        ApplyCategoryCreateMapper();
        ApplyCategoryUpdateMapper();
        ApplyCategoryAddSubCategoryMapper();
    }
}
