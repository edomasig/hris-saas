using HRIS.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 1. Add CORS service
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorClient",
        policy =>
        {
            policy.WithOrigins("https://localhost:7220") // Blazor WASM dev server URL
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Add DbContext
builder.Services.AddDbContext<HRISDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("HRISDatabase"))    
);

builder.Services.AddControllers();

var app = builder.Build();

// 2. Enable CORS before Authorization
app.UseCors("AllowBlazorClient");

app.UseAuthorization();

app.MapControllers();

app.Run();
