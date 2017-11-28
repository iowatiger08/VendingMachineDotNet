using VendingMachine.Models;

namespace VendingMachine.Services
{
    public class ProductManager
    {
        public IProductResult GetProductsForValue(int CashValue){

            return new NotEnoughToPurchaseResult();
        }

        public IProductResult ShowProductsAvailable(){
            return new AvailableResult().AvailableInventory();
        }
    }
}