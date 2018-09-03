﻿using System;
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
        WarpDrive warpDrive = new WarpDrive();
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
                //4LY
                warpDrive.EarthToAC();
                Console.Clear();
                planets.AlphaCentauriScreen();
                
            }
            if (input == "b")
            {
                //27 LY
                warpDrive.EarthToM63();
                Console.Clear();
                planets.M63HomeScreen();
            }
            if (input == "c")
            {
                //10 LY
                warpDrive.EarthToGilese();
                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                //13LY
                warpDrive.EarthToWolf();
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                //18LY
                warpDrive.EarthToRoss();
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                //37
                warpDrive.EarthToEridani();
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                //50 LY
                warpDrive.EarthToVirginis();
                Console.Clear();
                planets.VirginisScreen();
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
                //4 LY
                warpDrive.ACtoEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "b")
            {
                //23 LY
                Console.Clear();
                planets.M63HomeScreen();
            }
            if (input == "c")
            {
                //8 LY
                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                //11LY
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                //14 LY
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                //33 LY
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                //46 LY
                Console.Clear();
                planets.VirginisScreen();
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
                //23 LY
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                //27 LY
                warpDrive.M63toEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "c")
            {

                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                Console.Clear();
                planets.VirginisScreen();
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
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                warpDrive.GileseToEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "c")
            {
                Console.Clear();
                planets.M63HomeScreen();
            }
            if (input == "d")
            {
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                Console.Clear();
                planets.VirginisScreen();
            }

            else
            {
                Console.Clear();
                planets.GileseScreen();
            }
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
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                warpDrive.WolfToEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "c")
            {
                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                Console.Clear();
                planets.M63HomeScreen();
            }
            if (input == "e")
            {
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                Console.Clear();
                planets.VirginisScreen();
            }

            else
            {
                Console.Clear();
                planets.WolfScreen();
            }
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
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                warpDrive.RossToEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "c")
            {
                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                Console.Clear();
                planets.M63HomeScreen();
            }
            if (input == "f")
            {
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                Console.Clear();
                planets.VirginisScreen();
            }

            else
            {
                Console.Clear();
                planets.RossScreen();
            }
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
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                warpDrive.EridaniToEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "c")
            {
                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                Console.Clear();
                planets.M63HomeScreen();
            }
            if (input == "g")
            {
                Console.Clear();
                planets.VirginisScreen();
            }

            else
            {
                Console.Clear();
                planets.EridaniScreen();
            }
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
            if (input == "a")
            {
                Console.Clear();
                planets.AlphaCentauriScreen();
            }
            if (input == "b")
            {
                warpDrive.VirginisToEarth();
                Console.Clear();
                planets.EarthHomeScreen();
            }
            if (input == "c")
            {
                Console.Clear();
                planets.GileseScreen();
            }
            if (input == "d")
            {
                Console.Clear();
                planets.WolfScreen();
            }
            if (input == "e")
            {
                Console.Clear();
                planets.RossScreen();
            }
            if (input == "f")
            {
                Console.Clear();
                planets.EridaniScreen();
            }
            if (input == "g")
            {
                Console.Clear();
                planets.M63HomeScreen();
            }

            else
            {
                Console.Clear();
                planets.VirginisScreen();
            }
        }
    }
}
