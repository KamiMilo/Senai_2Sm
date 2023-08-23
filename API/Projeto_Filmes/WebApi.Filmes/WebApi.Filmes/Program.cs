var builder = WebApplication.CreateBuilder(args);

//adiciona o serviço do controller
builder.Services.AddControllers();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//adiciona o mapeamento dos controllers
app.MapControllers();

app.UseHttpsRedirection();

app.Run();


