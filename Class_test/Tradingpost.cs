using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Tradingpost
    {   //Trade goods
        public static int Oxygen = 0;
        public static int Nitrogen = 0;
        public static int Co2 = 0;
        //Player status
        public static int bankPlayer = 25;
        public static int CargoSpace = 1;
        
        //Trade screens
        public void UpgradeShop()
        {
            
                string input = "";
                Console.WriteLine("To upgrade Warp Drive for 50 Credits Press: a");
                Console.WriteLine("To upgrade Cargo Hold Press: b");
                Console.WriteLine("*** The upgrade shop cannot upgrade unless you cargo hold is empty***");
                Console.WriteLine("To return to Main menu Press: c");
                input = Console.ReadLine();
                /*if (input == "a")
                {
                    if (WarpLevel >= 9)
                    {
                        Console.WriteLine("Warp level at maximum");
                        Console.ReadLine();
                    }
                    if (bankPlayer < 50)
                    {
                        Console.WriteLine("You do not have enough credits");
                        Console.ReadLine();
                    }
                    else
                    {
                        WarpLevel += 1;
                        bankPlayer -= 50;
                        Console.WriteLine("You have upgraded your warp level to: " + WarpLevel);
                        Console.ReadLine();
                    }

                }
                if (input == "b")
                {
                    if (CargoSpace >= 5)
                    {
                        Console.WriteLine("CargoSpace at maximum");
                        Console.ReadLine();
                    }
                    if (bankPlayer <= 25)
                    {
                        Console.WriteLine("You do not have enough credits");
                        Console.ReadLine();
                    }
                    else
                    {
                        CargoSpace += 1;
                        bankPlayer -= 25;
                        Console.WriteLine("You have upgraded your cargo hold to: " + CargoSpace);
                    }*/
                
            }
        public void TradeScreenEarth()
        {
            Planets planets = new Planets();
            string input = "";
            Console.WriteLine("------------------------BUY----------------------------");
            Console.WriteLine("To buy Oxygen (15 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (5) press: b");
            Console.WriteLine("To buy Co2 (10) press: c");
            Console.WriteLine("------------------------SELL----------------------------");
            Console.WriteLine("To sell Oxygen (15 Credits) press: d");
            Console.WriteLine("To sell Nitrogen (5) press: e");
            Console.WriteLine("To sell Co2(10) press: f");
            Console.WriteLine("To return to Main menu Press: g");
            Console.WriteLine("----------------------Cargo Hold------------------------");
            Console.WriteLine("You currently have in your Cargo Hold: ");
            Console.WriteLine("Oxygen: " + Oxygen);
            Console.WriteLine("Nitrogen: " + Nitrogen);
            Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (bankPlayer < 1)
                {
                   // EndCreditsMoney();
                }
                if (bankPlayer < 15)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 15;
                    CargoSpace -= 1;
                    Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "b")
            {
                if (bankPlayer < 1)
                {
                   // EndCreditsMoney();
                }
                if (bankPlayer < 5)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {

                    bankPlayer -= 5;
                    CargoSpace -= 1;
                    Nitrogen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Nitrogen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();

                }
            }
            if (input == "c")
            {
                if (bankPlayer < 1)
                {
                    //EndCreditsMoney();
                }
                if (bankPlayer < 10)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 10;
                    CargoSpace -= 1;
                    Co2 += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Co2 you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "d")
            {
                if (Oxygen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradeScreenEarth();
                }
                else
                {
                    bankPlayer += 15;
                    CargoSpace += 1;
                    Oxygen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "e")
            {
                if (Nitrogen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradeScreenEarth();
                }
                else
                {
                    bankPlayer += 5;
                    CargoSpace += 1;
                    Nitrogen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Nitrogen + " Nitrogen in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "f")
            {
                if (Co2 < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradeScreenEarth();
                }
                else
                {
                    bankPlayer += 10;
                    CargoSpace += 1;
                    Co2 -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Co2 you have " + bankPlayer + " Credits");
                    Console.WriteLine("You now have " + Co2 + " Co2 in your hold");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                planets.EarthHomeScreen();
            }
        }
        public void TradeScreenAlphaCentauri()
        {
            string input = "";
            Console.WriteLine("------------------------BUY----------------------------");
            Console.WriteLine("To buy Oxygen (20) press: a");
            Console.WriteLine("To buy Nitrogen (10) press: b");
            Console.WriteLine("To buy Co2 (5) press: c");
            Console.WriteLine("------------------------SELL----------------------------");
            Console.WriteLine("To sell Oxygen (20) press: d");
            Console.WriteLine("To sell Nitrogen(10) press: e");
            Console.WriteLine("to sell Co2 (5) press: f");
            Console.WriteLine("To return to Main menu Press: g");
            Console.WriteLine("----------------------Cargo Hold------------------------");
            Console.WriteLine("You currently have in your Cargo Hold: ");
            Console.WriteLine("Oxygen: " + Oxygen);
            Console.WriteLine("Nitrogen: " + Nitrogen);
            Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (bankPlayer < 1)
                {
                    //EndCreditsMoney();
                }
                if (bankPlayer < 20)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    bankPlayer -= 20;
                    CargoSpace -= 1;
                    Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
        }
        public void TradeScreenM68()
        {
            string input = "";
            Console.WriteLine("------------------------BUY----------------------------");
            Console.WriteLine("To buy Oxygen (10 Credits) press: a");
            Console.WriteLine("To buy Nitrogen (25 Credits) press: b");
            Console.WriteLine("To buy Co2 (15 Credits) press: c");
            Console.WriteLine("------------------------SELL----------------------------");
            Console.WriteLine("To sell Oxygen (10 Credits) press: d");
            Console.WriteLine("To sell Nitrogen (25 Credits) press: e");
            Console.WriteLine("To sell Co2 (15 Credits) press: f");
            Console.WriteLine("To return to menu Press: g");
            Console.WriteLine("----------------------Cargo Hold------------------------");
            Console.WriteLine("You currently have in your Cargo Hold: ");
            Console.WriteLine("Oxygen: " + Oxygen);
            Console.WriteLine("Nitrogen: " + Nitrogen);
            Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
        }

        
        
    }
}
