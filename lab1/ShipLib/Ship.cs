using System;

namespace ShipLib
{
    public enum ShipType
    {
        Standard
    }

    public class Ship
    {
        public string Title { get; set; }
        public ShipType Type { get; set; }
        public string HomePort { get; set; }
        public int Tonnage { get; set; }
        public string Captain { get; set; }
        public int NumberOfCrewMembers { get; set; }
        public string DateOfLaunching { get; set; }
        public int EnginePower { get; set; }
        public double CurrentSpeed { get; set; }
        public double DeltaSpeed { get; set; }

        public Ship(string title, ShipType type, string homePort, int tonnage, string captain,
            int numberOfCrewMembers, string dateOfLaunching, int enginePower, double currentSpeed, double deltaSpeed)
        {
            Title = title;
            Type = type;
            HomePort = homePort;
            Tonnage = tonnage;
            Captain = captain;
            NumberOfCrewMembers = numberOfCrewMembers;
            DateOfLaunching = dateOfLaunching;
            EnginePower = enginePower;
            CurrentSpeed = currentSpeed;
            DeltaSpeed = deltaSpeed;
        }

        public void ChangeSpeed(double amount)
        {
            CurrentSpeed += amount;
        }
    }

    public class CargoShip : Ship
    {
        public string CargoType { get; set; }
        public int CargoCapacity { get; set; }

        public CargoShip(string title, ShipType type, string homePort, int tonnage, string captain,
            int numberOfCrewMembers, string dateOfLaunching, int enginePower, double currentSpeed, double deltaSpeed,
            string cargoType, int cargoCapacity)
            : base(title, type, homePort, tonnage, captain, numberOfCrewMembers, dateOfLaunching, enginePower, currentSpeed, deltaSpeed)
        {
            CargoType = cargoType;
            CargoCapacity = cargoCapacity;
        }
    }

    public class CruiseShip : Ship
    {
        public int OccupiedSeats { get; set; }
        public int FreeSeats { get; set; }

        public CruiseShip(string title, ShipType type, string homePort, int tonnage, string captain,
            int numberOfCrewMembers, string dateOfLaunching, int enginePower, double currentSpeed, double deltaSpeed,
            int occupiedSeats, int freeSeats)
            : base(title, type, homePort, tonnage, captain, numberOfCrewMembers, dateOfLaunching, enginePower, currentSpeed, deltaSpeed)
        {
            OccupiedSeats = occupiedSeats;
            FreeSeats = freeSeats;
        }
    }
}
