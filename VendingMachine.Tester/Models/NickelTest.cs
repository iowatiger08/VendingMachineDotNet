using System;

using NUnit.Framework;

namespace VendingMachine
{
	public class NickelTest
	{
		private Nickel nickel;

		[SetUp]
		public void setUp()
		{
			nickel = new Nickel();
		}

		[Test]
		public void testType()
		{
            Assert.That(nickel.Type, Is.EqualTo(ModelValues.NICKEL_TYPE));
		}

		[Test]
		public void testSize()
		{
			Assert.That(nickel.Size, Is.EqualTo(ModelValues.NICKEL_SIZE));
		}

		[Test]
		public void testWeight()
		{
			Assert.That(nickel.Weight, Is.EqualTo(ModelValues.NICKEL_WEIGHT));
		}

		[Test]
		public void testValue()
		{
			Assert.That(nickel.Value, Is.EqualTo(5));
		}
	}
}

