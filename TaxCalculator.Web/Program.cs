using TaxCalculator.Web.Components;
using Serilog;
using System;

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/taxcalculator-.log", rollingInterval: RollingInterval.Day)
    .CreateLogger();

try
{
    Log.Information("Starting TaxCalculator web application");
    
    var builder = WebApplication.CreateBuilder(args);
    
    // Add Serilog to the logging pipeline
    builder.Host.UseSerilog();
    
    // Add services to the container.
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();
    
    // Add note about .NET 9 upgrade
    Console.WriteLine("Note: This application is built with .NET 8 and should be upgraded to .NET 9 when available.");
    
    var app = builder.Build();
    
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    
    app.UseHttpsRedirection();
    
    app.UseStaticFiles();
    app.UseAntiforgery();
    
    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();
    
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application startup failed");
}
finally
{
    Log.CloseAndFlush();
}
