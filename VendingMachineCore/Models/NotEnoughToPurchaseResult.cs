namespace VendingMachine.Models
{
    public class NotEnoughToPurchaseResult : IProductResult
    {
        public string Message()
        {
            return "NotEnoughToPurchase";
        }
    }
}