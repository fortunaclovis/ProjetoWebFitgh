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
    public class AulaController : Controller
    {
        private readonly Contexto _context;

        public AulaController(Contexto context)
        {
            _context = context;
        }

        // GET: Aula
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aula.ToListAsync());
        }

        // GET: Aula/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula
                .SingleOrDefaultAsync(m => m.Id_Aula == id);
            if (aula == null)
            {
                return NotFound();
            }

            return View(aula);
        }

        // GET: Aula/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aula/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Aula,HorarioInicial,HorarioFinal")] Aula aula)
        {
            if (ModelState.IsValid)
            {
                aula.Id_Aula = Guid.NewGuid();
                _context.Add(aula);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aula);
        }

        // GET: Aula/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula.SingleOrDefaultAsync(m => m.Id_Aula == id);
            if (aula == null)
            {
                return NotFound();
            }
            return View(aula);
        }

        // POST: Aula/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Aula,HorarioInicial,HorarioFinal")] Aula aula)
        {
            if (id != aula.Id_Aula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aula);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AulaExists(aula.Id_Aula))
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
            return View(aula);
        }

        // GET: Aula/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aula = await _context.Aula
                .SingleOrDefaultAsync(m => m.Id_Aula == id);
            if (aula == null)
            {
                return NotFound();
            }

            return View(aula);
        }

        // POST: Aula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var aula = await _context.Aula.SingleOrDefaultAsync(m => m.Id_Aula == id);
            _context.Aula.Remove(aula);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AulaExists(Guid id)
        {
            return _context.Aula.Any(e => e.Id_Aula == id);
        }
    }
}
