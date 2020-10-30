﻿using System.ComponentModel.DataAnnotations;

namespace ShopCet47.Web.Data.Entities
{
    public class OrderDetail : IEntity
    {

        public int Id { get; set; }
        [Required]
        public Product Product { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public double Quantity { get; set; }

        public decimal Value { get { return this.Price * (decimal)this.Quantity; } }



    }
}