using Microsoft.EntityFrameworkCore;
using StudentMngSys.Data;
using StudentMngSys.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Students_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services=scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<Students_Context>();
        context.Database.EnsureCreated();
    }
    catch(Exception ex)
    {
        var logger=services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Database creation failed");
    }
}

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseStaticFiles();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles(); 


app.Run();
