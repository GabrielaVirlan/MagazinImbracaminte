using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinImbracaminte.Models
{
    public class Cart
    {
        [Key]
        public string CartId { get; set; }
        public int UserId { get; set}
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual Delivery DeliveryAdress { get; set; }
        public ProductCart ProductCart { get; set; }
    }
}
