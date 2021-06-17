using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace FeedForward3.Models
{
    public class PriceModel
    {
        public int Price { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }


        public PriceModel(int price, double tax, double totalPrice)
        {
            Price = price;
            Tax = tax;
            TotalPrice = totalPrice;
        }
    }
}
