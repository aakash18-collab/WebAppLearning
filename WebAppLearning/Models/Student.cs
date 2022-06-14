using System.ComponentModel.DataAnnotations;
namespace WebAppLearning.Models
{
    public class Student
    {   
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; } = string.Empty;

        public string Subject { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime AdmissionDate { get; set; }
        public int Age { get; set; }

        public string About { get; set; } = string.Empty;
        
    }
}

