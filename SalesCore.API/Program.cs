using Microsoft.EntityFrameworkCore;
using SalesCore.Application.Services;
using SalesCore.Domain.Repositories;
using SalesCore.Infrastructure.Data;
using SalesCore.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<SalesCoreDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("SalesCore");
    if (string.IsNullOrWhiteSpace(connectionString))
    {
        throw new InvalidOperationException(
            "Configure ConnectionStrings:SalesCore em appsettings.Development.json ou pela variável de ambiente ConnectionStrings__SalesCore.");
    }

    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<EmpresaService>();
builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
builder.Services.AddScoped<ContatoService>();
builder.Services.AddScoped<IOportunidadeRepository, OportunidadeRepository>();
builder.Services.AddScoped<OportunidadeService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<UsuarioService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
