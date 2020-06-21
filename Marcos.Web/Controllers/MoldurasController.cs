using System.Linq;
using System.Threading.Tasks;
using Marcos.Data;
using Marcos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MarcosControllers
{
    public class MoldurasController : Controller
    {
        private readonly MarcosDbContext _context;

        public MoldurasController(MarcosDbContext context)
        {
            _context = context;
        }

        // GET: Molduras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Molduras.ToListAsync());
        }

        // GET: Molduras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moldura = await _context.Molduras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moldura == null)
            {
                return NotFound();
            }

            return View(moldura);
        }

        // GET: Molduras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Molduras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Precio,Desperdicio")] Moldura moldura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moldura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moldura);
        }

        // GET: Molduras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moldura = await _context.Molduras.FindAsync(id);
            if (moldura == null)
            {
                return NotFound();
            }
            return View(moldura);
        }

        // POST: Molduras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Precio,Desperdicio")] Moldura moldura)
        {
            if (id != moldura.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moldura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MolduraExists(moldura.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(moldura);
        }

        // GET: Molduras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moldura = await _context.Molduras
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moldura == null)
            {
                return NotFound();
            }

            return View(moldura);
        }

        // POST: Molduras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moldura = await _context.Molduras.FindAsync(id);
            _context.Molduras.Remove(moldura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MolduraExists(int id)
        {
            return _context.Molduras.Any(e => e.Id == id);
        }
    }
}
