namespace PizzaCalories
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] input = Console.ReadLine().Split();
                string[] addOns = Console.ReadLine().Split();

                string pizzaName = input[1];

                Dough dough = new Dough(addOns[1], addOns[2], double.Parse(addOns[3]));

                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }
                    string[] newcommand = command.Split();

                    Topping topping = new Topping(newcommand[1], double.Parse(newcommand[2]));

                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}