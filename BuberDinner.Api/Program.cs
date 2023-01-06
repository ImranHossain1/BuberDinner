using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    object value = builder.Services
    .AddApplication()
    .AddAInfrastructure(builder.Configuration);
    builder.Services.AddControllers();
}

var app = builder.Build();
{

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}