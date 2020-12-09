using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinImbracaminte.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryId {get; set;}
        public User User { set; get; }
        [MaxLength(30)]
        public string Country { get; set; }
        [MaxLength(30)]
        public string City { get; set; }
        [MaxLength(30)]
        public string Street { get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="Numarul introdus nu este valid!")]
        public int Number { get; set; }
        public virtual Cart Cart { get; set; }

    }
}
