using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace baithuchanh2003.Models
{   
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FacultyID {get; set;}
        
        public Faculty? Faculty {get; set;}
    }
}