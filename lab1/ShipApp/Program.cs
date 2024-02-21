using System;
using ShipLib;

namespace ShipConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of ships
            Ship cargoShip = new CargoShip("Cargo Ship 1", ShipType.Standard, "Port A", 1000, "Captain A",
                20, "2022-01-01", 5000, 15.0, 0.0, "Bulk Cargo", 2000);

            Ship cruiseShip = new CruiseShip("Cruise Ship 1", ShipType.Standard, "Port B", 800, "Captain B",
                15, "2022-02-01", 4000, 20.0, 0.0, 150, 50);

            DisplayShipInformation(cargoShip);
            DisplayShipInformation(cruiseShip);

            cargoShip.ChangeSpeed(5.0);
            cruiseShip.ChangeSpeed(3.0);

            DisplayShipInformation(cargoShip);
            DisplayShipInformation(cruiseShip);

            Console.ReadKey();
        }

        static void DisplayShipInformation(Ship ship)
        {
            Console.WriteLine($"Ship Information - {ship.Title}");
            Console.WriteLine($"Type: {ship.Type}");
            Console.WriteLine($"Home Port: {ship.HomePort}");
            Console.WriteLine($"Tonnage: {ship.Tonnage} tons");
            Console.WriteLine($"Captain: {ship.Captain}");
            Console.WriteLine($"Number of Crew Members: {ship.NumberOfCrewMembers}");
            Console.WriteLine($"Date of Launching: {ship.DateOfLaunching}");
            Console.WriteLine($"Engine Power: {ship.EnginePower} HP");
            Console.WriteLine($"Current Speed: {ship.CurrentSpeed} knots");
            Console.WriteLine($"Delta Speed: {ship.DeltaSpeed} knots");
            Console.WriteLine();

            if (ship is CargoShip cargoShip)
            {
                Console.WriteLine($"Cargo Type: {cargoShip.CargoType}");
                Console.WriteLine($"Cargo Capacity: {cargoShip.CargoCapacity} tons");
            }
            else if (ship is CruiseShip cruiseShip)
            {
                Console.WriteLine($"Occupied Seats: {cruiseShip.OccupiedSeats}");
                Console.WriteLine($"Free Seats: {cruiseShip.FreeSeats}");
            }

            Console.WriteLine("------------------------------");
        }
    }
}
