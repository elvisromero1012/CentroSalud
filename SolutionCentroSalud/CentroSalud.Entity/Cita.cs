using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class Cita
{
    [Key]
    public int IdCita { get; set; }
    public string NumeroCita { get; set; } = null!;
    public int IdPaciente { get; set; }
    public int IdMedico { get; set; }
    public DateTime FechaHora { get; set; }
    public string Motivo { get; set; } = null!;
    public string Estado { get; set; } = "Programada";
    public string? Observaciones { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    public virtual Paciente? Paciente { get; set; }
    public virtual Medico? Medico { get; set; }
}