
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace VendingMachine.Controllers
{
    public class VendorControllerTests
    {


        private VendingController vendingController;

        private Mock<CoinManager> coinManager;

        private Mock<ProductManager> productManager;

        [SetUp]
        public void Init()
        {

            coinManager = new Mock<CoinManager>();
            productManager = new Mock<ProductManager>();//mock(ProductManager.class);
        }
        /**
         * as a user I enter coins and coin manger shows value
         */
        [Test]
        public void TestUserEntersCoinsSeesValueReturnedwithEject()
        {
            var BagOfCoins = new List<ICoin>();
            BagOfCoins.Add(new Quarter());
            var result = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = BagOfCoins,
            });
            Assert.That(result.tenderValue, Is.EqualTo(25));

        }

        [Test]
        public void TestEjectRequestReturnsCoinsEntered()
        {
            var BagOfCoins = new List<ICoin>();
            BagOfCoins.Add(new Quarter());
            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = BagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = true,
            }));
            Assert.That(result.tenderValue, Is.EqualTo(25));
        }

        /**
         * as a user I enter coins for Chips and  select
         */
        [Test]
        public void testUserEntersEnoughForChips()
        {

        }
        /**
         * as a user I enter coins for candy
         */
        [Test]
        public void TestUserEntersEnoughForCandy()
        {

        }
        /**
         * as a user I enter coins for drink
         */
        [Test]
        public void TestUserEntersEnoughForDrink()
        {

        }
        /**
         * as a user I enter coins , select product but have remainder
         */
        [Test]
        public void TestUserSelectsChipsHasRemainder()
        {

        }
        /**
         * as a user I enter coins , select product but have remainder
         */
        [Test]
        public void TestUserSelectsCandyHasRemainder()
        {

        }
        /**
         * as a user I enter coins , select product but have remainder
         */
        [Test]
        public void TestUserSelectsDrinkHasRemainder()
        {

        }

    }
}
