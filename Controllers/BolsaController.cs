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
    public class BolsaController : Controller
    {
        private readonly Contexto _context;

        public BolsaController(Contexto context)
        {
            _context = context;
        }

        // GET: Bolsa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bolsa.ToListAsync());
        }

        // GET: Bolsa/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolsa = await _context.Bolsa
                .SingleOrDefaultAsync(m => m.Id_Bolsa == id);
            if (bolsa == null)
            {
                return NotFound();
            }

            return View(bolsa);
        }

        // GET: Bolsa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bolsa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Bolsa,Percentual,OwnerID,DataInicio,Periodo,Status")] Bolsa bolsa)
        {
            if (ModelState.IsValid)
            {
                bolsa.Id_Bolsa = Guid.NewGuid();
                _context.Add(bolsa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bolsa);
        }

        // GET: Bolsa/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolsa = await _context.Bolsa.SingleOrDefaultAsync(m => m.Id_Bolsa == id);
            if (bolsa == null)
            {
                return NotFound();
            }
            return View(bolsa);
        }

        // POST: Bolsa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Bolsa,Percentual,OwnerID,DataInicio,Periodo,Status")] Bolsa bolsa)
        {
            if (id != bolsa.Id_Bolsa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bolsa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BolsaExists(bolsa.Id_Bolsa))
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
            return View(bolsa);
        }

        // GET: Bolsa/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolsa = await _context.Bolsa
                .SingleOrDefaultAsync(m => m.Id_Bolsa == id);
            if (bolsa == null)
            {
                return NotFound();
            }

            return View(bolsa);
        }

        // POST: Bolsa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var bolsa = await _context.Bolsa.SingleOrDefaultAsync(m => m.Id_Bolsa == id);
            _context.Bolsa.Remove(bolsa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BolsaExists(Guid id)
        {
            return _context.Bolsa.Any(e => e.Id_Bolsa == id);
        }
    }
}
