using ExplicitInterfaces.Models;
using ExplicitInterfaces.Models.Interfaces;
using System.Text;

namespace ExplicitInteraces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                string[] split = input.Split();
                IPerson person = new Citizen(split[0]);
                IResident resident = new Citizen(split[0]);

                sb.AppendLine(person.GetName());
                sb.AppendLine(resident.GetName());
            }
            Console.WriteLine(sb);
        }
    }
}