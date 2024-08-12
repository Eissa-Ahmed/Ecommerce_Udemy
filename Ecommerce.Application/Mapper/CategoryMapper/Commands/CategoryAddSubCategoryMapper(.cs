namespace Ecommerce.Application.Mapper.CategoryMapper;

public partial class CategoryProfile
{
    private void ApplyCategoryAddSubCategoryMapper()
    {
        CreateMap<Category, CategoryAddSubCategoryResult>()
            .ForMember(dest => dest.subCattegories, opt => opt.MapFrom(src => src.SubCategories));

        CreateMap<Category, CategoryAddSubCategoryResult_SubCategory>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.ParentCategoryId));

    }
}




