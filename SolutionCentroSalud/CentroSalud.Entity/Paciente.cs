using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class Paciente
{
    [Key]
    public int IdPaciente { get; set; }

    public string Cedula { get; set; } = null!;
    public string Nombres { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public DateTime FechaNacimiento { get; set; }
    public string? Sexo { get; set; }
    public string? Telefono { get; set; }
    public string? Direccion { get; set; }
    public string? Correo { get; set; }
    public string? TipoSangre { get; set; }
    public string? Seguro { get; set; }
    public string? ContactoEmergencia { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public virtual ICollection<Cita> Citas { get; set; }

    public Paciente()
    {
        Citas = new HashSet<Cita>();
    }
}
