﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private const double IncreaseInWeight = 0.30;
        public Cat(string name, double weight, int foodEaten,
            string livingregion, string breed) 
            : base(name, weight, foodEaten, livingregion, breed)
        {

        }
        public override void AskForFood(Food food)
        {
            Console.WriteLine("Meow");
            if (food.name == "Meat"| food.name == "Vegetable")
            {
                this.Weight += IncreaseInWeight * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.name}!");
            }
        }

    }
}
