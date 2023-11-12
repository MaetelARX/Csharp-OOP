namespace Operations
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            Console.WriteLine(mathOperations.Add(5,5));
            Console.WriteLine(mathOperations.Add(5m, 5,5));
            Console.WriteLine(mathOperations.Add(5d, 5d,5d));
        }
    }
}