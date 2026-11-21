using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class Configuracion
{
    [Key]
    public int IdConfiguracion { get; set; }
    public string Recurso { get; set; } = null!;
    public string Propiedad { get; set; } = null!;
    public string? Valor { get; set; }
}