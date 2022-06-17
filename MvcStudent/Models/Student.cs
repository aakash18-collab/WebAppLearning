using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudent.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "Student Name")]
        [StringLength(60, MinimumLength = 5)]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string StudentName { get; set; }

        [Required]
        [StringLength(15)]
        public string Subject { get; set; }

        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }

        [Range(1, 75)]
        [Required]
        public int Age { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Display(Name = "Subject Teacher")]
        public string SubjectTeacher { get; set;  }

        [StringLength(30)]
        public string About { get; set; }
    }
}