using Domain.Repositories;
using AutoMapper;
using Domain;
using Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddSingleton<IPropertiesRepository, PropertiesRepository>()
    .AddAutoMapper(typeof(AutoMapperProfile))
    .AddTransient<IPropertyListingService, PropertyListingService>()
    .AddTransient<IPropertyManagementService, PropertyManagementService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PropertyListing}/{action=ListAll}");

app.Run();
