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
    public class InvoiceController : ControllerBase
    {
        private AllContext _invoice;

        public InvoiceController(AllContext context)
        {
            _invoice = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Invoice>> GetValue()
        {
            return _invoice.invoices.ToList();//Customer_Details.ToList();
        }
    }
}