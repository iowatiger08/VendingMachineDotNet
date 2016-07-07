using System;
namespace VendingMachineDotNet
{
	public interface ICoin
	{
		long weight();
		long size();
		int value();
		string type();
	}
}

