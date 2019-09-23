using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPurchesingDetails.Models
{
    [Table("Invoice",Schema ="dbo")]
    public class Invoice
    {
        [Key]
        public int Invoice_ID { get; set; }

        [Required]
        public int Customer_ID { get; set; }

        [Required]
        public int Item_ID { get; set; }

        [Required]
        public int Qty { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Total_Amount { get; set; }
    }
}
