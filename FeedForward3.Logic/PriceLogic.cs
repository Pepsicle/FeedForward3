using System;
using System.Collections.Generic;
using System.Text;
using FeedForward3.Models;

namespace FeedForward3.Logic
{
    public class PriceLogic
    {
        public PriceModel CheckPrice(int price)
        {
            double taxPercentage = 0.21;
            double taxCost = price * taxPercentage;
            double totalPrice = price + taxCost;
            PriceModel priceModel = new PriceModel(price, taxCost, totalPrice);
            return priceModel;
        }
    }
}
