using System;
using VendingMachine.DataTransfers;
using VendingMachine.Services;
using VendingMachine;

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
            vendingController = new VendingController();
            coinManager = new Mock<CoinManager>();
            productManager = new Mock<ProductManager>();//mock(ProductManager.class);
        }

        /**
         * as a user I see insert coins
         */
        [Test]
        public void TestUserSeesInsertCoin()
        {
            var aBagOfCoins = new List<ICoin>();

            var result = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            Assert.That(result.Message, Is.EqualTo(ModelValues.INSERT_COIN));

        }
        /**
         * as a user I enter coins and coin manger shows value
         */
        [Test]
        public void TestUserEntersCoinsSeesValueReturnedwithEject()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            var result = vendingController.Post(new VendingRequest()
            {              
                BagOfCoins = aBagOfCoins,
            });
            Assert.That(result.TenderValue, Is.EqualTo(25));

        }

        [Test]
        public void TestEjectRequestReturnsCoinsEntered()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = true,
            });
            Assert.That(result.TenderValue, Is.EqualTo(0));
        }

        /**
         * as a user I enter coins for Chips and  select
         */
        [Test]
        public void TestUserEntersEnoughForChipsTenderisZero()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Chips>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 2);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Chips().Type(),
            });
            Assert.That(result.TenderValue, Is.EqualTo(0));
        }

        /**
         * as a customer I select chips when not available shows sold out
         */
        [Test]
        public void TestUserChipsSoldOut()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            productManager.Setup( m => m.GetProductCount(It.IsAny<Chips>())).Returns(0);
            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Chips().Type(),
            });
            Assert.That(result.Message, Is.EqualTo(ModelValues.SOLD_OUT));
        }
        /**
         * as a customer I select chips when not available shows sold out
         */
        [Test]
        public void TestUserCandySoldOut()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Dime());
            aBagOfCoins.Add(new Nickel());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Candy>())).Returns(0);
            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Candy().Type(),
            });
            Assert.That(result.Message, Is.EqualTo(ModelValues.SOLD_OUT));
        }
        /**
         * as a customer I select cola when not available shows sold out
         */
        [Test]
        public void TestUserColaSoldOut()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Cola>())).Returns(0);
            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Cola().Type(),
            });
            Assert.That(result.Message, Is.EqualTo(ModelValues.SOLD_OUT));
        }
        /**
         * as a user I enter coins for Chips and is delivered
         */
        [Test]
        public void TestUserEntersEnoughForChips()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Chips>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 2);
            coinBank.Add(new Dime(), 2);
            coinBank.Add(new Nickel(), 1);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Chips().Type(),
            });
            Assert.That(result.Delivery.Type(), Is.EqualTo(new Chips().Type()));
        }
        /**
         * as a user I enter coins for candy and is delivered
         */
        [Test]
        public void TestUserEntersEnoughForCandy()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Dime());
            aBagOfCoins.Add(new Dime());
            aBagOfCoins.Add(new Nickel());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Candy>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 2);
            coinBank.Add(new Dime(), 2);
            coinBank.Add(new Nickel(), 1);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Candy().Type(),
            });
            Assert.That(result.Delivery.Type(), Is.EqualTo(new Candy().Type()));
        }
        /**
         * as a user I enter coins for drink
         */
        [Test]
        public void TestUserEntersEnoughForDrink()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Cola>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 4);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Cola().Type(),
            });
            Assert.That(result.Delivery.Type(), Is.EqualTo(new Cola().Type()));

        }
        /**
         * as a user I enter coins , select chips tender a nickel back
         */
        [Test]
        public void TestUserSelectsChipsHasChange()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Nickel());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Chips>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 2);
            coinBank.Add(new Nickel(), 1);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Chips().Type(),
            });
            Assert.That(result.TenderValue, Is.EqualTo(new Nickel().Value()));
        }
        /**
         * as a user I enter coins , select candy tender dime back
         */
        [Test]
        public void TestUserSelectsCandyHasChange()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Dime());
            aBagOfCoins.Add(new Dime());
            aBagOfCoins.Add(new Nickel());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Candy>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 2); 
            coinBank.Add(new Dime(), 2);
            coinBank.Add(new Nickel(),1);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Candy().Type(),
            });
            Assert.That(result.TenderValue, Is.EqualTo(new Dime().Value()));
        }
        /**
         * as a user I enter coins , select Cola tender quarter back
         */
        [Test]
        public void TestUserSelectsDrinkHasChange()
        {
            var aBagOfCoins = new List<ICoin>();
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            aBagOfCoins.Add(new Quarter());
            productManager.Setup(m => m.GetProductCount(It.IsAny<Cola>())).Returns(1);

            Dictionary<ICoin, int> coinBank = new Dictionary<ICoin, int>();
            coinBank.Add(new Quarter(), 5);
            coinManager.Setup(m => m.GetBankOfCoins()).Returns(coinBank);

            var deposited = vendingController.Post(new VendingRequest()
            {
                BagOfCoins = aBagOfCoins,
            });
            var result = vendingController.Post(new VendingRequest()
            {
                Empty = false,
                Selection = new Cola().Type(),
            });
            Assert.That(result.TenderValue, Is.EqualTo(new Quarter().Value()));
        }

    }
}
