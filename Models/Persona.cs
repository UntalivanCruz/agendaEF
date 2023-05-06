namespace agenda.Models;

public class Persona
{
    public Guid personaId {get;set;}
    public string ?nombre {get;set;}
    public string ?apellido {get;set;}
    public string ?alias {get;set;}
    public DateOnly fechaNac {get;set;}
    public Sexo sexo {get;set;}
    public EstadoCivil estadoCivil {get;set;}
    public string ?correo {get;set;}
    public virtual ICollection<Telefono> ?Telefonos {get;set;}
}

public enum Sexo{
    Masculino,
    Femenino,
    NoEspecificar
}

public enum EstadoCivil{
    Soltero,
    Casado,
    Viudo,
    Divorciado,
    UnionLibre
}