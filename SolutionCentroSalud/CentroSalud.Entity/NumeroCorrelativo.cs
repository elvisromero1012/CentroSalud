using System.ComponentModel.DataAnnotations;

namespace CentroSalud.Entity;

public class NumeroCorrelativo
{
    [Key]
    public int IdNumeroCorrelativo { get; set; }
    public string Gestion { get; set; } = null!;
    public int UltimoNumero { get; set; }
    public int CantidadDigitos { get; set; }
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;
}