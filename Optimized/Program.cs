using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimized
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Create shop
            var shop = new Shop();

            // Construct and display vehicles
            shop.Construct(new ScooterBuilder());
            shop.ShowVehicle();

            shop.Construct(new CarBuilder());
            shop.ShowVehicle();

            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();

            // Wait for user
            Console.ReadKey();
        }
    }
}
