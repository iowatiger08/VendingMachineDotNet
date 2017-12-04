using System;
using VendingMachine.Models;

namespace VendingMachine
{
    public class Cola : IProduct
    {
        public string Type()
        {
            return Global.COLA_TYPE;
        }

        public int Price()
        {
            return ModelValues.COLA_PRICE;
        }



    }
}