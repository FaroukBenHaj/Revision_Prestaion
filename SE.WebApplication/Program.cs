using Microsoft.EntityFrameworkCore;
using SE.ApplicationCore.Interfaces;
using SE.ApplicationCore.Services;
using SE.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// Injection de dépendance
builder.Services.AddDbContext<DbContext, AMContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPrestationService, PrestationService>();
builder.Services.AddScoped<IPrestataireService, PrestataireService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddSingleton<Type>(t => typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
