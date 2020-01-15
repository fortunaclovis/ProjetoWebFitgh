using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebFight.Data;
using WebFight.Models;

namespace WebFight.Controllers
{
    public class GraduacaosController : Controller
    {
        private readonly Contexto _context;

        public GraduacaosController(Contexto context)
        {
            _context = context;
        }

        // GET: Graduacaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Graduacao.ToListAsync());
        }

        // GET: Graduacaos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduacao = await _context.Graduacao
                .SingleOrDefaultAsync(m => m.Id_Graduacao == id);
            if (graduacao == null)
            {
                return NotFound();
            }

            return View(graduacao);
        }

        // GET: Graduacaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Graduacaos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Graduacao,Categoria_Id,DataGraduacao,Professor_Id")] Graduacao graduacao)
        {
            if (ModelState.IsValid)
            {
                graduacao.Id_Graduacao = Guid.NewGuid();
                _context.Add(graduacao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(graduacao);
        }

        // GET: Graduacaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduacao = await _context.Graduacao.SingleOrDefaultAsync(m => m.Id_Graduacao == id);
            if (graduacao == null)
            {
                return NotFound();
            }
            return View(graduacao);
        }

        // POST: Graduacaos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Graduacao,Categoria_Id,DataGraduacao,Professor_Id")] Graduacao graduacao)
        {
            if (id != graduacao.Id_Graduacao)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(graduacao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GraduacaoExists(graduacao.Id_Graduacao))
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
            return View(graduacao);
        }

        // GET: Graduacaos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var graduacao = await _context.Graduacao
                .SingleOrDefaultAsync(m => m.Id_Graduacao == id);
            if (graduacao == null)
            {
                return NotFound();
            }

            return View(graduacao);
        }

        // POST: Graduacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var graduacao = await _context.Graduacao.SingleOrDefaultAsync(m => m.Id_Graduacao == id);
            _context.Graduacao.Remove(graduacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GraduacaoExists(Guid id)
        {
            return _context.Graduacao.Any(e => e.Id_Graduacao == id);
        }
    }
}
