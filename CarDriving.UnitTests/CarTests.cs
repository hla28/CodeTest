using System;
using CarDriving.Operations.Car;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CarDriving.Operations.Core.Enums.Orientation;

namespace CarDriving.UnitTests
{
    [TestClass]
    public class CarTests
    {
        // There are two pieces of info are not clarified. 
        // (1) Is orientation only clockwise? I assume Yes.
        // (2) What many orientation the car can change once at a time? E->S or E->S->W I assume one step at a time


        #region Acceptance Criteria
        // Given the Car is in position X = 1 and Y = 1 and facing North, 
        // when the Car turns clockwise, 
        // then the Car is still in the same position but is now facing East
        [TestMethod]
        public void Move__X1_Y1_North_To_X1_Y1_East()
        {
            ICar car = new Car(1, 1, North);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "North");

            car.Move(0, 0, East);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "East");
        }

        // Given the Car is in position X = 1 and Y = 1 and facing North, 
        // when the Car moves forward, 
        // then the Car is still facing North but is now in position X = 1 and Y = 2
        [TestMethod]
        public void Move__X1_Y1_North_To_X1_Y2_North()
        {
            ICar car = new Car(1, 1, North);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "North");

            car.Move(0, 1, North);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 2);
            Assert.AreEqual(car.GetOrientation(), "North");
        }

        // Given the Car is in position X = 1 and Y = 1 and facing East, 
        // when the Car moves forward, 
        // then the Car is still facing East but is now in position X = 2 and Y = 1
        [TestMethod]
        public void Move__X1_Y1_East_To_X2_Y1_East()
        {
            ICar car = new Car(1, 1, East);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "East");

            car.Move(1, 0, East);

            Assert.AreEqual(car.GetPositionX(), 2);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "East");
        }

        // Given the Car is in position X = 1 and Y = 1 and facing West, 
        // when the Car moves forward, 
        // then an exception is thrown
        [TestMethod]
        public void Move__X1_Y1_West_Out_Of_Bound_Exception_Thrown()
        {
            ICar car = new Car(1, 1, East);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "East");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { car.Move(-1, 0, West); });

        }

        // Given the Car is in position X = 1 and Y = 1 and facing East, 
        // when the Car moves forward twice, 
        // then the Car is still facing East but is now in position X = 3 and Y = 1
        [TestMethod]
        public void Move__X1_Y1_East_To_X3_Y1_East()
        {
            ICar car = new Car(1, 1, East);

            Assert.AreEqual(car.GetPositionX(), 1);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "East");

            car.Move(2, 0, East);

            Assert.AreEqual(car.GetPositionX(), 3);
            Assert.AreEqual(car.GetPositionY(), 1);
            Assert.AreEqual(car.GetOrientation(), "East");
        }
        #endregion
    }
}
