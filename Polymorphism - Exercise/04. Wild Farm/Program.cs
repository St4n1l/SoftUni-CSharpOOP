using System;
using System.Collections.Generic;

namespace WildFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }
                Animal animal = null;
                Food food = null;

                switch (command[0])
                {
                    case "Owl":
                        animal = new Owl(command[1], double.Parse(command[2]), double.Parse(command[3]));
                        break;
                    case "Hen":
                        animal = new Hen(command[1], double.Parse(command[2]), double.Parse(command[3]));
                        break;
                    case "Mouse":
                        animal = new Mouse(command[1], double.Parse(command[2]), command[3]);
                        break;
                    case "Dog":
                        animal = new Dog(command[1], double.Parse(command[2]), command[3]);
                        break;
                    case "Cat":
                        animal = new Cat(command[1], double.Parse(command[2]), command[3], command[4]);
                        break;
                    case "Tiger":
                        animal = new Tiger(command[1], double.Parse(command[2]), command[3], command[4]);
                        break;

                }

                animal.ProduceSound();
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0])
                {
                    case "Vegetable":
                        food = new Vegetable(int.Parse(command[1]));
                        break;
                    case "Fruit":
                        food = new Fruit(int.Parse(command[1]));
                        break;
                    case "Meat":
                        food = new Meat(int.Parse(command[1]));
                        break;
                    case "Seeds":
                        food = new Seeds(int.Parse(command[1]));
                        break;
                }

                animals.Add(animal);
                animal.Eat(food);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
