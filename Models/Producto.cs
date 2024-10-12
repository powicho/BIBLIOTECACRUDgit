using System.ComponentModel.DataAnnotations;
namespace Inventario.Models
{ 
public class Producto
{
    public int ProductoId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
    public decimal Precio { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0")]
    public int Cantidad { get; set; }
}
}
