var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ICalculatorRepository, CalculatorRepository>();

builder.Services.AddCarter();
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.MapCarter();

app.MapGet("/", () => "Calculator Server");

app.Run();
