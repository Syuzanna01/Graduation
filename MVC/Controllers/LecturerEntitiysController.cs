using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using Graduation.DAL;

namespace MVC.Controllers
{
    public class LecturerEntitiysController : Controller
    {
        private readonly GraduationDBContext _context;

        public LecturerEntitiysController(GraduationDBContext context)
        {
            _context = context;
        }

        // GET: LecturerEntitiys
        public async Task<IActionResult> Index()
        {
              return _context.Lecturers != null ? 
                          View(await _context.Lecturers.ToListAsync()) :
                          Problem("Entity set 'GraduationDBContext.Lecturers'  is null.");
        }

        // GET: LecturerEntitiys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lecturers == null)
            {
                return NotFound();
            }

            var lecturerEntitiy = await _context.Lecturers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lecturerEntitiy == null)
            {
                return NotFound();
            }

            return View(lecturerEntitiy);
        }

        // GET: LecturerEntitiys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LecturerEntitiys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Surname,Gender,IdentityNumber,Email,Position,IsActive")] LecturerEntitiy lecturerEntitiy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lecturerEntitiy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lecturerEntitiy);
        }

        // GET: LecturerEntitiys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lecturers == null)
            {
                return NotFound();
            }

            var lecturerEntitiy = await _context.Lecturers.FindAsync(id);
            if (lecturerEntitiy == null)
            {
                return NotFound();
            }
            return View(lecturerEntitiy);
        }

        // POST: LecturerEntitiys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Surname,Gender,IdentityNumber,Email,Position,IsActive")] LecturerEntitiy lecturerEntitiy)
        {
            if (id != lecturerEntitiy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lecturerEntitiy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LecturerEntitiyExists(lecturerEntitiy.Id))
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
            return View(lecturerEntitiy);
        }

        // GET: LecturerEntitiys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lecturers == null)
            {
                return NotFound();
            }

            var lecturerEntitiy = await _context.Lecturers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lecturerEntitiy == null)
            {
                return NotFound();
            }

            return View(lecturerEntitiy);
        }

        // POST: LecturerEntitiys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lecturers == null)
            {
                return Problem("Entity set 'GraduationDBContext.Lecturers'  is null.");
            }
            var lecturerEntitiy = await _context.Lecturers.FindAsync(id);
            if (lecturerEntitiy != null)
            {
                _context.Lecturers.Remove(lecturerEntitiy);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LecturerEntitiyExists(int id)
        {
          return (_context.Lecturers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
