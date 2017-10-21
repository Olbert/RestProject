using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;
namespace Rest_v5.Models
{
    [Table("General_product")]
    public partial class Product : Model
    {
        public Product()
        {
            Order = new HashSet<Order>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public long Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Category_id")]  
        public long CategoryId { get; set; }
        [Required]
        public long Amount { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public float? Rating { get; set; }
        
        public virtual Category Category { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        JObject Parametres { get; set; }
    }

    public partial class AC_Product : Product
    {
        public AC_Product()
        {
            Order = new HashSet<Order>();
        }
        public string Model { get; set; }

        public string Brand { get; set; }
        // Something Else

    }
}
