namespace agenda.Models;

public class Telefono
{
    public Guid telefonoId {get;set;}
    public int numero {get;set;}
    public Guid codigoAreaId {get;set;}
    public Guid personaId {get;set;}
    public virtual CodigoArea ?CodigoArea {get;set;}
    public virtual Persona ?Persona {get;set;}
}