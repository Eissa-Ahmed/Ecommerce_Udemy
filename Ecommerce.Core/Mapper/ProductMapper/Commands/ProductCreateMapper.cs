namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile
{
    private void ApplyProductCreateMapper()
    {
        CreateMap<ProductCreateModel, Product>()
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes))
            .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
            .ForMember(dest => dest.CareInstructions, opt => opt.MapFrom(src => src.CareInstructions))
            //.ForMember(dest => dest.ProductColors, opt => opt.MapFrom(src => src.ProductColors))
            .ForMember(dest => dest.Images, opt => opt.MapFrom<ProductCreateMapper_Images_Resolver>());

        CreateMap<ProductCreateModel_ProductAttributes, ProductAttributes>();
        CreateMap<ProductCreateModel_CareInstructions, CareInstructions>();
        CreateMap<ProductCreateModel_Features, Features>();
        /*  CreateMap<ProductCreateModel_ProductColors, ProductColors>()
              .ForMember(dest => dest.ProductSizes, opt => opt.MapFrom(src => src.ProductSizes));
          CreateMap<ProductCreateModel_ProductSizes, ProductSizes>();*/

        CreateMap<Product, ProductCreateResult>()
            .ForMember(dest => dest.MainImage, opt => opt.MapFrom<ProductCreateMapper_ProdutImage_Resolver>())
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.Features, opt => opt.MapFrom(src => src.Features))
            .ForMember(dest => dest.CareInstructions, opt => opt.MapFrom(src => src.CareInstructions))
            //.ForMember(dest => dest.ProductColors, opt => opt.MapFrom(src => src.ProductColors))
            .ForMember(dest => dest.BrandName, opt => opt.MapFrom(src => src.Brand.Name))
            .ForMember(dest => dest.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttributes));

        CreateMap<Images, ProductCreateResult_Images>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom<ProductCreateMapper_ImageUrl_Resolver>());

        CreateMap<ProductAttributes, ProductCreateResult_ProductAttributes>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Attributes.Name));

        CreateMap<Features, ProductCreateResult_Features>();
        CreateMap<CareInstructions, ProductCreateResult_CareInstructions>();
        /*CreateMap<ProductColors, ProductCreateResult_ProductColors>()
            .ForMember(dest => dest.ProductSizes, opt => opt.MapFrom(src => src.ProductSizes));
        CreateMap<ProductSizes, ProductCreateResult_ProductSizes>();*/
    }
}
