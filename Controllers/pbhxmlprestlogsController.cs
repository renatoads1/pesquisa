using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pesquisa.Data;
using pesquisa.Models.ViewModels;

namespace pesquisa.Controllers
{
    public class pbhxmlprestlogsController : Controller
    {
        private readonly roboshomologacaoContext _context;

        public pbhxmlprestlogsController(roboshomologacaoContext context)
        {
            _context = context;
        }

        // GET: pbhxmlprestlogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.pbhxmlprestlog.ToListAsync());
        }

        // GET: pbhxmlprestlogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pbhxmlprestlog = await _context.pbhxmlprestlog
                .FirstOrDefaultAsync(m => m.id == id);
            if (pbhxmlprestlog == null)
            {
                return NotFound();
            }

            return View(pbhxmlprestlog);
        }

        // GET: pbhxmlprestlogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: pbhxmlprestlogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,empresa,cnpj,mes_de_vigencia,sucesso,descricao,quantidade_de_nfs_baixadas,quantidade_de_nfs_processadas,tempo_execucao")] pbhxmlprestlog pbhxmlprestlog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pbhxmlprestlog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pbhxmlprestlog);
        }

        // GET: pbhxmlprestlogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pbhxmlprestlog = await _context.pbhxmlprestlog.FindAsync(id);
            if (pbhxmlprestlog == null)
            {
                return NotFound();
            }
            return View(pbhxmlprestlog);
        }

        // POST: pbhxmlprestlogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,empresa,cnpj,mes_de_vigencia,sucesso,descricao,quantidade_de_nfs_baixadas,quantidade_de_nfs_processadas,tempo_execucao")] pbhxmlprestlog pbhxmlprestlog)
        {
            if (id != pbhxmlprestlog.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pbhxmlprestlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!pbhxmlprestlogExists(pbhxmlprestlog.id))
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
            return View(pbhxmlprestlog);
        }

        // GET: pbhxmlprestlogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pbhxmlprestlog = await _context.pbhxmlprestlog
                .FirstOrDefaultAsync(m => m.id == id);
            if (pbhxmlprestlog == null)
            {
                return NotFound();
            }

            return View(pbhxmlprestlog);
        }

        // POST: pbhxmlprestlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pbhxmlprestlog = await _context.pbhxmlprestlog.FindAsync(id);
            _context.pbhxmlprestlog.Remove(pbhxmlprestlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool pbhxmlprestlogExists(int id)
        {
            return _context.pbhxmlprestlog.Any(e => e.id == id);
        }
    }
}
