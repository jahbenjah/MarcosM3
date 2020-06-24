using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Marcos.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Precio { get; set; }

        public UnidadDeMedida UnidadDeMedida { get; set; }
    }

    public enum UnidadDeMedida 
    {
        Pieza,
        MetroLinea,
        MetroCuadrado
    }
}
