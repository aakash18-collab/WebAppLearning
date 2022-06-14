using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAppLearning.Data;
using WebAppLearning.Models;

namespace WebAppLearning.Pages.Students
{
    public class IndexModel : PageModel
    {
        //dependency injection
        private readonly WebAppLearning.Data.WebAppLearningContext _context;

        public IndexModel(WebAppLearning.Data.WebAppLearningContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
