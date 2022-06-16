using System.ComponentModel.DataAnnotations;
namespace MvcStudent.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string Subject { get; set; }

        public DateTime AdmissionDate { get; set; }

        public int Age { get; set; }

        public string About { get; set; }
    }
}
