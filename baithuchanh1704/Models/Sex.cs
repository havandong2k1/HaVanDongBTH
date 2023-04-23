using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh1704.Models;

    [Table("Sex")]
    public class Sex
    {
        [Key]
        public string SexID { get; set; }
        public string SexName { get; set; }
    }
