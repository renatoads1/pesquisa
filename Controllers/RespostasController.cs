using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pesquisa.Data;
using pesquisa.Models;
using pesquisa.Models.ViewModels;
using pesquisa.Services;

namespace pesquisa.Controllers
{
    public class RespostasController : Controller
    {
        private readonly pesquisaContext _context;

        private readonly PerguntaServices _perguntaService;

        public RespostasController(pesquisaContext context, PerguntaServices perguntaServices)
        {
            _context = context;
            _perguntaService = perguntaServices;
        }

        // GET: Respostas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resposta.Include(obj => obj.Pergunta).ToListAsync());
        }

        // GET: Respostas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resposta = await _context.Resposta
                .FirstOrDefaultAsync(m => m.Id == id);
            if (resposta == null)
            {
                return NotFound();
            }

            return View(resposta);
        }

        // GET: Respostas/Create
        public IActionResult Create()
        {
            var perg = _perguntaService.FindAll();
            var vm = new RespostaFormViewModel { Perguntas = perg };
            return View(vm);
        }

        // POST: Respostas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RespostaSimpl,RespostaCompleta,PerguntaId")] Resposta Resposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Resposta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Resposta);
        }

        // GET: Respostas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resposta = await _context.Resposta.FindAsync(id);
            if (resposta == null)
            {
                return NotFound();
            }
            return View(resposta);
        }

        // POST: Respostas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RespostaSimpl,RespostaCompleta")] Resposta resposta)
        {
            if (id != resposta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(resposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RespostaExists(resposta.Id))
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
            return View(resposta);
        }

        // GET: Respostas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resposta = await _context.Resposta.FirstOrDefaultAsync(m => m.Id == id);
            if (resposta == null)
            {
                return NotFound();
            }

            return View(resposta);
        }

        // POST: Respostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resposta = await _context.Resposta.FindAsync(id);
            _context.Resposta.Remove(resposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RespostaExists(int id)
        {
            return _context.Resposta.Any(e => e.Id == id);
        }

    }
}
