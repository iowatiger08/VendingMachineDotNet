﻿using System;
namespace VendingMachine
{
	public interface ICoin
	{
		long weight();
		long size();
		int value();
		string type();
	}
}
