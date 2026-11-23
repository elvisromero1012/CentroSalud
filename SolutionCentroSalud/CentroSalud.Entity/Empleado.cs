using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

/// <summary>Empleado del centro de salud.</summary>
public class Empleado
{
    [Key]
    public int IdEmpleado { get; set; }
    public string Cedula { get; set; } = null!;
    public string Nombres { get; set; } = null!;
    public string Apellidos { get; set; } = null!;
    public string? Cargo { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int IdDepartamento { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    // Enlace: su departamento (uno solo)
    public virtual Departamento? Departamento { get; set; }
}