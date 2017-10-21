using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rest_v5.Models
{
    [Table("Category")]
    public class Category: Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        new public long Id { get; set; } // А сработает?
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual ICollection<Product> Product { get; set; }
    }
}
