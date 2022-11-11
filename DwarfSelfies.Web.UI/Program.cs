using DwarfSelfies.Core.Infrastructures.Data;
using DwarfSelfies.Web.UI.Controllers;
using DwarfSelfies.Web.UI.Models;
using DwarfSelfies.Web.UI.Tools.Injections;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DwarfSelfies.Web.UI.Data;
using DwarfSelfies.Web.UI.Areas.Identity.Data;


//Console.WriteLine("coucou");



////Action<string> afficher = Console.WriteLine;
////afficher("coucou");


//void CalculerEtAfficher(int a, int b)
//{
//    var result = a + b;
//    Console.WriteLine(result);
//}

//CalculerEtAfficher(1, 2);

//void CalculerEtAfficher2(int a, int b, Action<string> afficher)
//{
//    // Calculer
//    var result = a + b;
//    // Afficher
//    afficher.Invoke(result.ToString());
//}

//CalculerEtAfficher2(1, 2, Console.WriteLine);

//void AfficherEnRouge(string message)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(message);
//    Console.ForegroundColor = ConsoleColor.White;
//}

//CalculerEtAfficher2(1, 2, AfficherEnRouge);

//Action<string> uneMethode = mess =>
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(mess);
//    Console.ForegroundColor = ConsoleColor.White;
//};

//CalculerEtAfficher2(1, 2, uneMethode);




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DefaultDbContext>(options =>
{
    string chaineDeConnexion = builder.Configuration.GetConnectionString("SelfieDb");

    // builder.Configuration["MaConfigAMoi:Test"]

    options.UseSqlServer(chaineDeConnexion, optionsPourSqlServer =>
    {
        optionsPourSqlServer.CommandTimeout(2000);
    });
}, ServiceLifetime.Scoped);

builder.Services.AddDefaultIdentity<DwarfSelfiesWebUIUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DwarfSelfiesWebUIContext>();

builder.Services.DefineCustomInjections();

var app = builder.Build();
//-------------------------



// Configure the HTTP request pipeline.

// app.Environment.EnvironmentName == "Test";

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();;
app.UseAuthorization();
app.DefineCustomRoutes();


app.Run();
