using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SoofaPayDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoofaController : ControllerBase
    {
        //The Url/webhook/IPN that you register to SOOFA and the expected parameters to receive from soofa
        [HttpPost]
        public ActionResult Receive(Soofa.Transaction transaction)
        {
            //DB LOGIC GOES HERE
            return Ok();
        }
    }
}