using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_v5.Models
{
    [Table("Order")]
    public partial class Order : Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public long Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [ForeignKey("user_id")]
        public long? UserId { get; set; }
        public string Comment { get; set; }

        public virtual User User { get; set; }
    }
}
