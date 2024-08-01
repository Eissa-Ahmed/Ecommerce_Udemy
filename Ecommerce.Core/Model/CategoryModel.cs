using AutoMapper;

namespace Ecommerce.Application.Model;

public sealed class CategoryModel
{
    public CategoryModel()
    {
        subCategoryModels = new List<SubCategoryModel>();
    }
    public string? Name { get; set; }
    public List<SubCategoryModel> subCategoryModels { get; set; }
}

public sealed class SubCategoryModel
{

    public string? Name { get; set; }
    public string? CategoryName { get; set; }
    public string? ParentSubcategoryName { get; set; }
    public List<SubCategoryModel>? subCategoryModelNested { get; set; } = null;

}

public class MyMapper : Profile
{
    public MyMapper()
    {
        CreateMap<Category, CategoryModel>()
            .ForMember(des => des.subCategoryModels, opt => opt.MapFrom(src => src.SubCategories));
        CreateMap<SubCategory, SubCategoryModel>()
            .ForMember(des => des.subCategoryModelNested, opt => opt.MapFrom(src => src.SubCategorys));
    }
}