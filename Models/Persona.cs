using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda.Models;

public class Persona
{
    [Key]
    public Guid PersonaId { get; set; }

    [Required]
    [MaxLength(250)]
    public string? Nombre { get; set; }

    [Required]
    [MaxLength(250)]
    public string? Apellido { get; set; }

    [MaxLength(100)]
    public string? Alias { get; set; }

    public DateOnly FechaNac { get; set; }

    public Sexo Sexo { get; set; }

    public EstadoCivil EstadoCivil { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Telefono>? Telefonos { get; set; }

    [NotMapped]
    public int Edad { get; set; }
}

public enum Sexo
{
    Masculino,
    Femenino,
    NoEspecificar
}

public enum EstadoCivil
{
    Soltero,
    Casado,
    Viudo,
    Divorciado,
    UnionLibre
}