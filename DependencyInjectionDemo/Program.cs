using DiLifetimesDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services with different lifetimes
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();

// Add Controllers
builder.Services.AddControllers();

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger middleware in Development & Production
if (app.Environment.IsDevelopment() || app.Environment.IsStaging() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "DI Lifetimes API v1");
        options.RoutePrefix = string.Empty; // Swagger at root (https://localhost:5001)
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
