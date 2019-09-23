using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPurchesingDetails.Models
{
    [Table("Customer_Details", Schema = "dbo")]
    public class Customers
    {
        [Required]
        public string Customer_Name { get; set; }

        [Key]
        public int Customer_ID { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Mobile { get; set; }

        [Required]
        public int AllowDiscounts { get; set; }

        [Required]
        public int TotalCredits { get; set; }

    }

}
