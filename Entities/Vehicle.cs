using System.ComponentModel.DataAnnotations;

namespace Assignment1.Entities{
    public class Vehicle
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Vehicle must have at least 1 wheel.")]
        public int? NumberOfWheels { get; set; }

        public int? NumberOfDoors { get; set; }

        public string Brand { get; set; } = "";
    }
}