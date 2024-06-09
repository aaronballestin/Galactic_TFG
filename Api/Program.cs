using GalacticApi.Data;
using GalacticApi.Models;
using GalacticApi.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Filters;


var builder = WebApplication.CreateBuilder(args);

//Logger
builder.Services.AddControllers();
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Filter.ByExcluding(Matching.FromSource("Microsoft"))
    .WriteTo.File("../logs/errorlogs.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(dispose: true);



// Add services to the container.

builder.Services.AddScoped<IUsuarioService, UsuarioService>(); 
builder.Services.AddScoped<ICursoService, CursoService>(); 
builder.Services.AddScoped<IAsignaturaService, AsignaturaService>(); 
builder.Services.AddScoped<IJuegoService, JuegoService>(); 
builder.Services.AddScoped<IPasapalabraService, PasapalabraService>(); 
builder.Services.AddScoped<IPreguntaPasapalabraService, PreguntaPasapalabraService>(); 
builder.Services.AddScoped<ITipoJuegoService, TipoJuegoService>(); 
builder.Services.AddScoped<IBuscadorService, BuscadorService>(); 
builder.Services.AddScoped<IResultadoService, ResultadoService>(); 
builder.Services.AddScoped<IAhorcadoService, AhorcadoService>(); 




var connectionString = builder.Configuration.GetConnectionString("ServerDB");

builder.Services.AddDbContext<GalacticApiContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>(); 
builder.Services.AddScoped<ICursoRepository, CursoRepository>();
builder.Services.AddScoped<IAsignaturaRepository, AsignaturaRepository>(); 
builder.Services.AddScoped<IJuegoRepository, JuegoRepository>(); 
builder.Services.AddScoped<IPasapalabraRepository, PasapalabraRepository>(); 
builder.Services.AddScoped<IPreguntaPasapalabraRepository, PreguntaPasapalabraRepository>(); 
builder.Services.AddScoped<ITipoJuegoRepository, TipoJuegoRepository>(); 
builder.Services.AddScoped<IBuscadorRepository, BuscadorRepository>(); 
builder.Services.AddScoped<IResultadoRepository, ResultadoRepository>(); 
builder.Services.AddScoped<IAhorcadoRepository, AhorcadoRepository>(); 




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


// app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll");

app.MapControllers();

app.Run();