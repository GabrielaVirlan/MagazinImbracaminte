using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinImbracaminte.Models
{
    public class ProductCart
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }

        public ICollection<Cart> Carts { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
