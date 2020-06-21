using System.Diagnostics;
using System.Linq;
using MarcosM3.Infrastructure;
using MarcosM3.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace MarcosM3.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MarcosM3DbContext _context;

        public HomeController(ILogger<HomeController> logger, MarcosM3DbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Cotizacion()
        {
            var model = new CotizacionViewModel() { Cantidad = 1 };
            model.Molduras = _context.Molduras.Select(moldura => new SelectListItem()
            {
                Text = moldura.Nombre,
                Value = $"{moldura.Desperdicio},{moldura.Precio}"
            }).ToList();
            return View(model);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
