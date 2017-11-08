using System;
using NUnit.Framework;

namespace VendingMachine
{
	public class CandyTest
	{
		private Candy candy;

		[SetUp]
		public void setUp()
		{
			candy = new Candy();
		}

		[Test]
		public void TestCandyPrice()
		{
			Assert.That (candy.price(), Is.EqualTo(ModelValues.CANDY_PRICE));
		}

		[Test]
		public void TestCandyType()
		{
			Assert.That(candy.type(), Is.EqualTo(ModelValues.CANDY_TYPE));
		}

	}
}

