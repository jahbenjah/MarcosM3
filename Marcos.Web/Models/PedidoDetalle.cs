using System.ComponentModel.DataAnnotations.Schema;

namespace Marcos.Models
{
    public class PedidoDetalle
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int Cantidad { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal PecioUnitario { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Total { get; set; }
        public Pedido Pedido { get; set; }

    }
}
