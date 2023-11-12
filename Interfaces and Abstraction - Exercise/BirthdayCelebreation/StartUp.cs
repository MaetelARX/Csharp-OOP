using BirthdayCelebreation.Models;
using BirthdayCelebreation.Models.Interfaces;

namespace BirthdayCelebreation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                list.Add(input);
            }
            string num = Console.ReadLine();

            foreach (var item in list)
            {
                string[] splitted = item.Split(" ");

                if (splitted.Length == 5)
                {
                    if (splitted[4].Contains(num))
                    {
                        ICitizen human = new Human();
                        Console.WriteLine(human.CitizenPrint(splitted[4], num));
                    }
                }

                else if (splitted.Length == 3 && splitted.Contains("Pet"))
                {
                    if (splitted[2].Contains(num))
                    {
                        IPet pet = new Pet();
                        Console.WriteLine(pet.PetPrint(splitted[2], num));
                    }
                }
            }
        }
    }
}