using System.ComponentModel.DataAnnotations;

namespace Marcos.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClineteId { get; set; }
        public string FechaPedido { get; set; }

    }

    public class PedidoDetalle
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public decimal PecioUnitario { get; set; }
        public string Descripcion { get; set; }
        public decimal Total { get; set; }

    }
}
