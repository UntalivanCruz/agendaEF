using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agenda.Models;

public class Telefono
{
    [Key]
    public Guid TelefonoId { get; set; }

    [Required]
    public int Numero { get; set; }

    [ForeignKey("CodigoAreaId")]
    public Guid CodigoAreaId { get; set; }

    [ForeignKey("PersonaId")]
    public Guid PersonaId { get; set; }

    public virtual CodigoArea? CodigoArea { get; set; }

    public virtual Persona? Persona { get; set; }
}