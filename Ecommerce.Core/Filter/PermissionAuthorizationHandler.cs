namespace Ecommerce.Application.Filter;

public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
{
    public PermissionAuthorizationHandler()
    {
    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
    {
        // Return immediately if the user is not authenticated
        if (!context.User.Identity.IsAuthenticated)
        {
            return;
        }

        bool canAccess = false;

        // Check if the required permission is a list of permissions separated by commas
        var permissions = requirement.Permission.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (permissions.Length > 1)
        {
            // Check if any of the permissions match the claims
            canAccess = permissions.Any(permission =>
                context.User.Claims.Any(c => c.Type == "Permission" && c.Value == permission.Trim()));
        }
        else
        {
            // Check if the single permission matches the claims
            canAccess = context.User.Claims.Any(c => c.Type == "Permission" && c.Value == requirement.Permission);
        }

        if (canAccess)
        {
            context.Succeed(requirement);
        }

        return;
    }
}
