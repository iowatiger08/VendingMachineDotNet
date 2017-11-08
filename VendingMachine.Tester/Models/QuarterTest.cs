using System;

using NUnit.Framework;

namespace VendingMachine
{
	public class Test
	{
		private Quarter quarter;

		[SetUp]
		public void setUp()
		{
			quarter = new Quarter();
		}

		[Test]
		public void testType()
		{
			Assert.That(quarter.type, Is.EqualTo("QUARTER"));
		}

		[Test]
		public void testSize()
		{
			Assert.That(quarter.size, Is.EqualTo(ModelValues.QUARTER_SIZE));
		}

		[Test]
		public void testWeight()
		{
			Assert.That(quarter.weight, Is.EqualTo(ModelValues.QUARTER_WEIGHT));
		}

		[Test]
		public void testValue()
		{
			Assert.That(quarter.value, Is.EqualTo(25));
		}
	}
}

