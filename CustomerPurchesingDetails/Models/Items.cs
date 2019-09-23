using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPurchesingDetails.Models
{
    [Table("ItemNew", Schema = "dbo")]
    public class Items
    {

        [Required]
        public string ItemName { get; set; }

        [Key]
        public int Item_ID { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        public int price { get; set; }
    }

}
