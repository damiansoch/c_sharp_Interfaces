using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new("Brown", "Plastic");
            Chair gamingChair = new("Red", "Wood");

            Car damagedCar = new(80f, "Blue");

            //we can add the chairs to the list DestroyablesNearby because they implement interface IDestroyalbe
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();
        }
    }
}
