using Raiding.Models;
using Raiding.Models.Interfaces;

namespace Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                if (type == "Druid")
                {
                    ICast cast = new Druid(name);
                    Console.WriteLine(cast.CastAbility());
                    sum += 80;
                }
                else if (type == "Paladin")
                {
                    ICast cast = new Paladin(name);
                    Console.WriteLine(cast.CastAbility());
                    sum += 100;
                }
                else if (type == "Rogue")
                {
                    ICast cast = new Rogue(name);
                    Console.WriteLine(cast.CastAbility());
                    sum += 80;
                }
                else if (type == "Warrior")
                {
                    ICast cast = new Warrior(name);
                    Console.WriteLine(cast.CastAbility());
                    sum += 100;
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }
            int bossPower = int.Parse(Console.ReadLine());

            if (sum >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}