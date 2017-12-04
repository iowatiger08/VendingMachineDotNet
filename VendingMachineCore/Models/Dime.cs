using System;

namespace VendingMachine
{
	public class Dime :ICoin
	{
		public Dime()
		{
		}

		public long Size()
		{
			return ModelValues.DIME_SIZE;
		}

		public string Type()
		{
            return ModelValues.DIME_TYPE;
		}

		public int Value()
		{
			return 10;
		}

		public long Weight()
		{
			return ModelValues.DIME_WEIGHT;
		}
	}
}