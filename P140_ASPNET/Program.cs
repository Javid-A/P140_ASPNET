var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(ep =>
{
    ep.MapControllerRoute("custom", "esas-sehife", new { controller = "home", action = "index" });
    ep.MapControllerRoute("default", "{controller=home}/{action=index}");
    ep.MapControllerRoute("custom", "haqqinda", new { controller = "home", action = "about" });
});

app.Run();
