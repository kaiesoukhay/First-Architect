using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO.Models
{
    public class Materiel
    {
        [Key]
        public int MaterielId { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public User Users { get; set; }
    }
}
