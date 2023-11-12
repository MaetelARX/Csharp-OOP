using System.Text;

namespace _05PlayCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int excount = 0;
            while (true)
            {
                try
                {
                    if (excount == 3)
                    {
                        break;
                    }
                    string[] command = Console.ReadLine().Split();
                    if (command[0] == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        input[index] = element;
                    }
                    else if (command[0] == "Print")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);

                        if (startIndex < 0 || endIndex > input.Length - 1)
                        {
                            throw new Exception();
                        }
                        for(int i = startIndex; i <= endIndex; i++)
                        {
                            Console.Write($"{input[i]}");
                            if (i < endIndex)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command[0] == "Show")
                    {
                        int element = int.Parse(command[1]);
                        Console.WriteLine(input[element]);
                    }
                }
                catch (FormatException ex)
                {
                    excount++;
                    Console.WriteLine("The variable is not in the correct format!");
                }
                catch (Exception ex)
                {
                    excount++;
                    Console.WriteLine("The index does not exist!");
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    Console.Write($"{input[i]}");
                }
                else
                {
                    Console.Write($"{input[i]}, ");
                }
            }
        }
    }
}