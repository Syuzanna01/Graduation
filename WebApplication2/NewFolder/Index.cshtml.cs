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
    public class IndexModel : PageModel
    {
        private readonly Graduation.DAL.GraduationDBContext _context;

        public IndexModel(Graduation.DAL.GraduationDBContext context)
        {
            _context = context;
        }

        public IList<StudentEntity> StudentEntity { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Students != null)
            {
                StudentEntity = await _context.Students
                .Include(s => s.Group).ToListAsync();
            }
        }
    }
}
