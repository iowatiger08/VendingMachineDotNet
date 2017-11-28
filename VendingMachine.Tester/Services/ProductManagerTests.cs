using System;

using VendingMachine.Services;
using VendingMachine.Models;

using NUnit.Framework;
using Moq;

namespace VendingMachine.Services
{
    public class ProductManagerTests
    {
        private ProductManager productManager;

        [SetUp]
        public void Init()
        {
            productManager = new ProductManager();
        }

        /**
         * as a user I enter not enough coins for purchase get warning result
         */
        [Test]
        public void TestUserEntersNotEnoughCoinsToShowProductsAvailable() { 
            Assert.That(productManager.GetProductsForValue(25).Message(),
                        Is.EqualTo(new NotEnoughToPurchaseResult().Message()));
        }

        /**
         * as a user I enter not enough coins for purchase get warning result
         */
        [Test]
        public void TestUserShowProductsAvailableWithPrices()
        {
            var test = new AvailableResult().AvailableInventory();
            Assert.That(productManager.ShowProductsAvailable(), Is.EqualTo(test));
        }
    }
}
