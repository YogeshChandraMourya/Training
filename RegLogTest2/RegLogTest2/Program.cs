using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RegLogTest2.Areas.Identity.Data;
using RegLogTest2.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("RegLogTestDBContextConnection") ?? throw new InvalidOperationException("Connection string 'RegLogTestDBContextConnection' not found.");

builder.Services.AddDbContext<RegLogTestDBContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<RegLogTestDBContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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
    pattern: "/{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();

app.Run();
