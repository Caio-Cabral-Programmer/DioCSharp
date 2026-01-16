using ModuloApi.Extensions;
using ModuloApi.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços

// Configura o DbContext para usar SQL Server com a string de conexão do appsettings.Development.json
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao"))
); 

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