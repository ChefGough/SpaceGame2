using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Planets
    {
        
        Tradingpost tradingpost = new Tradingpost();
        public void EarthHomeScreen()
        {

            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Earth!");
            Console.WriteLine("Press [a] to enter: Trade screen");
            Console.WriteLine("Press [b] to enter: Upgrade shop");
            Console.WriteLine("Press [c] to enter: Travel");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenEarth();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelEarth();
            }
            else
            {
                Console.Clear();  
                EarthHomeScreen();
            }

        }
        public void AlphaCentauriScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Alpha Centauri");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenAlphaCentauri();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelAlphaCentauri();
            }
            else
            {
                Console.Clear();
                AlphaCentauriScreen();
            }

        }
        public void M68HomeScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to M63");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenM68();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelM63();
            }
            else
            {
                Console.Clear();
                M68HomeScreen();
            }
        }
    }
    
}
