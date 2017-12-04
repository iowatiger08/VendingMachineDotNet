using System;
using VendingMachine.Models;

namespace VendingMachine
{
	public class Candy : IProduct
	{

		public int Price()
		{
			return ModelValues.CANDY_PRICE;
		}

        public string Type()
		{
			return ModelValues.CANDY_TYPE;
		}
	}
}