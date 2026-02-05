using Microsoft.AspNetCore.Mvc;
using Assignment1.Data;
using Assignment1.Entities;

namespace Assignment1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly AppDbContext _context;
        public VehicleController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var vehicles = _context.Vehicles.ToList();
            if (vehicles == null)
            {
                return NoContent();
            }
            return Ok(vehicles);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var vehicle = _context.Vehicles.Find(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Vehicle vehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Vehicles.Add(vehicle);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Vehicle newVehicle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var oldVehicle = _context.Vehicles.Find(id);
            if (oldVehicle == null)
            {
                return NotFound();
            }
            oldVehicle.Brand = newVehicle.Brand;
            oldVehicle.NumberOfWheels = newVehicle.NumberOfWheels;
            oldVehicle.NumberOfDoors = newVehicle.NumberOfDoors;
            _context.Update(oldVehicle);
            return Ok(oldVehicle);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var vehicle = _context.Vehicles.Find(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            _context.Vehicles.Remove(vehicle);
            return NoContent();
        }
    }
}