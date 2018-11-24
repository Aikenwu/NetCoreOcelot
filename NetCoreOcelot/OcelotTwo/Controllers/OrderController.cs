using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OcelotTwo.Model;

namespace OcelotTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET api/Order
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var order=new Order()
            {
                Id=id,
                OrderNumber=Guid.NewGuid().ToString(),
                Time=DateTime.Now
            };

            return JsonConvert.SerializeObject(order);
        }
    }
}
