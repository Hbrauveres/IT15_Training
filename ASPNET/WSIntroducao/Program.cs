var builder = WebApplication.CreateBuilder(args); // Padrão de projeto OOP, BUILDER - Configura aplicação web

// Add services to the container ASP.NET -> Roda em um servidor web (QUALQUER SERVIDOR: IIS, Kestrel(padrão/proxy), Apache, ...).

builder.Services.AddControllers(); // Adiciona Gerenciador de Controladores do web API
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // 
builder.Services.AddSwaggerGen(); // Adiciona gerador de documentação do swagger

var app = builder.Build(); // APLICAÇÃO WEB CONFIGURADA

// Configure the HTTP request pipeline (Middlewares).
if (app.Environment.IsDevelopment())
{
    // Configura swagger somente em ambiente de desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // Configra redirecionamento de http para https

app.UseAuthorization(); // Sistema de autorização anonima ( não possui processo de autenticaçao )

app.MapControllers(); // Mapeamento de Controladores

app.Run(); // Executa!
