namespace NeedForSpeed
{
    public class Vehicle
    {
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public Vehicle (int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        private const double DefaultFuelConsumption = 1.25;

        public virtual double FuelConsumption => DefaultFuelConsumption;

        public virtual void Drive(double kilometeres) =>
            Fuel -= kilometeres * FuelConsumption;
    }
}
