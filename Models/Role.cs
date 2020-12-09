using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MagazinImbracaminte.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public UserRole UserRole { get; set; }
    }
}
