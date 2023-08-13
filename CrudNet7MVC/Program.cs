using CrudNet7MVC.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure SQL DB connection
builder.Services.AddDbContext<ApplicationDbContext>(
    options =>
    {
        var connetionString = builder.Configuration.GetConnectionString("ConnectionSQL");
        options.UseMySql(connetionString, ServerVersion.AutoDetect(connetionString));

    });

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

