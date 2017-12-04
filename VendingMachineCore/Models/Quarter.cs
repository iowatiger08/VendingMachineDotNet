using System;

namespace VendingMachine
{
	public class Quarter : ICoin
	{
		public long Size()
		{
			return ModelValues.QUARTER_SIZE;
		}

		public string Type()
		{
            return ModelValues.QUARTER_TYPE;
		}

		public int Value()
		{
			return 25;
		}

		public long Weight()
		{
			return ModelValues.QUARTER_WEIGHT;
		}
	}
}