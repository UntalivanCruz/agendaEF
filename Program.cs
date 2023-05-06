using agenda;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using agenda.Models;

var builder = WebApplication.CreateBuilder(args);

//Construir y pasar la cadena de conexion a la BD
builder.Services.AddSqlServer<AgendaContext>("Data Source=localhost; Initial Catalog=AgendaDB;user id=sa;password=C0ntrol1*;Encrypt=False");

var app = builder.Build();

app.MapGet("/", () => "Hola mundo, estoy en progra IV!");

// ENDPOINT URL que permite validar la existencia de la conexion a la base de SQL Server
app.MapGet("/conndb", ([FromServices] AgendaContext dbContext) => {
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos ONLINE!");
});

// Crear API que consulte todos los codigos de area
app.MapGet("/api/codigoarea", ([FromServices] AgendaContext dbContext) => {
 return Results.Ok(dbContext.CodigoAreas);
});

//REST API = CRUD
// Endpoint Post telefonos CREATE

app.MapGet("/api/telefono", ([FromServices] AgendaContext dbContext) => {
 return Results.Ok(dbContext.Telefonos?.Include(d => d.CodigoArea));
});

app.MapPost("/api/telefono", async ([FromServices] AgendaContext dbContext, [FromBody] Telefono Input_telefono) => {
    Input_telefono.TelefonoId = Guid.NewGuid();
    await dbContext.AddAsync(Input_telefono);
    await dbContext.SaveChangesAsync();
    return Results.Ok("Datos ingresados correctamente, id: "+ Input_telefono.TelefonoId);
});

// Endpoint Get telefonos

// Endpoint Get personas

app.Run();
