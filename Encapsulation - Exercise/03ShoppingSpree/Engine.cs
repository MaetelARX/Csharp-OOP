using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Engine
    {
        private readonly List<Person> persons;
        private readonly List<Product> products;

        public Engine()
        {
            persons = new List<Person>();
            products = new List<Product>();
        }
        public void Run()
        {
            string[] personsArr = Console.ReadLine().Split(new[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] productsArr = Console.ReadLine().Split(new[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            AddPerson(personsArr);
            AddProduct(productsArr);
            try
            {
                Cmd();
                Print();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AddPerson(string[]personsArr)
        {
            for (int i = 0; i < personsArr.Length; i+=2)
            {
                string name = personsArr[i];
                double money = double.Parse(personsArr[i+1]);

                Person person = new Person(name, money);
                persons.Add(person);
            }           
        }
        private void AddProduct(string[]productsArr)
        {
            for (int i = 0; i < productsArr.Length; i += 2)
            {
                string name = productsArr[i];
                double money = double.Parse(productsArr[i+1]);

                Product product = new Product(name, money);
                products.Add(product);
            }
        }
        private void Cmd()
        {
            string command = Console.ReadLine();

            while(command != "END")
            {
                string[] split = command.Split();

                string person = split[0];
                string product = split[1];

                var people = persons.Where(x => x.Name == person).FirstOrDefault();
                var producti = products.Where(x => x.Name == product).FirstOrDefault();
                
                if (people != null && product != null)
                {
                    Console.WriteLine(people.BoughtProduct(producti));
                }
                command = Console.ReadLine();
            }
        }
        private void Print()
        {
            foreach(var item in persons)
            {
                if (item.Bag.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Bag)}");
                }
            }
        }
    }
}
