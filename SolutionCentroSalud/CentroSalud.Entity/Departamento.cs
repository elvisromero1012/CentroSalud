using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

/// <summary>Departamento o área del centro de salud.</summary>
public class Departamento
{
    [Key]
    public int IdDepartamento { get; set; }
    public string Nombre { get; set; } = null!;
    public string? Descripcion { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    // Enlace: un departamento tiene MUCHOS empleados
    public virtual ICollection<Empleado> Empleados { get; set; }

    public Departamento()
    {
        Empleados = new HashSet<Empleado>();
    }
}