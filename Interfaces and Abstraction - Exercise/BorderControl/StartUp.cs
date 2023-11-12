using BorderControl.Models;
using BorderControl.Models.Interfaces;

namespace BorderControl
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
                string[] splitted = item.Split();

                if(splitted.Length == 3)
                {
                    if (splitted[2].Contains(num))
                    {
                        IHuman human = new Human();
                        Console.WriteLine(human.PrintHuman(splitted[2], num));
                    }
                }

                else if (splitted.Length == 2)
                {
                    if (splitted[1].Contains(num))
                    {
                        IRobot robot = new Robot();
                        Console.WriteLine(robot.RobotPrint(splitted[1], num));
                    }
                }                
            }
        }
    }
}