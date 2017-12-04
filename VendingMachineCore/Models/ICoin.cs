using System;
namespace VendingMachine
{
	public interface ICoin
	{
		long Weight();
		long Size();
		int Value();
		string Type();
	}
}

