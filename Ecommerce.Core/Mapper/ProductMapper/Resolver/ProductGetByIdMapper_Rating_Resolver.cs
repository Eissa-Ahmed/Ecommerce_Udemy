namespace Ecommerce.Application.Mapper.ProductMapper.Resolver;

public sealed class ProductGetByIdMapper_Rating_Resolver : IValueResolver<Product, ProductGetByIdResult, double>
{
    public double Resolve(Product source, ProductGetByIdResult destination, double destMember, ResolutionContext context)
    {
        /* double sum = source.Ratings.Sum(r => r.Score);
         double count = source.Ratings.ToList().Count();

         if (sum == 0 || count == 0)
             return 0;

         return sum / count;*/
        return 0;
    }
}

