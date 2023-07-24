using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TestProgWebAPI.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private static List<Driver> _drivers = new List<Driver>
        {
                new Driver { Id = 1, Name = "John Doe", Age = 20 },
                new Driver { Id = 2, Name = "Jane Smith", Age = 25 },
                new Driver { Id = 3, Name = "Bob Johnson", Age = 30 },
                new Driver { Id = 4, Name = "Alice Brown", Age = 22 },
                new Driver { Id = 5, Name = "Mike Williams", Age = 28 },
                new Driver { Id = 6, Name = "Emily Davis", Age = 24 },
                new Driver { Id = 7, Name = "David Wilson", Age = 29 },
                new Driver { Id = 8, Name = "Sarah Miller", Age = 27 },
                new Driver { Id = 9, Name = "Chris Taylor", Age = 26 },
                new Driver { Id = 10, Name = "Linda Anderson", Age = 23 }
        };

        [HttpGet]
        public IActionResult GetDrivers()
        {
            return Ok(_drivers);
        }

        [HttpGet("{id}")]
        public IActionResult GetDriver(int id)
        {
            var driver = _drivers.Find(d => d.Id == id);
            if (driver == null)
                return NotFound();

            return Ok(driver);
        }
    }

}
