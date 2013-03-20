﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Model
{
    public class Product
    {
        public enum ProductType
        {
            Sample,
            OTC,
            Regulated,
        }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public string Img { get; set; }
        public ProductType Type { get; set; }

    }
}
