using System.ComponentModel.DataAnnotations;
namespace WebAppLearning.Models
{
    public class Student
    {   
        [Key]
        public int StudentID { get; set; }
        [Display(Name = "Student Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string StudentName { get; set; } = string.Empty;
       
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string Subject { get; set; } = string.Empty;

        [DataType(DataType.Date)]
       
        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }

        [Range(1, 90)]
        public int Age { get; set; }

        [Display(Name = "Subject Teacher")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SubjectTeacher { get; set; }
        [StringLength(50)]
        public string About { get; set; } = string.Empty;
        
    }
}

