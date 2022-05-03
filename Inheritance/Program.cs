using System;

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
            var Penguin = new Bird();
            Penguin.Flight = false;
            Penguin.Motion = "walk";
            Penguin.Noise = "ah ah ah";

            Console.WriteLine("Here we see a beautiful penguin.");
            Console.WriteLine(Penguin.BeakLength);
            Console.WriteLine(Penguin.Motion);
            Console.WriteLine(Penguin.Flight);
            Console.WriteLine(Penguin.Skin);
            Console.WriteLine(Penguin.Legs);
            Console.WriteLine(Penguin.Toes);
            Console.WriteLine(Penguin.Noise);
            Console.WriteLine(Penguin.Diet);


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var BlackMamba = new Reptile() { Legs=0, Motion="slither", Diet="rodents"};

            Console.WriteLine("Here we see a deadly black mamba.");
            Console.WriteLine(BlackMamba.Aggressive);
            Console.WriteLine(BlackMamba.Motion);
            Console.WriteLine(BlackMamba.Diet);
            Console.WriteLine(BlackMamba.Skin);
            Console.WriteLine(BlackMamba.Legs);
            Console.WriteLine(BlackMamba.Venomous);
            Console.WriteLine(BlackMamba.Endangered);
            Console.WriteLine(BlackMamba.Origin);
        }
    }
}
