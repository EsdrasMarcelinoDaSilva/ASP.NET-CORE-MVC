using Microsoft.EntityFrameworkCore;
using RecodeProject.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CursoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexao")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=HomeEF}/{action=Index}/{id?}");

app.Run();
