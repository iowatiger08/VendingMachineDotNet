using System;

namespace VendingMachineDotNet
{
	public class Penny : ICoin
	{
		public long size()
		{
			return ModelValues.PENNY_SIZE;
		}

		public string type()
		{
			return "PENNY";
		}

		public int value()
		{
			return 1;
		}

		public long weight()
		{
			return ModelValues.PENNY_WEIGHT;
		}
	}
}