using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

/// <summary>Usuario que inicia sesión en el sistema.</summary>
public class Usuario
{
    [Key]
    public int IdUsuario { get; set; }
    public string NombreCompleto { get; set; } = null!;
    public string NombreUsuario { get; set; } = null!;
    public string Clave { get; set; } = null!;       // contraseña
    public string? Correo { get; set; }
    public string? Telefono { get; set; }
    public int IdRol { get; set; }
    public string? UrlFoto { get; set; }
    public string? NombreFoto { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    // Enlace: su rol (uno solo)
    public virtual Rol? Rol { get; set; }
}