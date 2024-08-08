using Ecommerce.Infrastucture.Seeder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterModule_Api(builder);
builder.Services.RegisterModule_Application(builder.Configuration);
builder.Services.RegisterModule_Infrastructure(builder.Configuration);

/*   .AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});*/


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    ApplicationDbContext _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await _context.Database.MigrateAsync();
    SeedCategory _seedCategory = new SeedCategory(_context);
    await _seedCategory.SeedData();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "My API V2");
    });
}
app.UseCors("CorsPolicy");

app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
