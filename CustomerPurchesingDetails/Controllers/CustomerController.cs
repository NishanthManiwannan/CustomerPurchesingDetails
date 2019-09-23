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
    public class CustomerController : ControllerBase
    {
        private AllContext _customerDetails;

        public CustomerController(AllContext context)
        {
            _customerDetails = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Customers>> Get()
        {
            return _customerDetails.customers.ToList();//Customer_Details.ToList();
        }
    }
}