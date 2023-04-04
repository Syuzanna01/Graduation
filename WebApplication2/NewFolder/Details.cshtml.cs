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
    public class DetailsModel : PageModel
    {
        private readonly Graduation.DAL.GraduationDBContext _context;

        public DetailsModel(Graduation.DAL.GraduationDBContext context)
        {
            _context = context;
        }

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
    }
}
