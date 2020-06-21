using System.ComponentModel.DataAnnotations;

namespace Marcos.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(200)]
        public string RazonSocial { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(20)]
        public string RFC { get; set; }

        [StringLength(50)]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }
        public bool RequiereFactura { get; set; }
    }
}
