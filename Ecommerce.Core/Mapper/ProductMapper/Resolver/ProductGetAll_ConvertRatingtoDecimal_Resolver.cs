namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetAll_ConvertRatingtoDecimal_Resolver : IValueResolver<Product, ProductGetAllResult, double>
{
    public double Resolve(Product source, ProductGetAllResult destination, double destMember, ResolutionContext context)
    {
        double sum = source.Reviews.Sum(r => r.Rating);
        double count = source.Reviews.ToList().Count();

        if (sum == 0 || count == 0)
            return 0;

        return sum / count;
    }
}

