﻿using System;

namespace VendingMachineDotNet
{
	public class Candy : IProduct
	{
		public int price()
		{
			return ModelValues.CANDY_PRICE;
		}

		public string type()
		{
			return ModelValues.CANDY_TYPE;
		}
	}
}