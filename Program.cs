using System.Data;
using Microsoft.EntityFrameworkCore;
using RestAPI.Business;
using RestAPI.Business.Implementation;
using RestAPI.Data;
using RestAPI.Models;
using RestAPI.Repository;
using RestAPI.Repository.Implementation;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

AddLog();

#region  Business
builder.Services.AddScoped<IPersonBusiness, PersonBusiness>();

#endregion

#region Repository
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
#endregion

#region Context
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors());
#endregion
          
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
     MigrateDataBase();
     app.UseOpenApi();
     app.UseSwaggerUi();
     app.UseReDoc(options =>
    {
        options.Path = "/redoc";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void AddLog()
{
    Log.Logger = new LoggerConfiguration()
        .WriteTo
        .Console()
        .CreateLogger();
}

void MigrateDataBase()
{
    try
    {
        using(var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.Migrate();
        }
    }
    catch (Exception ex)
    {
        Log.Error("Database Migration Failed", ex);
    }
}