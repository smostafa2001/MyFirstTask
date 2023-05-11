using Microsoft.EntityFrameworkCore;
using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;
using Mostafa.Application.Services.FactorItems.Commands.EditFactorItem;
using Mostafa.Application.Services.FactorItems.Commands.GetFactorItemDetails;
using Mostafa.Application.Services.FactorItems.Commands.RemoveFactorItem;
using Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;
using Mostafa.Application.Services.Factors.Commands.AddFactors;
using Mostafa.Application.Services.Factors.Commands.EditFactors;
using Mostafa.Application.Services.Factors.Commands.GetFactor;
using Mostafa.Application.Services.Factors.Commands.GetFactorDetails;
using Mostafa.Application.Services.Factors.Commands.RemoveFactor;
using Mostafa.Application.Services.Factors.Queries.GetFactors;
using Mostafa.Application.Services.Products.Queries.GetProduct;
using Mostafa.Application.Services.Products.Queries.GetProducts;
using Mostafa.Application.Services.Units.Queries.GetUnits;
using Mostafa.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MostafaDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MostafaFactor")));
builder.Services.AddScoped<IDbContext, MostafaDbContext>();
builder.Services.AddTransient<IGetFactorsService, GetFactorsService>();
builder.Services.AddTransient<IAddFactorService, AddFactorService>();
builder.Services.AddTransient<IEditFactorService, EditFactorService>();
builder.Services.AddTransient<IGetFactorService, GetFactorService>();
builder.Services.AddTransient<IRemoveFactorService, RemoveFactorService>();
builder.Services.AddTransient<IGetFactorItemsService, GetFactorItemsService>();
builder.Services.AddTransient<IAddFactorItemService, AddFactorItemService>();
builder.Services.AddTransient<IGetProductsService, GetProductsService>();
builder.Services.AddTransient<IGetUnitsService, GetUnitsService>();
builder.Services.AddTransient<IGetFactorDetailsService, GetFactorDetailsService>();
builder.Services.AddTransient<IAddFactorItemService, AddFactorItemService>();
builder.Services.AddTransient<IEditFactorItemService, EditFactorItemService>();
builder.Services.AddTransient<IGetFactorItemDetailsService, GetFactorItemDetailsService>();
builder.Services.AddTransient<IRemoveFactorItemService, RemoveFactorItemService>();
builder.Services.AddTransient<IGetProductService, GetProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
