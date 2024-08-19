namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetAll_ConvertRatingtoDecimal_Resolver : IValueResolver<Product, ProductGetAllResult, double>
{
    public double Resolve(Product source, ProductGetAllResult destination, double destMember, ResolutionContext context)
    {
        /*double sum = source.Ratings.Sum(r => r.Score);
        double count = source.Ratings.ToList().Count();

        if (sum == 0 || count == 0)
            return 0;

        return sum / count;*/
        return 0;
    }
}

