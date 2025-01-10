using Sandbox.Api.Services;
using Sandbox.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

var app = builder.Build();

app.UseServices();

app.MapGet("/weatherforecast", () => WeatherForecastService.GetForeCast())
    .WithName("GetWeatherForecast")
    .WithOpenApi();

await app.RunAsync();
