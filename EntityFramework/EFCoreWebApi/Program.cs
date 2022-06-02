using EFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Adiciona configurações de acesso ao db
builder.Services.AddDbContext<LojinhaContext>(options => { // AddDbContext vem do Microsoft.EntityFramwork
    // Usa o SqlServer e puxa a config de conexão do objeto builder
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    // Habilita logging de dados sensiveis no console
    options.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Adiciona cors a aplicação
builder.Services.AddCors(options => {
    // Definição da politica permissiva de acesso
    options.AddPolicy("AllowAll", builder => {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // Pacote de diagnostico do EFCore gera pagina de status de erro detalhada
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

// Habilita o uso de Cors no pipeline do middleware
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
