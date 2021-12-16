using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CaoDuyPhuoc132.Data;
using CaoDuyPhuoc132.Models;

namespace CaoDuyPhuoc132.Controllers
{
    public class CDP0132Controller : Controller
    {
        private readonly CaoDuyPhuoc132Context _context;

        public CDP0132Controller(CaoDuyPhuoc132Context context)
        {
            _context = context;
        }

        // GET: CDP0132
        public async Task<IActionResult> Index()
        {
            return View(await _context.CDP0132.ToListAsync());
        }

        // GET: CDP0132/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cDP0132 = await _context.CDP0132
                .FirstOrDefaultAsync(m => m.CDPId == id);
            if (cDP0132 == null)
            {
                return NotFound();
            }

            return View(cDP0132);
        }

        // GET: CDP0132/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CDP0132/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CDPId,CDPName,CDPGender")] CDP0132 cDP0132)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cDP0132);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cDP0132);
        }

        // GET: CDP0132/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cDP0132 = await _context.CDP0132.FindAsync(id);
            if (cDP0132 == null)
            {
                return NotFound();
            }
            return View(cDP0132);
        }

        // POST: CDP0132/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CDPId,CDPName,CDPGender")] CDP0132 cDP0132)
        {
            if (id != cDP0132.CDPId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cDP0132);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CDP0132Exists(cDP0132.CDPId))
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
            return View(cDP0132);
        }

        // GET: CDP0132/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cDP0132 = await _context.CDP0132
                .FirstOrDefaultAsync(m => m.CDPId == id);
            if (cDP0132 == null)
            {
                return NotFound();
            }

            return View(cDP0132);
        }

        // POST: CDP0132/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var cDP0132 = await _context.CDP0132.FindAsync(id);
            _context.CDP0132.Remove(cDP0132);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CDP0132Exists(string id)
        {
            return _context.CDP0132.Any(e => e.CDPId == id);
        }
    }
}
