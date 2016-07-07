using System;
using NUnit.Framework;

namespace VendingMachineDotNet
{
	public class ColaTest
	{
		private Cola cola;

		[SetUp]
		public void setUp()
		{
            cola = new Cola();
		}

		[Test]
		public void TestCandyPrice()
		{
			Assert.That (cola.price(), Is.EqualTo(ModelValues.COLA_PRICE));
		}

		[Test]
		public void TestCandyType()
		{
			Assert.That(cola.type(), Is.EqualTo(ModelValues.COLA_TYPE));
		}

	}
}

