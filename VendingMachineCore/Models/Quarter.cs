using System;

namespace VendingMachine
{
	public class Quarter : ICoin
	{
		public long size()
		{
			return ModelValues.QUARTER_SIZE;
		}

		public string type()
		{
			return "QUARTER";
		}

		public int value()
		{
			return 25;
		}

		public long weight()
		{
			return ModelValues.QUARTER_WEIGHT;
		}
	}
}