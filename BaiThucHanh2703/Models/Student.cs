using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh2703.Models 
{
    [Table("Students")]
    public class Student
    {
        [Key]
       public string StudentCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
       
    }
}