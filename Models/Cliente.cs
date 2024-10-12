using System.ComponentModel.DataAnnotations;
namespace Inventario.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }

        [Required]
        [StringLength(8)]
        public string Telefono { get; set; }
    }
}
