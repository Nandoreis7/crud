using Microsoft.EntityFrameworkCore;
using CadastroApp.Data;

var builder = WebApplication.CreateBuilder(args);

// conexao com o banco DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 21))));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Cadastro}/{action=Index}/{id?}");
});

app.Run();
