

using DataAccessLayer.Concrete;
using EntitiyLayer.Concrate;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder()
					.RequireAuthenticatedUser()
					.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});
// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddSession();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = new PathString("/Login/AccessDenied");
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
    options.LoginPath = "/Login/Index";
    options.SlidingExpiration = true;
});


builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
    {
        x.LoginPath = "/Login/Index";
    }
    );
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(); 
builder.Services.AddIdentity<AppUser,AppRole>(x=>
{
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Password.RequireNonAlphanumeric = false;
})
    .AddEntityFrameworkStores<Context>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
	name: "Areas",
	pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

//app.UseEndpoints(endpoints =>
//{
    //app.MapControllerRoute(
    //name: "areas",
    //pattern: "{areas=Home}/{controller=Home}/{action=Index}{id?}");

	//endpoints.MapControllerRoute(
 //   name: "default",
 //   pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();




