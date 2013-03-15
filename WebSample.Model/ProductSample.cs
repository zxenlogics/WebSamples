using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSample.Model
{
    public class ProductSample
    {
        public enum ProductType
        {
            UnKnown,
            ControlledSubstance,
            NonControlledSubstance,
            SavingCards
        }

        [Key]
        public string ProductID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFormulation { get; set; }
        public string AvailableQuantity { get; set; }
        public string AllocatedQuantity { get; set; }
        public string NextAvailOrderDate { get; set; }
        public bool Order { get; set; }
        public bool OrderEnabled { get; set; }
        public string Strength { get; set; }
        public string NDC { get; set; }
        public string Configuration { get; set; }
        public string ResourceFormulation { get; set; }
        public string PrescribingInfoUrl { get; set; }
        public string PrescribingInfoDescription { get; set; }
        public string Img { get; set; }
        public string NDCStatus { get; set; }
        public string ReOrderQuantity { get; set; }
        public ProductType ProductSampleType { get; set; }
        public bool IsInShoppingCart { get; set; }
    }
}
