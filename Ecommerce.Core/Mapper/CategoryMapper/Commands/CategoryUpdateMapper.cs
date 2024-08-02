namespace Ecommerce.Application.Mapper.CategoryMapper;

public partial class CategoryProfile
{
    private void ApplyCategoryUpdateMapper()
    {
        CreateMap<CategoryUpdateModel, Category>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CategoryName))
            .ForMember(dest => dest.SubCategories, opt => opt.MapFrom(src => src.SubCategories.Select(name => new Category { Name = name })))
            .ForMember(dest => dest.Products, opt => opt.Ignore());

        CreateMap<Category, CategoryUpdateResult>()
            .ForMember(dest => dest.subCattegories, opt => opt.MapFrom(src => src.SubCategories));

        CreateMap<Category, CategoryUpdateResult_SubCategory>();
    }
}