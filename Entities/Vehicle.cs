using System.ComponentModel.DataAnnotations;

public class Vehicle
{
    int? Id;
    [Range(1, int.MaxValue, ErrorMessage = "Vehicle must have at least 1 wheel.")]
    int? NumberOfWheels;
    int? NumberOfDoors;
    string Brand = "";
}