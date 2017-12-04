using System;
using NUnit.Framework;

namespace VendingMachine
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
			Assert.That (chips.Price(), Is.EqualTo(ModelValues.CHIPS_PRICE));
		}

		[Test]
		public void TestCandyType()
		{
			Assert.That(chips.Type(), Is.EqualTo(ModelValues.CHIPS_TYPE));
		}

	}
}

