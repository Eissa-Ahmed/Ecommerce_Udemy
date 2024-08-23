namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetByIdMapper_Rating_Resolver : IValueResolver<Product, ProductGetByIdResult, double>
{
    public double Resolve(Product source, ProductGetByIdResult destination, double destMember, ResolutionContext context)
    {
        double sum = source.Reviews.Sum(r => r.Rating);
        double count = source.Reviews.ToList().Count();

        if (sum == 0 || count == 0)
            return 0;

        return sum / count;
    }
}

