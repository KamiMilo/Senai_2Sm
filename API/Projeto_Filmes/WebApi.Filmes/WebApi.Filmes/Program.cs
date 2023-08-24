var builder = WebApplication.CreateBuilder(args);

//adiciona o servi�o do controller
builder.Services.AddControllers();

//Adiciona o Servi�o de Swagger
builder.Services.AddSwaggerGen();

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


