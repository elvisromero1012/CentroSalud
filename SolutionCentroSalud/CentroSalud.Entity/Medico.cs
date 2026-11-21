using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class Medico
{
    [Key]
    public int IdMedico { get; set; }

    public string Cedula { get; set; } = null!;
    public string Nombres { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public string? Exequatur { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public int IdEspecialidad { get; set; }
    public string? UrlFoto { get; set; }
    public string? NombreFoto { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public virtual Especialidad? Especialidad { get; set; }
    public virtual ICollection<Cita> Citas { get; set; }

    public Medico()
    {
        Citas = new HashSet<Cita>();
    }
}
