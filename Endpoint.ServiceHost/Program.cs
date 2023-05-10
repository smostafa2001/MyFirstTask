using Microsoft.EntityFrameworkCore;
using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Application.Services.FactorItems.Commands.AddFactorItem;
using Mostafa.Application.Services.FactorItems.Queries.GetFactorItems;
using Mostafa.Application.Services.Factors.Commands.AddFactor;
using Mostafa.Application.Services.Factors.Commands.EditFactor;
using Mostafa.Application.Services.Factors.Commands.GetFactor;
using Mostafa.Application.Services.Factors.Commands.RemoveFactor;
using Mostafa.Application.Services.Factors.Queries.GetFactors;
using Mostafa.Application.Services.Products.Queries;
using Mostafa.Application.Services.Units.Queries;
using Mostafa.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MostafaDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("MostafaFactor")));
builder.Services.AddScoped<IDbContext, MostafaDbContext>();
builder.Services.AddScoped<IGetFactorsService, GetFactorsService>();
builder.Services.AddScoped<IAddFactorService, AddFactorService>();
builder.Services.AddScoped<IEditFactorService, EditFactorService>();
builder.Services.AddScoped<IGetFactorService, GetFactorService>();
builder.Services.AddScoped<IRemoveFactorService, RemoveFactorService>();
builder.Services.AddScoped<IGetFactorItemsService, GetFactorItemsService>();
builder.Services.AddScoped<IAddFactorItemService, AddFactorItemService>();
builder.Services.AddScoped<IGetProductsService, GetProductsService>();
builder.Services.AddScoped<IGetUnitsService, GetUnitsService>();

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
