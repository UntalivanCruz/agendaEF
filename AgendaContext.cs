using agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace agenda;
// Controlador de la base de datos
public class AgendaContext : DbContext
{
    public DbSet<CodigoArea> ?CodigoAreas {get;set;}
    public DbSet<Telefono> ?Telefonos {get;set;}
    public DbSet<Persona> ?Personas {get;set;}

    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){}
}