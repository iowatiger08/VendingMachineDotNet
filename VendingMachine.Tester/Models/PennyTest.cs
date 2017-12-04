using System;

using NUnit.Framework;

namespace VendingMachine
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
            Assert.That(penny.Type(), Is.EqualTo("PENNY"));
		}

		[Test]
		public void testPennySize()
		{
            Assert.That(penny.Size(), Is.EqualTo(ModelValues.PENNY_SIZE));
		}

		[Test]
		public void testPennyWeight()
		{
            Assert.That(penny.Weight(), Is.EqualTo(ModelValues.PENNY_WEIGHT));
		}

		[Test]
		public void testPennyValue()
		{
			Assert.That(penny.Value, Is.EqualTo(1));
		}
	}
}

