using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Travel
    {
        //-Planets-
        //Earth
        //Alpha Centauri
        //M63
        //Gilese
        //Wolf
        //Ross
        //Eridani
        //Virginis
        
        Planets planets = new Planets();

        public void TravelEarth()
        {
            
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to m63 Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                Console.Clear();
                planets.M63HomeScreen();
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
            Console.WriteLine("To travel to Earth Press: [a]");
            Console.WriteLine("To travel to m63 Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "b")
            {
                Console.Clear();
                planets.M63HomeScreen();
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
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to Earth Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
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
                planets.M63HomeScreen();
            }
        }
        public void TravelGilese()
        {
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to Earth Press: [b]");
            Console.WriteLine("To travel to M63: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
        }
        public void TravelWolf()
        {
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to Earth Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to M63: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
        }
        public void TravelRoss()
        {
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to Earth Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to M63: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
        }
        public void TravelEridani()
        {
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to Earth Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to M63 [f]");
            Console.WriteLine("To travel to Virginis [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
        }
        public void TravelViginis()
        {
            string input = "";
            Console.WriteLine("To travel to Alpha Centauri Press: [a]");
            Console.WriteLine("To travel to Earth Press: [b]");
            Console.WriteLine("To travel to Gilese: [c]");
            Console.WriteLine("To travel to Wolf: [d]");
            Console.WriteLine("To travel to Ross: [e]");
            Console.WriteLine("To travel to Eridani [f]");
            Console.WriteLine("To travel to M63 [g]");
            Console.WriteLine("To return to main menu Press: [h]");
            input = Console.ReadLine();
        }
    }
}
