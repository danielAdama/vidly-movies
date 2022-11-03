using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using Vidly.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "MoviesByReleaseDate",
//    pattern: "movies/released/{year}/{month}",
//    defaults: new { controller = "Movies", action = "ByReleaseDate" },
//    //Use regex to allow only 4 digits for year and 2 for month
//    constraints: new { year = @"\d{4}", month = @"\d{2}"}
//    );

app.MapControllerRoute(
    name: "MoviesByReleaseDate",
    pattern: "movies/released/{year}/{month}",
    defaults: new { controller = "Movies", action = "ByReleaseDate" },
    //Use regex to allow only 2020, 2021 & 2022 for year and 2 digits for month.
    constraints: new { year = @"2020|2021|2022", month = @"\d{2}"}
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
