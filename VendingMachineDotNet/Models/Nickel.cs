using System;

namespace VendingMachineDotNet
{
	public class Nickel : ICoin
	{
		public long size()
		{
			return ModelValues.NICKEL_SIZE;
		}

		public string type()
		{
			return "NICKEL";
		}

		public int value()
		{
			return 5;
		}

		public long weight()
		{
			return ModelValues.NICKEL_WEIGHT;
		}
	}
}