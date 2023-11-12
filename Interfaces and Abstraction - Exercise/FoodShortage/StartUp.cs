using FoodShortage.Models;
using FoodShortage.Models.Interfaces;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<IPerson> people = new List<IPerson>();

            var numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                var inputLine = Console.ReadLine();
                people.Add(CreatePerson(inputLine));
            }

            var name = Console.ReadLine();
            while (!name.Equals("End"))
            {
                if (people.Any(p => p.Name == name))
                {
                    people.First(x => x.Name == name).BuyFood();
                }
                name = Console.ReadLine();
            }

            Console.WriteLine(people.Sum(x => x.Food));
        }

        private static IPerson CreatePerson(string inputLine)
        {
            var tokens = inputLine.Split();

            if (tokens.Length == 3)
            {
                return new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
            }

            return new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
        }
    }
}