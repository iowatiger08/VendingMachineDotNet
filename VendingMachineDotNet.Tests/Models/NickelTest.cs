using System;

using NUnit.Framework;

namespace VendingMachineDotNet
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
			Assert.That(nickel.type, Is.EqualTo("NICKEL"));
		}

		[Test]
		public void testSize()
		{
			Assert.That(nickel.size, Is.EqualTo(ModelValues.NICKEL_SIZE));
		}

		[Test]
		public void testWeight()
		{
			Assert.That(nickel.weight, Is.EqualTo(ModelValues.NICKEL_WEIGHT));
		}

		[Test]
		public void testValue()
		{
			Assert.That(nickel.value, Is.EqualTo(5));
		}
	}
}

