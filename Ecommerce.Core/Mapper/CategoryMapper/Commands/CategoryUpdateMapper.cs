namespace Ecommerce.Application.Mapper.CategoryMapper;

public partial class CategoryProfile
{
    private void ApplyCategoryUpdateMapper()
    {

        CreateMap<Category, CategoryUpdateResult>()
            .ForMember(dest => dest.subCattegories, opt => opt.MapFrom(src => src.SubCategories));

        CreateMap<Category, CategoryUpdateResult_SubCategory>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.ParentCategoryId));

    }
}