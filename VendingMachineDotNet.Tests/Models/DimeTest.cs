using System;

using NUnit.Framework;

namespace VendingMachineDotNet
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
			Assert.That(dime.type, Is.EqualTo("DIME"));
		}

		[Test]
		public void testSize()
		{
			Assert.That(dime.size, Is.EqualTo(ModelValues.DIME_SIZE));
		}

		[Test]
		public void testWeight()
		{
			Assert.That(dime.weight, Is.EqualTo(ModelValues.DIME_WEIGHT));
		}

		[Test]
		public void testValue()
		{
			Assert.That(dime.value, Is.EqualTo(10));
		}
	}
}

