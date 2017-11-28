using System.Collections.Generic;


namespace VendingMachine.Models
{
    public class AvailableResult : IProductResult
    {
        public string Message()
        {
            throw new System.NotImplementedException();
        }

        public IProductResult AvailableInventory()
        {
            throw new System.NotImplementedException();
            /*var productsAvailable = new List<IProduct>();
            productsAvailable.AddRange(new List<Chips>());
            productsAvailable.AddRange(new List<Cola>());
            productsAvailable.AddRange(new List<Candy>());
            return productsAvailable;
*/
        }
    }
}