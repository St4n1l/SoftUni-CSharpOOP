using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleInput = new List<string>(Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList());

            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleInput.Count; i += 2)
            {
                try
                {
                    Person newPerson = new Person(peopleInput[i], double.Parse(peopleInput[i + 1]));
                    people.Add(newPerson);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            List<string> productsInput = new List<string>(Console.ReadLine()
                .Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList());

            List<Product> products = new List<Product>();

            for (int i = 0; i < productsInput.Count; i += 2)
            {
                try
                {
                    Product newProduct = new Product(productsInput[i], double.Parse(productsInput[i + 1]));
                    products.Add(newProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                string person = command[0];
                string product = command[1];

                Person neededPerson = people.Find(x => x.Name == person);
                Product neededProduct = products.Find(x => x.Name == product);

                if (neededPerson.Money >= neededProduct.Cost)
                {
                    Console.WriteLine($"{neededPerson.Name} bought {neededProduct.Name}");
                    neededPerson.Money -= neededProduct.Cost;
                    neededPerson.Products.Add(neededProduct.Name);
                }
                else
                {
                    Console.WriteLine($"{neededPerson.Name} can't afford {neededProduct.Name}");
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var person in people)
            {
                if (person.Products.Count==0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                    continue;
                }
                Console.WriteLine($"{person.Name} - {string.Join($", ",person.Products)}");
            }
        }
    }
}
