namespace VendingMachineDotNet
{
    public class Chips : IProduct
    {
        public int price()
        {
            return ModelValues.CHIPS_PRICE;
        }

        public string type()
        {
            return ModelValues.CHIPS_TYPE;
        }
    
    }
}