using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using Graduation.DAL;

namespace WebApplication2.NewFolder
{
    public class DeleteModel : PageModel
    {
        private readonly Graduation.DAL.GraduationDBContext _context;

        public DeleteModel(Graduation.DAL.GraduationDBContext context)
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

            var studententity = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

            if (studententity == null)
            {
                return NotFound();
            }
            else 
            {
                StudentEntity = studententity;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Students == null)
            {
                return NotFound();
            }
            var studententity = await _context.Students.FindAsync(id);

            if (studententity != null)
            {
                StudentEntity = studententity;
                _context.Students.Remove(StudentEntity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
