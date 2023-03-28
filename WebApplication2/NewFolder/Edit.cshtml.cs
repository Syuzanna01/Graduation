using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using Graduation.DAL;

namespace WebApplication2.NewFolder
{
    public class EditModel : PageModel
    {
        private readonly Graduation.DAL.GraduationDBContext _context;

        public EditModel(Graduation.DAL.GraduationDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public StudentEntity StudentEntity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }

            var studententity =  await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
            if (studententity == null)
            {
                return NotFound();
            }
            StudentEntity = studententity;
           ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(StudentEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentEntityExists(StudentEntity.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StudentEntityExists(int id)
        {
          return (_context.Students?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
