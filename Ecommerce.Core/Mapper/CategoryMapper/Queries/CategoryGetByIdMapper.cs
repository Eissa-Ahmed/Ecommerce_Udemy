namespace Ecommerce.Application.Mapper.CategoryMapper;

public partial class CategoryProfile
{
    private void ApplyCategoryGetByIdMapper()
    {
        CreateMap<Category, CategoryGetByIdResult>()
           .ForMember(des => des.SubCategories, opt => opt.MapFrom(src => src.SubCategories));
        CreateMap<Category, CategoryGetByIdResult_SubCategory>()
            .ForMember(des => des.SubCategories, opt => opt.MapFrom(src => src.SubCategories));
    }
}
