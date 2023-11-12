using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split().ToArray();
            string[] sites = Console.ReadLine().Split().ToArray();

            foreach(var item in  phoneNumber)
            {
                try
                {
                    if (item.Length == 10)
                    {
                        ICall smarthphone = new Smarthphone();
                        Console.WriteLine(smarthphone.Call(item));
                    }
                    else
                    {
                        ICall stationaryphone = new Stationaryphone();
                        Console.WriteLine(stationaryphone.Call(item));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            foreach(var item in sites)
            {
                try
                {
                    Smarthphone smarthphone = new Smarthphone();
                    Console.WriteLine(smarthphone.Browse(item));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}