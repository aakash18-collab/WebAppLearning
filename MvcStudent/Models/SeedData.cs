using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcStudent.Data;
using System;
using System.Linq;

namespace MvcStudent.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentContext>>()))
            {

                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }
                context.Student.AddRange(
                    new Student
                    {
                        StudentName = "Bill Gates",
                        Subject = "C#",
                        AdmissionDate = DateTime.Parse("2010-02-23"),
                        Age = 66,
                        SubjectTeacher = "Self",
                        About = "Billionaire man , founder of Microsoft"
                    },

                    new Student
                    {
                        StudentName = "Mark Zuckerberg",
                        Subject = "JS",
                        AdmissionDate = DateTime.Parse("2012-12-03"),
                        Age = 38,
                        SubjectTeacher = " Internet",
                        About = "Billionaire man , founder of Facebook"
                    }
                ); ;
                context.SaveChanges();
                
            }
        }
    }
}