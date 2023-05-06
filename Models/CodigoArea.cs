namespace agenda.Models;

public class CodigoArea
{
    public Guid CodigoAreaId {get;set;}
    public int numero {get;set;}
    public string ?pais {get;set;}
    public virtual ICollection<Telefono> ?Telefonos {get;set;}
}