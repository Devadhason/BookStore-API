using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_API.Controllers
{
    /// <summary>
    /// this is the test API controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
   
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;
        public HomeController(ILoggerService logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// get values
        /// </summary>
        /// <returns></returns>
        // GET: api/Home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.LogInfo("Accessed Home COntroller");
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// get a value
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            _logger.LogError("get value");
            return "value";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        // POST: api/Home
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogError("this a error");
        }

        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarn("THis is warning");
        }
    }
}
