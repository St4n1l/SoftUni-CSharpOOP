using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        protected Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public virtual string Name { get; set; }
        public virtual double Weight { get; set; }
        public virtual int FoodEaten { get; set; }

        public void ProduceSound()
        {
            switch (this.GetType().Name)
            {
                case "Owl":
                    Console.WriteLine($"Hoot Hoot");
                    break;
                case "Hen":
                    Console.WriteLine($"Cluck");
                    break;
                case "Mouse":
                    Console.WriteLine($"Squeak");
                    break;
                case "Dog":
                    Console.WriteLine($"Woof!");
                    break;
                case "Cat":
                    Console.WriteLine($"Meow");
                    break;
                case "Tiger":
                    Console.WriteLine($"ROAR!!!");
                    break;
            }
        }

        public void Eat(Food food)
        {
            bool isValid = true;

            if (this.GetType().Name == "Hen")
            {
                this.FoodEaten += food.Quantity;
                this.Weight += 0.35 * food.Quantity;
            }
            else if (this.GetType().Name == "Owl" || this.GetType().Name == "Tiger" || this.GetType().Name == "Dog")
            {
                if (food.GetType().Name != "Meat")
                {
                    isValid = false;
                }
                else
                {
                    switch (this.GetType().Name)
                    {
                        case "Owl":
                            this.FoodEaten += food.Quantity;
                            this.Weight += 0.25 * food.Quantity;
                            break;
                        case "Tiger":
                            this.FoodEaten += food.Quantity;
                            this.Weight += 1.00 * food.Quantity;
                            break;
                        case "Dog":
                            this.FoodEaten += food.Quantity;
                            this.Weight += 0.40 * food.Quantity;
                            break;
                    }
                }
            }
            else if (this.GetType().Name == "Cat")
            {
                if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
                {
                    isValid = false;
                }
                else
                {
                    this.FoodEaten += food.Quantity;
                    this.Weight += 0.30*food.Quantity;
                }
            }
            else if (this.GetType().Name == "Mouse")
            {
                if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
                {
                    isValid = false;
                }
                else
                {
                    this.FoodEaten += food.Quantity;
                    this.Weight += 0.10 * food.Quantity;
                }
            }

            if (!isValid)
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
