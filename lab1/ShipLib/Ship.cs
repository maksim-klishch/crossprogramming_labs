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
        public uint Tonnage { get; set; }
        public string Captain { get; set; }
        public uint NumberOfCrewMembers { get; set; }
        public string DateOfLaunching { get; set; }
        public uint EnginePower { get; set; }
        public double CurrentSpeed { get; set; }
        public double DeltaSpeed { get; set; }

        public Ship(string title, ShipType type, string homePort, uint tonnage, string captain,
            uint numberOfCrewMembers, string dateOfLaunching, uint enginePower, double currentSpeed, double deltaSpeed)
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
        public uint CargoCapacity { get; set; }

        public CargoShip(string title, ShipType type, string homePort, uint tonnage, string captain,
            uint numberOfCrewMembers, string dateOfLaunching, uint enginePower, double currentSpeed, double deltaSpeed,
            string cargoType, uint cargoCapacity)
            : base(title, type, homePort, tonnage, captain, numberOfCrewMembers, dateOfLaunching, enginePower, currentSpeed, deltaSpeed)
        {
            CargoType = cargoType;
            CargoCapacity = cargoCapacity;
        }
    }

    public class CruiseShip : Ship
    {
        public uint OccupiedSeats { get; set; }
        public uint FreeSeats { get; set; }

        public CruiseShip(string title, ShipType type, string homePort, uint tonnage, string captain,
            uint numberOfCrewMembers, string dateOfLaunching, uint enginePower, double currentSpeed, double deltaSpeed,
            uint occupiedSeats, uint freeSeats)
            : base(title, type, homePort, tonnage, captain, numberOfCrewMembers, dateOfLaunching, enginePower, currentSpeed, deltaSpeed)
        {
            OccupiedSeats = occupiedSeats;
            FreeSeats = freeSeats;
        }
    }
}
