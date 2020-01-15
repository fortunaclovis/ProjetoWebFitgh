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
    public class CertificadoController : Controller
    {
        private readonly Contexto _context;

        public CertificadoController(Contexto context)
        {
            _context = context;
        }

        // GET: Certificado
        public async Task<IActionResult> Index()
        {
            return View(await _context.Certificado.ToListAsync());
        }

        // GET: Certificado/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificado = await _context.Certificado
                .SingleOrDefaultAsync(m => m.IdCertificado == id);
            if (certificado == null)
            {
                return NotFound();
            }

            return View(certificado);
        }

        // GET: Certificado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certificado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCertificado,Graduacao_Id,CertificadoPDF")] Certificado certificado)
        {
            if (ModelState.IsValid)
            {
                certificado.IdCertificado = Guid.NewGuid();
                _context.Add(certificado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(certificado);
        }

        // GET: Certificado/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificado = await _context.Certificado.SingleOrDefaultAsync(m => m.IdCertificado == id);
            if (certificado == null)
            {
                return NotFound();
            }
            return View(certificado);
        }

        // POST: Certificado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdCertificado,Graduacao_Id,CertificadoPDF")] Certificado certificado)
        {
            if (id != certificado.IdCertificado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(certificado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CertificadoExists(certificado.IdCertificado))
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
            return View(certificado);
        }

        // GET: Certificado/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var certificado = await _context.Certificado
                .SingleOrDefaultAsync(m => m.IdCertificado == id);
            if (certificado == null)
            {
                return NotFound();
            }

            return View(certificado);
        }

        // POST: Certificado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var certificado = await _context.Certificado.SingleOrDefaultAsync(m => m.IdCertificado == id);
            _context.Certificado.Remove(certificado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CertificadoExists(Guid id)
        {
            return _context.Certificado.Any(e => e.IdCertificado == id);
        }
    }
}
