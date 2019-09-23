using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerPurchesingDetails.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerPurchesingDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private AllContext _customerDetails;

        public ItemsController(AllContext context)
        {
            _customerDetails = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Items>> GetValue()
        {
            return _customerDetails.items.ToList();//Customer_Details.ToList();
        }

    }
}