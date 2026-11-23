using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

/// <summary>Rol de acceso de los usuarios del sistema.</summary>
public class Rol
{
    [Key]
    public int IdRol { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Descripcion { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    // Enlaces
    public virtual ICollection<Usuario> Usuarios { get; set; }   // usuarios con este rol
    public virtual ICollection<RolMenu> RolMenus { get; set; }   // opciones de menú permitidas

    public Rol()
    {
        Usuarios = new HashSet<Usuario>();
        RolMenus = new HashSet<RolMenu>();
    }
}