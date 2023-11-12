using System.Text;
using WildFarm.AnimalModels;
using WildFarm.FoodModels;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal = null;
            Food food = null;

            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                string[] split = input.Split();
                string name = split[1];
                double weight = double.Parse(split[2]);

                string foodInput = Console.ReadLine();
                string[] foodSplit = foodInput.Split();
                string type = foodSplit[0];
                int quantity = int.Parse(foodSplit[1]);

                if (split[0] == "Owl")
                {
                    double wingSize = double.Parse(split[3]);
                    animal = new Owl(name, weight, wingSize);
                    Console.WriteLine(animal.Sound());
                    if (type == "Meat")
                    {
                        food = new Meat(quantity);
                        animal.Weight += 0.25 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    else
                    {
                        Console.WriteLine($"Owl does not eat {type}!");
                    }
                }
                else if (split[0] == "Hen")
                {
                    double wingSize = double.Parse(split[3]);
                    animal = new Hen(name, weight, wingSize);
                    Console.WriteLine(animal.Sound());
                    if(type == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                    }
                    else if (type == "Fruit")
                    {
                        food = new Fruit(quantity);
                    }
                    else if (type == "Meat")
                    {
                        food = new Meat(quantity);
                    }
                    else if (type == "Seeds")
                    {
                        food = new Seeds(quantity);
                    }
                    animal.Weight += 0.35 * food.Quantity;
                    animal.FoodEaten += quantity;
                }
                else if (split[0] == "Mouse")
                {
                    string livingRegion = split[3];
                    animal = new Mouse(name, weight, livingRegion);
                    Console.WriteLine(animal.Sound());
                    if (type == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                        animal.Weight += 0.10 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    if (type == "Fruit")
                    {
                        food = new Fruit(quantity);
                        animal.Weight += 0.10 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    else
                    {
                        Console.WriteLine($"Mouse does not eat {type}!");
                    }
                }
                else if (split[0] == "Dog")
                {
                    string livingRegion = split[3];
                    animal = new Dog(name, weight, livingRegion);
                    Console.WriteLine(animal.Sound());
                    if (type == "Meat")
                    {
                        food = new Meat(quantity);
                        animal.Weight += 0.40 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    else
                    {
                        Console.WriteLine($"Dog does not eat {type}!");
                    }
                }
                else if (split[0] == "Cat")
                {
                    string livingRegion = split[3];
                    string breed = split[4];
                    animal = new Cat(name, weight, livingRegion, breed);
                    Console.WriteLine(animal.Sound());
                    if (type == "Meat")
                    {
                        food = new Meat(quantity);
                        animal.Weight += 0.30 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    else if (type == "Vegetable")
                    {
                        food = new Vegetable(quantity);
                        animal.Weight += 0.30 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    else
                    {
                        Console.WriteLine($"Cat does not eat {type}!");
                    }
                }
                else if (split[0] == "Tiger")
                {
                    string livingRegion = split[3];
                    string breed = split[4];
                    animal = new Tiger(name, weight, livingRegion, breed);
                    Console.WriteLine(animal.Sound());
                    if (type == "Meat")
                    {
                        food = new Meat(quantity);
                        animal.Weight += 1.00 * food.Quantity;
                        animal.FoodEaten += quantity;
                    }
                    else
                    {
                        Console.WriteLine($"Tiger does not eat {type}!");
                    }
                }
                sb.AppendLine(animal.ToString());
            }
            Console.WriteLine(sb);

        }
    }
}