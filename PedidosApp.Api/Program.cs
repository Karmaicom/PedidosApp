using Scalar.AspNetCore;

namespace PedidosApp.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        // exibir url dos endpoints em letras minúsculas
        builder.Services.AddRouting(map => map.LowercaseUrls = true);

        //Swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment() 
            || app.Environment.IsProduction())
        {
            app.MapOpenApi();
        }

        //Swagger
        app.UseSwagger();
        app.UseSwaggerUI();

        //Scalar
        app.MapScalarApiReference(options =>
        {
            options.WithTheme(ScalarTheme.BluePlanet);
        });


        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}