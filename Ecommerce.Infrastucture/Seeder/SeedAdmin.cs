namespace Ecommerce.Infrastucture.Seeder;

public sealed class SeedAdmin
{
    private readonly UserManager<User> _userManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly ApplicationDbContext _context;

    public SeedAdmin(UserManager<User> userManager, RoleManager<Role> roleManager, ApplicationDbContext context)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _context = context;
    }

    public async Task SeedData()
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            if (!(await _roleManager.RoleExistsAsync(RolesType.Admin.ToString())))
            {
                await _roleManager.CreateAsync(new Role { Name = RolesType.Admin.ToString() });
                await _roleManager.CreateAsync(new Role { Name = RolesType.User.ToString() });
            }

            if (await _userManager.FindByNameAsync(RolesType.Admin.ToString()) is null)
            {
                var user = new User
                {
                    UserName = RolesType.Admin.ToString(),
                    Email = "admin@krist.com",
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(user, "admin@krist.com");
                await _userManager.AddToRoleAsync(user, RolesType.Admin.ToString());
            }
            await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            throw ex;
        }
    }
}
