using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marcos.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClineteId { get; set; }
        public string FechaPedido { get; set; }
        public int Estado { get; set; }
        public List<PedidoDetalle> Detalles { get; } = new List<PedidoDetalle>();
    }
}
