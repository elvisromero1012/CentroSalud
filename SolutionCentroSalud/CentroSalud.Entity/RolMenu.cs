using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class RolMenu
{
    [Key]
    public int IdRolMenu { get; set; }
    public int IdRol { get; set; }
    public int IdMenu { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public virtual Rol? Rol { get; set; }
    public virtual Menu? Menu { get; set; }
}