using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pesquisa.Data;
using pesquisa.Models;

namespace pesquisa.Controllers
{
    public class PbhxmlprestlistfilesController : Controller
    {
        private readonly roboshomologacaoContext _context;

        public PbhxmlprestlistfilesController(roboshomologacaoContext context)
        {
            _context = context;
        }

        // GET: Pbhxmlprestlistfiles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pbhxmlprestlistfile.ToListAsync());
        }

        // GET: Pbhxmlprestlistfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pbhxmlprestlistfile = await _context.Pbhxmlprestlistfile
                .FirstOrDefaultAsync(m => m.id == id);
            if (pbhxmlprestlistfile == null)
            {
                return NotFound();
            }

            return View(pbhxmlprestlistfile);
        }

        // GET: Pbhxmlprestlistfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pbhxmlprestlistfiles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,caminho,cnpj,status,datain,idFilial,idEmpresa")] Pbhxmlprestlistfile pbhxmlprestlistfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pbhxmlprestlistfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pbhxmlprestlistfile);
        }

        // GET: Pbhxmlprestlistfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pbhxmlprestlistfile = await _context.Pbhxmlprestlistfile.FindAsync(id);
            if (pbhxmlprestlistfile == null)
            {
                return NotFound();
            }
            return View(pbhxmlprestlistfile);
        }

        // POST: Pbhxmlprestlistfiles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,caminho,cnpj,status,datain,idFilial,idEmpresa")] Pbhxmlprestlistfile pbhxmlprestlistfile)
        {
            if (id != pbhxmlprestlistfile.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pbhxmlprestlistfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PbhxmlprestlistfileExists(pbhxmlprestlistfile.id))
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
            return View(pbhxmlprestlistfile);
        }

        // GET: Pbhxmlprestlistfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pbhxmlprestlistfile = await _context.Pbhxmlprestlistfile
                .FirstOrDefaultAsync(m => m.id == id);
            if (pbhxmlprestlistfile == null)
            {
                return NotFound();
            }

            return View(pbhxmlprestlistfile);
        }

        // POST: Pbhxmlprestlistfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pbhxmlprestlistfile = await _context.Pbhxmlprestlistfile.FindAsync(id);
            _context.Pbhxmlprestlistfile.Remove(pbhxmlprestlistfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PbhxmlprestlistfileExists(int id)
        {
            return _context.Pbhxmlprestlistfile.Any(e => e.id == id);
        }
    }
}
