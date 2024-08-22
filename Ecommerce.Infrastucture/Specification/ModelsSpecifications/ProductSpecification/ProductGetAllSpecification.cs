namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.ProductSpecification;

public sealed class ProductGetAllSpecification : Specification<Product>
{
    public ProductGetAllSpecification(ProductGetAllParams productParams) : base(p =>
        (string.IsNullOrEmpty(productParams.CategoryId) || p.CategoryId == productParams.CategoryId) &&
        (string.IsNullOrEmpty(productParams.BrandId) || p.CategoryId == productParams.BrandId) &&
        p.IsShow
        )
    {
        AddIInclude(i =>
        i.Include(p => p.Discount)
        .Include(p => p.ProductVariant));

        ApplyPaging(productParams.PageNumber, productParams.PageSize);

        if (productParams.Sort is not null)
        {
            switch (productParams.Sort)
            {
                case ProductSort.ASC:
                    AddOrderBy(p => p.Price);
                    break;
                case ProductSort.DESC:
                    AddOrderByDescending(p => p.Price);
                    break;
                case ProductSort.NAME:
                    AddOrderBy(p => p.Name);
                    break;
            }
        }
    }
}
