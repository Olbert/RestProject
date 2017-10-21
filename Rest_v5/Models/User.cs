using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_v5.Models
{
    [Table("User")]
    public partial class User : Model
    {
        public User()
        {
            Order = new HashSet<Order>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public long Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Order> Order { get; set; }
       
    }
}
 