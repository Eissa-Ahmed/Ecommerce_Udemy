namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class RatingProductResolver : IValueResolver<Product, ProductGetAllResult, double>
{
    public double Resolve(Product source, ProductGetAllResult destination, double destMember, ResolutionContext context)
    {
        double sum = source.Ratings.Sum(r => r.Score);
        double count = source.Ratings.ToList().Count();
        return sum / count;
    }
}

