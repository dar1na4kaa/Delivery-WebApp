using Application.Interfaces;
using Application.Services;
using Infrastructure;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Presentation.Controllers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews()
    .AddApplicationPart(typeof(DeliveryController).Assembly);

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddDbContext<DeliveryOrderDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();
app.UseStaticFiles();



using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider
        .GetRequiredService<DeliveryOrderDbContext>();

    db.Database.Migrate();
}


app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Delivery}/{action=Index}/{id?}");

app.Run();