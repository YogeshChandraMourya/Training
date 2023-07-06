using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFPractice.Models;

namespace EFPractice.Controllers
{
    public class Table1Controller : Controller
    {
        private readonly NewContext _context;

        public Table1Controller(NewContext context)
        {
            _context = context;
        }

        // GET: Table1
        public async Task<IActionResult> Index()
        {
              return _context.Table1s != null ? 
                          View(await _context.Table1s.ToListAsync()) :
                          Problem("Entity set 'NewContext.Table1s'  is null.");
        }

        // GET: Table1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Table1s == null)
            {
                return NotFound();
            }

            var table1 = await _context.Table1s
                .FirstOrDefaultAsync(m => m.AvengerId == id);
            if (table1 == null)
            {
                return NotFound();
            }

            return View(table1);
        }

        // GET: Table1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Table1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AvengerId,AvengerName")] Table1 table1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(table1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(table1);
        }

        // GET: Table1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Table1s == null)
            {
                return NotFound();
            }

            var table1 = await _context.Table1s.FindAsync(id);
            if (table1 == null)
            {
                return NotFound();
            }
            return View(table1);
        }

        // POST: Table1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AvengerId,AvengerName")] Table1 table1)
        {
            if (id != table1.AvengerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Table1Exists(table1.AvengerId))
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
            return View(table1);
        }

        // GET: Table1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Table1s == null)
            {
                return NotFound();
            }

            var table1 = await _context.Table1s
                .FirstOrDefaultAsync(m => m.AvengerId == id);
            if (table1 == null)
            {
                return NotFound();
            }

            return View(table1);
        }

        // POST: Table1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Table1s == null)
            {
                return Problem("Entity set 'NewContext.Table1s'  is null.");
            }
            var table1 = await _context.Table1s.FindAsync(id);
            if (table1 != null)
            {
                _context.Table1s.Remove(table1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Table1Exists(int id)
        {
          return (_context.Table1s?.Any(e => e.AvengerId == id)).GetValueOrDefault();
        }
    }
}
