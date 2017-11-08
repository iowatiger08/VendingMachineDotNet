using System;
using System.Collections.Generic;
using VendingMachine;

namespace VendingMachine.DataTransfers
{
    public class VendingRequest
    {
        bool Empty { get; set; }
        List<ICoin> BagOfCoins { get; set; }
        IProduct Selection { get; set; }
    }
}
