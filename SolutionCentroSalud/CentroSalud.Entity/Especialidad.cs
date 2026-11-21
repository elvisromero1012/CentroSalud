using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class Especialidad
{
    [Key]
    public int IdEspecialidad { get; set; }

    public string Nombre { get; set; } = null!;
    public string? Descripcion { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public virtual ICollection<Medico> Medicos { get; set; }

    public Especialidad()
    {
        Medicos = new HashSet<Medico>();
    }
}
