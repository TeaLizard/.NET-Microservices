using System.ComponentModel.DataAnnotations;

namespace Assignment1.Entities{
    public class Vehicle
    {
        int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Vehicle must have at least 1 wheel.")]
        int? NumberOfWheels { get; set; }

        int? NumberOfDoors { get; set; }

        string Brand { get; set; } = "";
    }
}