using Microsoft.VisualStudio.TestTools.UnitTesting;
using FeedForward3.Logic;
using FeedForward3.Models;

namespace FeedForward3_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalPrice10()
        {
            //Arrange
            PriceLogic priceLogic = new PriceLogic();
            double answer = 12.1;

            //Act
            double realPrice = priceLogic.CheckPrice(10).TotalPrice;

            //Assert
            Assert.AreEqual(answer, realPrice);
        }

        [TestMethod]
        public void PriceModel10()
        {
            //Arrange
            PriceLogic priceLogic = new PriceLogic();
            PriceModel answer = new PriceModel(10, 2.1, 12.1);

            //Act
            PriceModel priceModel = priceLogic.CheckPrice(10);

            //Assert
            Assert.AreEqual(answer.Price, priceModel.Price);
            Assert.AreEqual(answer.Tax, priceModel.Tax);
            Assert.AreEqual(answer.TotalPrice, priceModel.TotalPrice);
        }
    }
}
