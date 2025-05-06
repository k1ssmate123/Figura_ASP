using FiguraRestaurant.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();  
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);  
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.Cookie.SameSite = SameSiteMode.Lax; 
});

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<UserDbContext>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddHttpContextAccessor();
var app = builder.Build();
app.UseStaticFiles();      
app.UseSession();          
app.UseRouting();
app.UseAuthorization();


app.MapControllerRoute(
    name: "controller_route",
    pattern: "{controller}/{action}/{id?}");

app.MapControllerRoute(
    name: "default_short",
    pattern: "{action=Index}/{id?}",
    defaults: new { controller = "Site" });


app.Run();

