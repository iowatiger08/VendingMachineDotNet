using System;

using NUnit.Framework;

namespace VendingMachine
{
	public class DimeTest
	{
		private Dime dime;

		[SetUp]
		public void setUp()
		{
			dime = new Dime();
		}

		[Test]
		public void testType()
		{
            Assert.That(dime.Type(), Is.EqualTo(ModelValues.DIME_TYPE));
		}

		[Test]
		public void testSize()
		{
			Assert.That(dime.Size, Is.EqualTo(ModelValues.DIME_SIZE));
		}

		[Test]
		public void testWeight()
		{
            Assert.That(dime.Weight(), Is.EqualTo(ModelValues.DIME_WEIGHT));
		}

		[Test]
		public void testValue()
		{
            Assert.That(dime.Value(), Is.EqualTo(10));
		}
	}
}

