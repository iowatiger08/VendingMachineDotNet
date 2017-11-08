using VendingMachine.Models;

namespace VendingMachine.Services
{
    public class ProductManager
    {
        public IProductResult GetProductsForValue(int CashValue){

            return new NotEnoughToPurchaseResult();
        }
    }
}