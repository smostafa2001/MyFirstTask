using Microsoft.EntityFrameworkCore;
using Mostafa.Application.Interfaces.Contexts;
using Mostafa.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MostafaDbContext>(option=>option.UseSqlServer(builder.Configuration.GetConnectionString("MostafaFactor")));
builder.Services.AddScoped<IDbContext, MostafaDbContext>();

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
