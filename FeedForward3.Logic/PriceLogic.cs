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
        public PriceModel CheckDiscountPrice(int price, string coupon)
        {
            int discount = 0;
            switch (coupon)
            {
                case "Start5":
                    discount = 5;
                    break;
                case "Start10":
                    discount = 10;
                    break;
            }
            double taxPercentage = 0.21;
            double taxCost = price * taxPercentage;
            double totalPrice = price + taxCost - discount;
            PriceModel priceModel = new PriceModel(price, taxCost, totalPrice);
            return priceModel;
        }
    }
}
