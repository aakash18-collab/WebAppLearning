using Microsoft.EntityFrameworkCore;
using WebAppLearning.Data;
namespace WebAppLearning.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppLearningContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAppLearningContext>>()))
            {
                if (context == null || context.Student == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        StudentName = "Aakash Dahal",
                        Subject = "C#",
                     //   AdmissionDate = 1/1/0001,
                        Age = 23,
                        SubjectTeacher = "Anaya Upadhyay",
                        About = "Best Person",
                  
                    }

                  
                );
                context.SaveChanges();
            }
        }
    }
}
