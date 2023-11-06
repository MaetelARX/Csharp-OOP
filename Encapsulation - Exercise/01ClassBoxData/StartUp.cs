using System.Text;

namespace ClassBoxData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                double Length = double.Parse(Console.ReadLine());
                double Width = double.Parse(Console.ReadLine());
                double Height = double.Parse(Console.ReadLine());

                Box box = new(Length, Width, Height);
                Console.WriteLine(box);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}