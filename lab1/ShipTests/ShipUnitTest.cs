using ShipLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShipManagementTests
{
    [TestClass]
    public class ShipManagementTests
    {
        [TestMethod]
        public void ChangeSpeed_ShouldIncreaseSpeed()
        {
            Ship ship = new Ship("Test Ship", ShipType.Standard, "Test Port", 500, "Test Captain",
                10, "2022-03-01", 3000, 10.0, 0.0);

            ship.ChangeSpeed(5.0);

            Assert.AreEqual(15.0, ship.CurrentSpeed, delta: 0.001);
        }

        [TestMethod]
        public void ChangeSpeed_ShouldDecreaseSpeed()
        {
            Ship ship = new Ship("Test Ship", ShipType.Standard, "Test Port", 500, "Test Captain",
                10, "2022-03-01", 3000, 10.0, 0.0);

            ship.ChangeSpeed(-3.0);

            Assert.AreEqual(7.0, ship.CurrentSpeed, delta: 0.001);
        }

        [TestMethod]
        public void CruiseShipConstructor_ShouldSetSeatsCorrectly()
        {
            CruiseShip cruiseShip = new CruiseShip("Cruise Ship Test", ShipType.Standard, "Test Port", 800, "Test Captain",
                15, "2022-04-01", 4000, 20.0, 0.0, 120, 30);

            Assert.AreEqual<uint>(120, cruiseShip.OccupiedSeats);
            Assert.AreEqual<uint>(30, cruiseShip.FreeSeats);
        }

        [TestMethod]
        public void CargoShipConstructor_ShouldSetCargoPropertiesCorrectly()
        {
            CargoShip cargoShip = new CargoShip("Cargo Ship Test", ShipType.Standard, "Test Port", 1000, "Test Captain",
                20, "2022-05-01", 5000, 15.0, 0.0, "Container", 5000);

            Assert.AreEqual("Container", cargoShip.CargoType);
            Assert.AreEqual<uint>(5000, cargoShip.CargoCapacity);
        }

        [TestMethod]
        public void ChangeSpeed_ShouldHandleNegativeDelta()
        {
            Ship ship = new Ship("Test Ship", ShipType.Standard, "Test Port", 500, "Test Captain",
                10, "2022-03-01", 3000, 10.0, 0.0);

            ship.ChangeSpeed(-3.0);

            Assert.AreEqual(7.0, ship.CurrentSpeed, delta: 0.001);
        }

        [TestMethod]
        public void ShipConstructor_ShouldSetPropertiesCorrectly()
        {
            Ship ship = new Ship("Test Ship", ShipType.Standard, "Test Port", 500, "Test Captain",
                10, "2022-03-01", 3000, 10.0, 0.0);

            Assert.AreEqual("Test Ship", ship.Title);
            Assert.AreEqual(ShipType.Standard, ship.Type);
            Assert.AreEqual("Test Port", ship.HomePort);
            Assert.AreEqual<uint>(500, ship.Tonnage);
            Assert.AreEqual("Test Captain", ship.Captain);
            Assert.AreEqual<uint>(10, ship.NumberOfCrewMembers);
            Assert.AreEqual("2022-03-01", ship.DateOfLaunching);
            Assert.AreEqual<uint>(3000, ship.EnginePower);
            Assert.AreEqual(10.0, ship.CurrentSpeed, delta: 0.001);
            Assert.AreEqual(0.0, ship.DeltaSpeed, delta: 0.001);
        }

        // [TestMethod]
        // [ExpectedException(typeof(InvalidOperationException),
        //     "Tonnage should be possitive")]
        // public void WrongData_ShouldRaiseException()
        // {
        //     Ship ship = new Ship("Test Ship", ShipType.Standard, "Test Port", -500, "Test Captain",
        //         10, "2022-03-01", 3000, 10.0, 0.0);
        // }
    }
}
