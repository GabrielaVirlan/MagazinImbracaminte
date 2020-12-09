using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinImbracaminte.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductDetailsId { get; set; }
        public Product Product { get; set; }
        [MaxLength(10)]
        public string Size { set; get; }
        [MaxLength(50)]
        public string Material { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
