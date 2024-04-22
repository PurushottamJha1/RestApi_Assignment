using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace RestApi_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryAPIController : ControllerBase
    {
        private static List<string> countries = new List<string> { "India", "France", "Germany", "USA", "China", "Russia" };

        // GET: api/CountryAPI
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return countries;
        }

        // GET: api/CountryAPI/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id >= 0 && id < countries.Count)
            {
                return Ok(countries[id]);
            }
            else
            {
                return NotFound();
            }
        }

        // POST: api/CountryAPI
        [HttpPost]
        public IActionResult Post([FromBody] string country)
        {
            countries.Add(country);
            return Ok();
        }

        // PUT: api/CountryAPI/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string country)
        {
            if (id >= 0 && id < countries.Count)
            {
                countries[id] = country;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE: api/CountryAPI/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= 0 && id < countries.Count)
            {
                countries.RemoveAt(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
