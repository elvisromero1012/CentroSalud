using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class Menu
{
    [Key]
    public int IdMenu { get; set; }
    public int? IdMenuPadre { get; set; }
    public string Descripcion { get; set; } = null!;
    public string? Icono { get; set; }
    public string? Controlador { get; set; }
    public string? Accion { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public virtual Menu? MenuPadre { get; set; }
    public virtual ICollection<Menu> MenuHijos { get; set; }
    public virtual ICollection<RolMenu> RolMenus { get; set; }

    public Menu()
    {
        MenuHijos = new HashSet<Menu>();
        RolMenus = new HashSet<RolMenu>();
    }
}