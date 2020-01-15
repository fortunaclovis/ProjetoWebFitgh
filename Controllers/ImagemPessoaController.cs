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
    public class ImagemPessoaController : Controller
    {
        private readonly Contexto _context;

        public ImagemPessoaController(Contexto context)
        {
            _context = context;
        }

        // GET: ImagemPessoa
        public async Task<IActionResult> Index()
        {
            return View(await _context.ImagemPessoa.ToListAsync());
        }

        // GET: ImagemPessoa/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagemPessoa = await _context.ImagemPessoa
                .SingleOrDefaultAsync(m => m.IdImagemPessoa == id);
            if (imagemPessoa == null)
            {
                return NotFound();
            }

            return View(imagemPessoa);
        }

        // GET: ImagemPessoa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ImagemPessoa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdImagemPessoa,Pessoa_Id,Imagem")] ImagemPessoa imagemPessoa)
        {
            if (ModelState.IsValid)
            {
                imagemPessoa.IdImagemPessoa = Guid.NewGuid();
                _context.Add(imagemPessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(imagemPessoa);
        }

        // GET: ImagemPessoa/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagemPessoa = await _context.ImagemPessoa.SingleOrDefaultAsync(m => m.IdImagemPessoa == id);
            if (imagemPessoa == null)
            {
                return NotFound();
            }
            return View(imagemPessoa);
        }

        // POST: ImagemPessoa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("IdImagemPessoa,Pessoa_Id,Imagem")] ImagemPessoa imagemPessoa)
        {
            if (id != imagemPessoa.IdImagemPessoa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(imagemPessoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImagemPessoaExists(imagemPessoa.IdImagemPessoa))
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
            return View(imagemPessoa);
        }

        // GET: ImagemPessoa/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var imagemPessoa = await _context.ImagemPessoa
                .SingleOrDefaultAsync(m => m.IdImagemPessoa == id);
            if (imagemPessoa == null)
            {
                return NotFound();
            }

            return View(imagemPessoa);
        }

        // POST: ImagemPessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var imagemPessoa = await _context.ImagemPessoa.SingleOrDefaultAsync(m => m.IdImagemPessoa == id);
            _context.ImagemPessoa.Remove(imagemPessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImagemPessoaExists(Guid id)
        {
            return _context.ImagemPessoa.Any(e => e.IdImagemPessoa == id);
        }
    }
}
