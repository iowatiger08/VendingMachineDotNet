using System;
using NUnit.Framework;

namespace VendingMachine
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
			Assert.That (cola.Price(), Is.EqualTo(ModelValues.COLA_PRICE));
		}

		[Test]
		public void TestCandyType()
		{
			Assert.That(cola.Type(), Is.EqualTo(ModelValues.COLA_TYPE));
		}

	}
}

