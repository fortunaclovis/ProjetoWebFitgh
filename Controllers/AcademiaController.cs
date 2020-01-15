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
    public class AcademiaController : Controller
    {
        private readonly Contexto _context;

        public AcademiaController(Contexto context)
        {
            _context = context;
        }

        // GET: Academia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Academia.ToListAsync());
        }

        // GET: Academia/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academia = await _context.Academia
                .SingleOrDefaultAsync(m => m.Id_Academia == id);
            if (academia == null)
            {
                return NotFound();
            }

            return View(academia);
        }

        // GET: Academia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Academia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Academia,Nome,DataInicio,HorarioFunciona,Aula_Id,Contato_Id")] Academia academia)
        {
            if (ModelState.IsValid)
            {
                academia.Id_Academia = Guid.NewGuid();
                _context.Add(academia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(academia);
        }

        // GET: Academia/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academia = await _context.Academia.SingleOrDefaultAsync(m => m.Id_Academia == id);
            if (academia == null)
            {
                return NotFound();
            }
            return View(academia);
        }

        // POST: Academia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id_Academia,Nome,DataInicio,HorarioFunciona,Aula_Id,Contato_Id")] Academia academia)
        {
            if (id != academia.Id_Academia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(academia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcademiaExists(academia.Id_Academia))
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
            return View(academia);
        }

        // GET: Academia/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var academia = await _context.Academia
                .SingleOrDefaultAsync(m => m.Id_Academia == id);
            if (academia == null)
            {
                return NotFound();
            }

            return View(academia);
        }

        // POST: Academia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var academia = await _context.Academia.SingleOrDefaultAsync(m => m.Id_Academia == id);
            _context.Academia.Remove(academia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcademiaExists(Guid id)
        {
            return _context.Academia.Any(e => e.Id_Academia == id);
        }
    }
}
