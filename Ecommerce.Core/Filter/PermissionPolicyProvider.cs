namespace Ecommerce.Application.Filter;

public class PermissionPolicyProvider : IAuthorizationPolicyProvider
{
    public DefaultAuthorizationPolicyProvider FallbackPolicyProvider { get; }

    public PermissionPolicyProvider(IOptions<AuthorizationOptions> options)
    {
        FallbackPolicyProvider = new DefaultAuthorizationPolicyProvider(options);
    }
    public Task<AuthorizationPolicy> GetDefaultPolicyAsync()
    {
        return FallbackPolicyProvider.GetDefaultPolicyAsync();
    }

    public Task<AuthorizationPolicy> GetFallbackPolicyAsync()
    {
        return FallbackPolicyProvider.GetDefaultPolicyAsync();
    }
    public Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
    {

        if (policyName != null)
        {
            var policy = new AuthorizationPolicyBuilder();
            policy.AddRequirements(new PermissionRequirement(policyName));
            return Task.FromResult(policy.Build());
        }


        return FallbackPolicyProvider.GetPolicyAsync(policyName);
    }

}
