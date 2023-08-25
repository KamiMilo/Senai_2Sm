using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//adiciona o servi�o do controller
builder.Services.AddControllers();

//Adiciona o Servi�o de Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        //Adiciona informa��es sobre a API no SWAGGER
        Version = "v1",
        Title = "API Filmes Manh�",
        Description = "API Para gerenciamento de Filmes- Introdu��o da sprint 2 / Backend API",
        Contact = new OpenApiContact
        {
            Name = "Senai �nformatica/Aluna:Kamille Milo",
            Url = new Uri("https://github.com/KamiMilo")
        },

    });

    //Configura o Swagger para usar o arquivo XML gerado com as instru��es anteriores.
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

});


var app = builder.Build();

//Come�a a configura��o do swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

//app.MapGet("/", () => "Hello World!");

//adiciona o mapeamento dos controllers
app.MapControllers();

app.UseHttpsRedirection();

app.Run();


