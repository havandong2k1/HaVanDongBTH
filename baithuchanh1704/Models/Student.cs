using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace baithuchanh1704.Models
{   
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string SexID {get; set;}
        [ForeignKey ("SexID")]
        public Sex? Sex {get; set;}
        public string AddressID {get; set;}
        [ForeignKey ("AddressID")]
        public Address? Address {get; set;}
        public string FacultyID {get; set;}
        [ForeignKey ("FacultyID")] 

        public Faculty? Faculty {get; set;}
    }
}

