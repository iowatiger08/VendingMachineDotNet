using System;

namespace VendingMachine
{
	public class Penny : ICoin
	{
		public long Size()
		{
			return ModelValues.PENNY_SIZE;
		}

		public string Type()
		{
			return "PENNY";
		}

		public int Value()
		{
			return 1;
		}

		public long Weight()
		{
			return ModelValues.PENNY_WEIGHT;
		}
	}
}