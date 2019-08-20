﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheStore.Models {


    public class Product {

        [Key]
        public int Id { get; set; } 

        [MaxLength(30)]
        [Required]
        public string PartNbr { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(30)]
        [Required]
        public string Unit { get; set; }

        [MaxLength(255)]
        public string PhotoPath { get; set; }

        [Required]
        public int VendorId { get; set; }
    }
}
