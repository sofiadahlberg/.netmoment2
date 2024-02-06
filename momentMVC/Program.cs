var builder = WebApplication.CreateBuilder(args);
//Aktivera MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Start}/{action=Index}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=BusInfo}/{action=BusInformation}"
);


app.Run();
