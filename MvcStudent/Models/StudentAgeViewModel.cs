using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
namespace MvcStudent.Models
{
    public class StudentAgeViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Abouts { get; set; }
        public string StudentAbout { get; set; }
        public string SearchString { get; set; }
    }
}

