namespace VehicleInterfaceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);

            Console.WriteLine("Enter Gasoline Amount: ");
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }

    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehiculo
    {
        public int Gasoline { get; set; }

        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }
        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("The Car is Driving");
            }
            else
            {
                Console.WriteLine("No Gas");
            }
        }

        public bool Refuel(int amount)
        {
            Gasoline += amount;
            return true;
        }
    }
}