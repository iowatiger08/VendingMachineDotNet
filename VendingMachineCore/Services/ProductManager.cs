using System;
using System.Collections.Generic;

using VendingMachine.Models;

namespace VendingMachine.Services
{
    public class ProductManager
    {
        private Dictionary<IProduct, int> productInventory;

        public IProductResult GetProductsForValue(int CashValue){

            return new NotEnoughToPurchaseResult();
        }

        public IProductResult ShowProductsAvailable(){
            return new AvailableResult().AvailableInventory();
        }

        public int GetProductCount(IProduct productSelection)
        {
            throw new NotImplementedException();
        }
    }
}