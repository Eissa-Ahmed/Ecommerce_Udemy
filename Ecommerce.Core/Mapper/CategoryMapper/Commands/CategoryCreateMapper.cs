namespace Ecommerce.Application.Mapper.CategoryMapper;

public partial class CategoryProfile
{
    private void ApplyCategoryCreateMapper()
    {
        CreateMap<CategoryCreateModel, Category>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.SubCategories.Select(name => new SubCategory { Name = name })))
            .ForMember(dest => dest.Products, opt => opt.Ignore());

        CreateMap<Category, CategoryCreateResult>()
            .ForMember(dest => dest.subCattegories, opt => opt.MapFrom(src => src.SubCategories));

        CreateMap<SubCategory, CategoryCreateResult_SubCattegory>();
    }
}
