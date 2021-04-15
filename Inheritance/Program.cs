using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "brown";
            myBird.WingLength = 6.2;
            myBird.CanFly = true;
            myBird.NumberOfEggs = 2;



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            //object initializer
            var myLizard = new Reptile()
            {
                Habitat = "Freshwater",
                IsScaly = true,
                FavoriteFood = "worms",
                GiveLiveBirth = false

            };

            List<Animal> myAnimals = new List<Animal>();

            myAnimals.Add(myBird);
            myAnimals.Add(myLizard);

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Name: {animal.Name}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"Warm Blooded: {animal.IsWarmBlooded}");
                Console.WriteLine($"Noise: {animal.MakeNoise}");
                Console.WriteLine($"");
            }
        }
    }
}
