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
            Assert.That(quarter.Type(), Is.EqualTo(ModelValues.QUARTER_TYPE));
		}

		[Test]
		public void testSize()
		{
            Assert.That(quarter.Size(), Is.EqualTo(ModelValues.QUARTER_SIZE));
		}

		[Test]
		public void testWeight()
		{
            Assert.That(quarter.Weight(), Is.EqualTo(ModelValues.QUARTER_WEIGHT));
		}

		[Test]
		public void testValue()
		{
            Assert.That(quarter.Value(), Is.EqualTo(25));
		}
	}
}

