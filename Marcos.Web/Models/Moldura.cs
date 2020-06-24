using System.ComponentModel.DataAnnotations.Schema;

namespace Marcos.Models
{
    public class Moldura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Precio { get; set; }
        public double Desperdicio { get; set; }
        public bool EnExistencia { get; set; }
    }
}
