using VendingMachine.Models;

namespace VendingMachine
{
    public class Chips : IProduct
    {
        public string Type()
        {
            return Global.CHIPS_TYPE;
        }

        public int Price()
        {
            return ModelValues.CHIPS_PRICE;
        }


    
    }
}