using System;
using System.Collections.Generic;
using VendingMachine;

namespace VendingMachine.DataTransfers
{
    public class VendingRequest
    {
        public bool Empty { get; set; }
        public List<ICoin> BagOfCoins { get; set; }
        public IProduct Selection { get; set; }
    }
}
