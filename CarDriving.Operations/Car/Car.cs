using CarDriving.Operations.Core.Enums;
using CarDriving.Operations.Extensions;

namespace CarDriving.Operations.Car
{
    public class Car : ICar
    {
        private Orientation _orientation { get; set; }

        private int _xPosition { get; set; }

        private int _yPosition { get; set; }

        // Set initial position and orientation
        public Car(int x, int y, Orientation orientation)
        {
            _xPosition = x;
            _yPosition = y;
            _orientation = orientation;
        }

        public string GetOrientation() { return _orientation.ToString(); }

        public int GetPositionX() { return _xPosition; }

        public int GetPositionY() { return _yPosition; }

        public void Move(int x, int y, Orientation orentation)
        {
            // Increment step(s)
            _xPosition += x;
            _yPosition += y;

            // Check if it is out of range
            _xPosition.WithinRange();
            _yPosition.WithinRange();

            // Check if it is clockwise
            orentation.IsClockwise(_orientation);

            // Assume orentiation turn one direction at a time
            _orientation = orentation;
        }
    }
}
