namespace Sandbox.Api.Extensions;

internal static class WebApplicationExtensions 
{
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder) 
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        return builder;
    }

    public static WebApplication UseServices(this WebApplication app) 
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        return app;
    }
}