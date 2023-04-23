using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh1004.Models 
{
    [Table("Employees")]
        public class Employee
    {
        [Key]
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber {get; set;}
    }
}