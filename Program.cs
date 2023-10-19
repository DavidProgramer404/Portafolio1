var builder = WebApplication.CreateBuilder(args);
// add our service

builder.Services.AddControllersWithViews();
var app = builder.Build();

// Our builder Code

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

