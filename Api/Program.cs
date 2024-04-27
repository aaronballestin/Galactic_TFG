using GalacticApi.Data;
using GalacticApi.Models;
using GalacticApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IUsuarioService, UsuarioService>(); 
builder.Services.AddScoped<ICursoService, CursoService>(); 
builder.Services.AddScoped<IAsignaturaService, AsignaturaService>(); 
builder.Services.AddScoped<IAsignaturaJuegoService, AsignaturaJuegoService>(); 
builder.Services.AddScoped<IJuegoService, JuegoService>(); 




var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<GalacticApiContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); 
builder.Services.AddScoped<ICursoRepository, CursoRepository>();
builder.Services.AddScoped<IAsignaturaRepository, AsignaturaRepository>(); 
builder.Services.AddScoped<IAsignaturaJuegoRepository, AsignaturaJuegoRepository>(); 
builder.Services.AddScoped<IJuegoRepository, JuegoRepository>(); 






// builder.Services.AddScoped<IPizzaRepository, PizzaEFRepository>(serviceProvider => 
//     new PizzaEFRepository(connectionString));
//     new OrderEFRepository(connectionString);
//     new IngredientEFRepository(connectionString);
//     new UserEFRepository(connectionString);



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


// app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(options =>
{
    options.WithOrigins("http://localhost:5173")
           .AllowAnyMethod()
           .AllowAnyHeader()
           .AllowCredentials();
});

app.MapControllers();

app.Run();