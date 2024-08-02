﻿namespace Ecommerce.Application.Mapper.CategoryMapper;
public partial class CategoryProfile
{
    private void ApplyCategoryGetAllMapper()
    {
        CreateMap<Category, CategoryGetAllResult>()
           .ForMember(des => des.SubCategories, opt => opt.MapFrom(src => src.SubCategories));
        CreateMap<SubCategory, CategoryGetAllResult_SubCategory>()
            .ForMember(des => des.SubCategories, opt => opt.MapFrom(src => src.SubCategorys));
    }
}
