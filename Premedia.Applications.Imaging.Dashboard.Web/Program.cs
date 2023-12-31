using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Premedia.Applications.Imaging.Dashboard.ActionFIlters;
using Premedia.Applications.Imaging.Dashboard.Application.Mappings;
using Premedia.Applications.Imaging.Dashboard.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.Configuration.AddJsonFile("appsettings.json", false, true);
builder.Configuration.AddJsonFile($"appsettings.{environment}.json", true, true);
var loggerConfig = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .CreateLogger();

try
{
    // Logging
    builder.Host.UseSerilog();
    Log.Logger = loggerConfig;
    Log.Information("Starting host...");

    // Set configurations and register services
    builder.Services.ConfigureClient(builder.Configuration);
    
    builder.Services.ConfigureSwagger();
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddAutoMapper(typeof(UserMapping));

    builder.Services.AddControllers(config =>
    {
        config.Filters.Add(new ModelStateValidationFilter());
        config.Filters.Add(new HttpResponseExceptionFilter());
    });
    
    if (!builder.Environment.IsEnvironment("Local"))
        builder.Services.AddSpaStaticFiles(configuration => { configuration.RootPath = "wwwroot"; });

    var app = builder.Build();

// Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment() || app.Environment.IsLocal())
    {
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
        app.UseOpenApi();
        app.UseSwaggerUi3();
    }

    app.UseStatusCodePages(); // Needed for better auth error output in swagger
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseRouting();

    app.UseCors(policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
    
    app.MigrateDatabase();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");

    if (!app.Environment.IsLocal())
    {
        app.UseSpaStaticFiles();
        app.UseSpa(spa =>
        {
            spa.Options.StartupTimeout = TimeSpan.FromMinutes(5);
            spa.Options.SourcePath = "ClientApp";

            // if (app.Environment.IsEnvironment("Local"))
            // {
            //     spa.UseAngularCliServer(npmScript: "start:dev");
            //     spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            // }
            // else
            // {
            Debug.WriteLine(
                "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Debug.WriteLine(
                "! Warning: Angular CLI Server nicht gestartet - im 'dist' Ordner m�ssen Dateien liegen damit das funktioniert! !");
            Debug.WriteLine(
                "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            // }
        });
    }

    app.Run();

}
catch (Exception ex)
{
    Console.WriteLine("Host terminated unexpectedly.");
    Console.WriteLine(ex.Message);
    Log.Fatal(ex, "Host terminated unexpectedly.");
}
finally
{
    Log.CloseAndFlush();
}