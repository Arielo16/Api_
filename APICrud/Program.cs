using Microsoft.EntityFrameworkCore;
using APICrud.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuración de DbContext con MySQL
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 21))));

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
