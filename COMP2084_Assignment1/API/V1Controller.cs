using System;
using System.Collections.Generic;
using System.Linq;
using COMP2084_Assignment1.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace COMP2084_Assignment1.API
{

    [Route("api/cars")]
    [ApiController]
    public class V1Controller : Controller
    {

        private readonly Context _context;

        public V1Controller(Context context)
        {
            _context = context;
        }
        // GET: api/V1
        [HttpGet]
        public IActionResult Get()
        {
            var theCar = _context.Car.ToList();
            return Json(theCar);
        }

        // GET: api/V1/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var theCar = _context.Car.Where(s => s.CarId == id).SingleOrDefault();
            return Json(theCar);
        }

        // POST: api/V1
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/V1/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
