using System;

namespace Class_test
{
    class Program
    {
        public static void Main()
        {
            Planets planets = new Planets();
            Console.WriteLine("Welcome to Space Game 2225! Space trading is a lucrative buisness and you want a slice.");
            Console.WriteLine("You have saved since you were a teenager, staring at the ship poster on your wall.");
            Console.WriteLine("Finally in the year 2225 you were able to afford a basic ship with upgrade slots.");
            Console.WriteLine("You start on Earth with one cargo space, which can be upgraded later on in the upgrade shop.");
            Console.WriteLine("Buy your first good and start your journey!");
            Console.WriteLine("Press [Enter]");
            Console.ReadLine();
            planets.EarthHomeScreen();

        }

        
    }
}
