public class Vehicles
{
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

  static void Main()
    {
        IMovable myCar = new Vehicles.Car();
        myCar.Move();

        IMovable myBicycle = new Vehicles.Bicycle();
        myBicycle.Move();
    }
}
