

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterModule_Api(builder);
builder.Services.RegisterModule_Application(builder.Configuration);
builder.Services.RegisterModule_Infrastructure(builder.Configuration);
// Add services to the container.

builder.Services.AddControllers();
/*   .AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
});*/
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    ApplicationDbContext _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await _context.Database.MigrateAsync();
    SeedCategory _seedCategory = new SeedCategory(_context);
    SeedSubCategory _seedSubCategory = new SeedSubCategory(_context);
    await _seedCategory.SeedData();
    await _seedSubCategory.SeedData();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();
