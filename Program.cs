using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FoodApp.Data;
using System.Xml.Linq;
using FoodApp.Repositories.Interfaces;
using FoodApp.Repositories.Implementations;
using FoodApp.Services.Interfaces;
using FoodApp.Services.Implementations;
var builder = WebApplication.CreateBuilder(args);
// 1. Register Core Controllers framework service so .NET finds your web endpoints
 builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Register DbContext with SQL Server
builder.Services.AddDbContext<FoodAppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDataConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();//we are injecting UserRepository here
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Exposes the live metadata description file layout at: /openapi/v1.json
    app.MapOpenApi();
}
app.UseHttpsRedirection();
// 4. MAP THE INCOMING ENDPOINTS (Tells the web server to start reading your Controllers folder layout)
app.MapControllers();
app.Run();
