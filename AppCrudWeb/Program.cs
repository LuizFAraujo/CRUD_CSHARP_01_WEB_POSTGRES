using AppCrudWeb.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//------------------------------------
// String de Conexão
var strConn = @"
Host=localhost;
Port=5432;
Pooling=true;
Database=CRUD_POSTGRES_TESTE;
User Id=postgres;
Password=postgres;
";

// Para configuração da String de Conexão
builder.Services.AddEntityFrameworkNpgsql().
    AddDbContext<Contexto>(options =>
    options.UseNpgsql(strConn));

// Para instalar (versão mais recente) o Postgres (Npgsql) via comando:
// Install-Package Npgsql.EntityFrameworkCore.PostgreSQL

// Campos sempre acima do builder.Build()
//------------------------------------




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
