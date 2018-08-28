using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Travel
    {
        Planets planets = new Planets();

        public void TravelEarth()
        {
            
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: a");
            Console.WriteLine("To travel to m63 Press: b");
            Console.WriteLine("To return to main menu Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                Console.Clear();
                planets.M68HomeScreen();
            }
            else
            {
                Console.Clear();
                planets.EarthHomeScreen();
            }
        }
        public void TravelAlphaCentauri()
        {
            string input = "";
            Console.WriteLine("To travel to Earth Press: a");
            Console.WriteLine("To travel to m63 Press: b");
            Console.WriteLine("To return to main menu Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "b")
            {
                Console.Clear();
                planets.M68HomeScreen();
            }
            else
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
        }
        public void TravelM63()
        {
            string input = "";
            Console.WriteLine("To travel to Earth Press: a");
            Console.WriteLine("To travel to Alpha Centauri Press: b");
            Console.WriteLine("To return to main menu Press: c");
            input = Console.ReadLine();
            if (input == "a")
            {

                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "b")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            else
            {
                Console.Clear();
                planets.M68HomeScreen();
            }
        }
    }
}
