using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Planets
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
        public void M63HomeScreen()
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
                tradingpost.TradeScreenM63();
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
                M63HomeScreen();
            }
        }
        public void GileseScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Gilese");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenGilese();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelGilese();
            }
            else
            {
                Console.Clear();
                GileseScreen();
            }
        }
        public void WolfScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Wolf");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenWolf();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelWolf();
            }
            else
            {
                Console.Clear();
                WolfScreen();
            }
        }
        public void RossScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Ross");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenRoss();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelRoss();
            }
            else
            {
                Console.Clear();
                RossScreen();
            }
        }
        public void EridaniScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Eridani");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenEridani();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelEridani();
            }
            else
            {
                Console.Clear();
                EridaniScreen();
            }
        }
        public void VirginisScreen()
        {
            Travel travel = new Travel();
            string input = "";
            Console.WriteLine("Welcome to Virginis");
            Console.WriteLine("To Enter the Trading post Press: [a]");
            Console.WriteLine("To enter the Upgrade shop Press: [b]");
            Console.WriteLine("To Travel Press: [c]");
            input = Console.ReadLine();
            if (input == "a")
            {
                Console.Clear();
                tradingpost.TradeScreenVirginis();
            }
            if (input == "b")
            {
                Console.Clear();
                tradingpost.UpgradeShop();
            }
            if (input == "c")
            {
                Console.Clear();
                travel.TravelViginis();
            }
            else
            {
                Console.Clear();
                VirginisScreen();
            }
        }

    }
    
}
