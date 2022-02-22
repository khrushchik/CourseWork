using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCoursework.Models;

namespace MyCoursework.Controllers
{
    public class JoinersController : Controller
    {
        private readonly CourseworkDBContext _context;

        public JoinersController(CourseworkDBContext context)
        {
            _context = context;
        }

        // GET: Joiners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Joiners.ToListAsync());
        }

        // GET: Joiners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joiner = await _context.Joiners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joiner == null)
            {
                return NotFound();
            }

            return View(joiner);
        }

        // GET: Joiners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Joiners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Body,Volume,FuelType,Transmission,PersonName,Phone")] Joiner joiner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(joiner);
                await _context.SaveChangesAsync();
                ViewBag.SuccessMessage = "Заява успішно надіслана!";
                ModelState.Clear();
                return View();
                //return RedirectToAction(nameof(Create));
            }
            return View(joiner);
        }

        // GET: Joiners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joiner = await _context.Joiners.FindAsync(id);
            if (joiner == null)
            {
                return NotFound();
            }
            return View(joiner);
        }

        // POST: Joiners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Body,Volume,FuelType,Transmission,PersonName,Phone")] Joiner joiner)
        {
            if (id != joiner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(joiner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JoinerExists(joiner.Id))
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
            return View(joiner);
        }

        // GET: Joiners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var joiner = await _context.Joiners
                .FirstOrDefaultAsync(m => m.Id == id);
            if (joiner == null)
            {
                return NotFound();
            }

            return View(joiner);
        }

        // POST: Joiners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var joiner = await _context.Joiners.FindAsync(id);
            _context.Joiners.Remove(joiner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JoinerExists(int id)
        {
            return _context.Joiners.Any(e => e.Id == id);
        }
    }
}
