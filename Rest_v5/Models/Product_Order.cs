using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rest_v5.Models
{
    [Table("Product_order")]
    public class Product_Order : Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public long Id { get; set; }
        [ForeignKey("Order_id")]
        public long? OrderId { get; set; }
        [ForeignKey("Product_id")]
        public long? ProductId { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
