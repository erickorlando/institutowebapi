using Instituto.Datos;
using Instituto.Entidades;
using Instituto.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<InstitutoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IAlumnoRepository, AlumnoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("api/Alumnos", async (IAlumnoRepository repository) =>
{
    var response = await repository.ListAsync();
    return Results.Ok(response);
});

app.MapPost("api/Alumnos", async (IAlumnoRepository repository, Alumno request) =>
{
    await repository.AddAsync(request);

    return Results.Ok(await repository.ListAsync());
});

app.MapDelete("api/Alumnos/{id:int}", async (IAlumnoRepository repository, int id) =>
{
    await repository.DeleteAsync(id);

    return Results.Ok(await repository.ListAsync());
});

app.MapDelete("api/Alumnos/todos", async (IAlumnoRepository repository) =>
{
    await repository.EliminarTodos();

    return Results.Ok();
});

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<InstitutoDbContext>();

    dbContext.Database.Migrate(); // Ejecuta la migracion
}


app.Run();
