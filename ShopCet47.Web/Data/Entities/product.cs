using System;
using System.ComponentModel.DataAnnotations;

namespace ShopCet47.Web.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage = "The field{0} only can contain a maximum {1} characters")]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }


        [Display(Name = "Image")]
        public string ImageUrl { get; set; }


        [Display(Name = "Last Purcharse")]
        public DateTime? LastPurchase { get; set; }


        [Display(Name = "LastSale")]
        public DateTime? LastSale { get; set; }


        [Display(Name = "IsAvailable")]
        public bool IsAvailable { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)] 
        public double Stock { get; set; }
    }
}
