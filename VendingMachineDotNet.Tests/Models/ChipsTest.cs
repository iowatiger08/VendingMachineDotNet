using System;
using NUnit.Framework;

namespace VendingMachineDotNet
{
	public class ChipsTest
	{
		private Chips chips;

		[SetUp]
		public void setUp()
		{
            chips = new Chips();
		}

		[Test]
		public void TestCandyPrice()
		{
			Assert.That (chips.price(), Is.EqualTo(ModelValues.CHIPS_PRICE));
		}

		[Test]
		public void TestCandyType()
		{
			Assert.That(chips.type(), Is.EqualTo(ModelValues.CHIPS_TYPE));
		}

	}
}

