using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace baithuchanh1704.Models;

    [Table("Adđress")]
    public class Address
    {
        [Key]
        public string AddressID { get; set; }
        public string AddressNane { get; set; }
    }
