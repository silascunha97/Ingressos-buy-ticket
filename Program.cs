using Ingressos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar a string de conexão
builder.Services.AddDbContext<IngressosContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("IngressosConnection")));

// Configurar outros serviços
builder.Services.AddControllers();
// ...

var app = builder.Build();

// Configurar pipeline de requisições
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
