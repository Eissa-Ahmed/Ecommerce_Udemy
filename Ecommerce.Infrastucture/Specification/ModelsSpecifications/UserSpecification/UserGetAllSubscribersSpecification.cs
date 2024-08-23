namespace Ecommerce.Infrastucture.Specification.ModelsSpecifications.UserSpecification;

public sealed class UserGetAllSubscribersSpecification : Specification<Subscription, string>
{
    public UserGetAllSubscribersSpecification()
    {
        ApplySelector(i => i.UserId);
    }
}
