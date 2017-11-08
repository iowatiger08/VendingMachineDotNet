using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendingMachine.DataTransfers;

namespace VendingMachine.Controllers
{
    public class VendingController : Controller
    {
        [HttpGet]
        public VendingResponse Get ()
        {
            return new VendingResponse();
        }

        [HttpPost]
        public VendingResponse Post([FromBody]VendingRequest vendingRequest)
        {
            return new VendingResponse();
        }
    }
}