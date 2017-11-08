using System;

using NUnit.Framework;
using Moq;

namespace VendingMachine.Managers
{
    public class ProductManagerTests
    {
        private ProductManager productManager;

        [SetUp]
        public void Init()
        {
            
        }

        /**
         * as a user I enter not enough coins for purchase get warning result
         */
        [Test]
        public void TestUserEntersNotEnoughCoinsToShowProductsAvailable()
        {

            Assert.That(productManager.GetProductsForValue(25).get(0), Is.EqualTo(NotEnoughToPurchaseResult));
        }


    }
}
