using System;

namespace VendingMachine
{
	public class Nickel : ICoin
	{
		public long Size()
		{
			return ModelValues.NICKEL_SIZE;
		}

		public string Type()
		{
            return ModelValues.NICKEL_TYPE;
		}

		public int Value()
		{
			return 5;
		}

		public long Weight()
		{
			return ModelValues.NICKEL_WEIGHT;
		}
	}
}