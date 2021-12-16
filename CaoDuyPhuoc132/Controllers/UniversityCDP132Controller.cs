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
    public class UniversityCDP132Controller : Controller
    {
        private readonly CaoDuyPhuoc132Context _context;

        public UniversityCDP132Controller(CaoDuyPhuoc132Context context)
        {
            _context = context;
        }

        // GET: UniversityCDP132
        public async Task<IActionResult> Index()
        {
            return View(await _context.UniversityCDP132.ToListAsync());
        }

        // GET: UniversityCDP132/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityCDP132 = await _context.UniversityCDP132
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityCDP132 == null)
            {
                return NotFound();
            }

            return View(universityCDP132);
        }

        // GET: UniversityCDP132/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UniversityCDP132/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UniversityId,UniversityName")] UniversityCDP132 universityCDP132)
        {
            if (ModelState.IsValid)
            {
                _context.Add(universityCDP132);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(universityCDP132);
        }

        // GET: UniversityCDP132/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityCDP132 = await _context.UniversityCDP132.FindAsync(id);
            if (universityCDP132 == null)
            {
                return NotFound();
            }
            return View(universityCDP132);
        }

        // POST: UniversityCDP132/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UniversityId,UniversityName")] UniversityCDP132 universityCDP132)
        {
            if (id != universityCDP132.UniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(universityCDP132);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UniversityCDP132Exists(universityCDP132.UniversityId))
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
            return View(universityCDP132);
        }

        // GET: UniversityCDP132/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var universityCDP132 = await _context.UniversityCDP132
                .FirstOrDefaultAsync(m => m.UniversityId == id);
            if (universityCDP132 == null)
            {
                return NotFound();
            }

            return View(universityCDP132);
        }

        // POST: UniversityCDP132/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var universityCDP132 = await _context.UniversityCDP132.FindAsync(id);
            _context.UniversityCDP132.Remove(universityCDP132);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UniversityCDP132Exists(int id)
        {
            return _context.UniversityCDP132.Any(e => e.UniversityId == id);
        }
    }
}
