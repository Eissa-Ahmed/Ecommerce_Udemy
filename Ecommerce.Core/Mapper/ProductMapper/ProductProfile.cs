namespace Ecommerce.Application.Mapper.ProductMapper;

public partial class ProductProfile : Profile
{
    public ProductProfile()
    {
        ApplyProductCreateMapper();
        ApplyProductGetAllMapper();
    }
}
