using System;

using NUnit.Framework;

namespace VendingMachineDotNet
{
	public class PennyTest
	{
		private Penny penny;

		[SetUp]
		public void setUp()
		{
			penny = new Penny();
		}

		[Test]
		public void testPennyType()
		{
			Assert.That(penny.type, Is.EqualTo("PENNY"));
		}

		[Test]
		public void testPennySize()
		{
			Assert.That(penny.size, Is.EqualTo(ModelValues.PENNY_SIZE));
		}

		[Test]
		public void testPennyWeight()
		{
			Assert.That(penny.weight, Is.EqualTo(ModelValues.PENNY_WEIGHT));
		}

		[Test]
		public void testPennyValue()
		{
			Assert.That(penny.value, Is.EqualTo(1));
		}
	}
}

