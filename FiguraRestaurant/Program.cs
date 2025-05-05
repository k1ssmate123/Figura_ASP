using FiguraRestaurant.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<UserDbContext>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

var app = builder.Build();  
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{action=Index}/{id?}",
    defaults: new { controller = "Site" });

app.Run();
