using System.Collections.Generic;
using MarcosM3.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MarcosM3.Web.Models
{
    public class CotizacionViewModel
    {
        public int Cantidad { get; set; }

        public decimal Largo { get; set; }

        public decimal Ancho { get; set; }

        public Moldura Moldura { get; set; }

        public decimal Precio { get; set; }

        public int Desperdicio { get; set; }
        public bool ConMacocel { get; set; }

        public List<SelectListItem> Molduras { get; set; }
    }
}
