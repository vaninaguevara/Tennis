using Tennis.API.Middlewares;
using Microsoft.AspNetCore.Authentication;
using Tennis.API.Filters;
using Tennis.API.Middlewares.MiddlewaresService.Interfaces;
using Tennis.API.Middlewares.MiddlewaresService;
using Tennis.Configuration;
using EscuelaDotNetAbril2024.API.Middlewares;
using Tennis.Services.Interfaces;
using Tennis.Services;
using Tennis.API.Services.Encryption;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTennisDbConfiguration();
builder.Services.AddEcnryptionOptions();
builder.Services.AddAuthenticationOptions();
builder.Services.ConfigureJwt();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<CustomFilter>();
builder.Services.AddScoped<IExceptionService, ExceptionService>();
builder.Services.AddScoped<IEncryptionService, EncryptionService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseAuthorization();

app.UseMiddleware<CustomMiddleware>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
