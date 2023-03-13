var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); 

builder.Services.AddHttpContextAccessor();  
builder.Services.AddSession(); 

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseSession();  

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); 


app.Run();