using ModuloApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços
builder.Services.AddSwaggerConfiguration();
builder.Services.AddControllers();

var app = builder.Build();

// Configurar pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerConfiguration();
}
else
{
    app.UseHttpsRedirection();
}

app.MapControllers();

await app.RunAsync();