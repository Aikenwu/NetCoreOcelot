using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OcelotOne.Model;

namespace OcelotOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/Product
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var product=new Product()
            {
                Id=id,
                Title="New Product",
                Time=DateTime.Now
            };

            return JsonConvert.SerializeObject(product);
        }
    }
}
