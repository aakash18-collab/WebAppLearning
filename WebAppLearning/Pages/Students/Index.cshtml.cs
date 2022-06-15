using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IList<Student> Student { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Abouts { get; set; }
        [BindProperty(SupportsGet = true)]
        public string StudentAbout { get; set; }

        //public async Task OnGetAsync()
        //{
        //    if (_context.Student != null)
        //    {
        //        Student = await _context.Student.ToListAsync();
        //    }
        //}
        public async Task OnGetAsync()
        {
            // Use LINQ to get list of About.
            IQueryable<string> aboutQuery = from m in _context.Student
                                            orderby m.About
                                            select m.About;
           
            var students = from m in _context.Student
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                students = students.Where(s => s.Subject.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(StudentAbout))
            {
                students = students.Where(x => x.About == StudentAbout);
            }
            Abouts = new SelectList(await aboutQuery.Distinct().ToListAsync());

            Student = await students.ToListAsync();
        }
    }
}
