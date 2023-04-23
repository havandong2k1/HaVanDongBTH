using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh1704.Models;

    [Table("Faculty")]
    public class Faculty
    {
        [Key]
        public string FacultyID { get; set; }
        public string FullName { get; set; }
    }
