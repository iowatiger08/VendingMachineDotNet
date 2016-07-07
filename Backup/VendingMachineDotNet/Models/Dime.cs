using System;

namespace VendingMachineDotNet
{
	public class Dime :ICoin
	{
		public Dime()
		{
		}

		public long size()
		{
			return ModelValues.DIME_SIZE;
		}

		public string type()
		{
			return "DIME";
		}

		public int value()
		{
			return 10;
		}

		public long weight()
		{
			return ModelValues.DIME_WEIGHT;
		}
	}
}