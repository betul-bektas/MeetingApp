var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

//{controller=Home}/action/id?
//app.MapDefaultControllerRoute();
//mvc şablonu oluşturmak için yukarıdaki ile aynı 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);


app.Run();
