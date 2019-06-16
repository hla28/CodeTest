using CarDriving.Operations.Core.Enums;

namespace CarDriving.Operations.Car
{
    public interface ICar
    {
        void Move(int x, int y, Orientation orentation);

        int GetPositionX();

        int GetPositionY();

        string GetOrientation();
    }
}
