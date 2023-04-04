using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Entities;
using Graduation.DAL;

namespace WebApplication2.NewFolder
{
    public class CreateModel : PageModel
    {
        private readonly Graduation.DAL.GraduationDBContext _context;

        public CreateModel(Graduation.DAL.GraduationDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public StudentEntity StudentEntity { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Students == null || StudentEntity == null)
            {
                return Page();
            }

            _context.Students.Add(StudentEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
