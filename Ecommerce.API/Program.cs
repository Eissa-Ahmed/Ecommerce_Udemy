using Ecommerce.API;
using Ecommerce.Core;
using Ecommerce.Infrastucture;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterModule_Api(builder.Configuration);
builder.Services.RegisterModule_Core(builder.Configuration);
builder.Services.RegisterModule_Infrastructure(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();

app.MapControllers();

app.Run();
