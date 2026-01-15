using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços para OpenAPI e Swagger
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API do ModuloApi",
        Version = "v1",
        Description = "Uma API de exemplo para explorar recursos do .NET 9",
        Contact = new OpenApiContact
        {
            Name = "Equipe de Desenvolvimento",
            Email = "contato@moduloapi.com"
        }
    });
});

var app = builder.Build();

// Configurar pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(config =>
    {
        config.SwaggerEndpoint("/swagger/v1/swagger.json", "API do ModuloApi v1");
        config.RoutePrefix = "swagger";
    });
}
else
{
    app.UseHttpsRedirection();
}

// Seu endpoint de exemplo permanece inalterado
var resumos = new[]
{
    "Congelante", "Revigorante", "Fresco", "Frio", "Suave", "Quente", "Agradável", "Quente", "Abrasador", "Incandescente"
};

app.MapGet("/previsao-tempo", () =>
{
    var previsao = Enumerable.Range(1, 5).Select(indice =>
        new PrevisaoTempo
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(indice)),
            Random.Shared.Next(-20, 55),
            resumos[Random.Shared.Next(resumos.Length)]
        ))
        .ToArray();
    return previsao;
})
.WithName("ObterPrevisaoTempo");

await app.RunAsync();

record PrevisaoTempo(DateOnly Data, int TemperaturaC, string? Resumo)
{
    public int TemperaturaF => 32 + (int)(TemperaturaC / 0.5556);
}