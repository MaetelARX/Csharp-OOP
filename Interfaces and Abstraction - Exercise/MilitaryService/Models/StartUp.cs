using MilitaryElite.Core;
using MilitaryService.Core.Interfaces;

namespace MilitaryService
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
        }
    }
}