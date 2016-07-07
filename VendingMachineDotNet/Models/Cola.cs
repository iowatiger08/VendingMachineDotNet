using System;

namespace VendingMachineDotNet
{
    public class Cola : IProduct
    {
        public int price()
        {
            return ModelValues.COLA_PRICE;
        }

        public string type()
        {
            return ModelValues.COLA_TYPE;
        }
    }
}