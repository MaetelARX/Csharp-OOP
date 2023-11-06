namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar raceMotorcycle = new(150, 100);

            raceMotorcycle.Drive(10);
            Console.WriteLine(raceMotorcycle.Fuel);
        }
    }
}