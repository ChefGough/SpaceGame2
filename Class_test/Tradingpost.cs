using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Tradingpost
    {
        Cargo cargo = new Cargo();
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
            Console.WriteLine("Oxygen: " + cargo.Oxygen);
            Console.WriteLine("Nitrogen: " + cargo.Nitrogen);
            Console.WriteLine("Co2: " + cargo.Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (cargo.bankPlayer < 1)
                {
                   // EndCreditsMoney();
                }
                if (cargo.bankPlayer < 15)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (cargo.CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    cargo.bankPlayer -= 15;
                    cargo.CargoSpace -= 1;
                    cargo.Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + cargo.bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + cargo.Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "b")
            {
                if (cargo.bankPlayer < 1)
                {
                   // EndCreditsMoney();
                }
                if (cargo.bankPlayer < 5)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (cargo.CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {

                    cargo.bankPlayer -= 5;
                    cargo.CargoSpace -= 1;
                    cargo.Nitrogen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Nitrogen you have " + cargo.bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + cargo.Nitrogen + " Nitrogen in your hold.");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space left.");
                    Console.ReadLine();

                }
            }
            if (input == "c")
            {
                if (cargo.bankPlayer < 1)
                {
                    //EndCreditsMoney();
                }
                if (cargo.bankPlayer < 10)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (cargo.CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    cargo.bankPlayer -= 10;
                    cargo.CargoSpace -= 1;
                    cargo.Co2 += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of Co2 you have " + cargo.bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + cargo.Co2 + " Co2 in your hold.");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space left.");
                    Console.ReadLine();
                }
            }
            if (input == "d")
            {
                if (cargo.Oxygen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradeScreenEarth();
                }
                else
                {
                    cargo.bankPlayer += 15;
                    cargo.CargoSpace += 1;
                    cargo.Oxygen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + cargo.bankPlayer + " Credits");
                    Console.WriteLine("You now have " + cargo.Oxygen + " oxygen in your hold");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "e")
            {
                if (cargo.Nitrogen < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradeScreenEarth();
                }
                else
                {
                    cargo.bankPlayer += 5;
                    cargo.CargoSpace += 1;
                    cargo.Nitrogen -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of oxygen you have " + cargo.bankPlayer + " Credits");
                    Console.WriteLine("You now have " + cargo.Nitrogen + " Nitrogen in your hold");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space");
                    Console.ReadLine();
                }
            }
            if (input == "f")
            {
                if (cargo.Co2 < 1)
                {
                    Console.WriteLine("You do not have any to sell");
                    Console.WriteLine("Press Enter");
                    Console.ReadLine();
                    Console.Clear();
                    TradeScreenEarth();
                }
                else
                {
                    cargo.bankPlayer += 10;
                    cargo.CargoSpace += 1;
                    cargo.Co2 -= 1;
                    Console.Clear();
                    Console.WriteLine("You have sold 1 unit of Co2 you have " + cargo.bankPlayer + " Credits");
                    Console.WriteLine("You now have " + cargo.Co2 + " Co2 in your hold");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space");
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
            Console.WriteLine("Oxygen: " + cargo.Oxygen);
            Console.WriteLine("Nitrogen: " + cargo.Nitrogen);
            Console.WriteLine("Co2: " + cargo.Co2);
            input = Console.ReadLine();
            if (input == "a")
            {
                if (cargo.bankPlayer < 1)
                {
                    //EndCreditsMoney();
                }
                if (cargo.bankPlayer < 20)
                {
                    Console.WriteLine("You do not have enough credits");
                    Console.ReadLine();
                }
                if (cargo.CargoSpace < 1)
                {
                    Console.WriteLine("You do not have enough room");
                    Console.ReadLine();
                }
                else
                {
                    cargo.bankPlayer -= 20;
                    cargo.CargoSpace -= 1;
                    cargo.Oxygen += 1;
                    Console.Clear();
                    Console.WriteLine("You have bought 1 unit of oxygen you have " + cargo.bankPlayer + " Credits left");
                    Console.WriteLine("You now have " + cargo.Oxygen + " oxygen in your hold.");
                    Console.WriteLine("You have " + cargo.CargoSpace + " Cargo space left.");
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
            Console.WriteLine("Oxygen: " + cargo.Oxygen);
            Console.WriteLine("Nitrogen: " + cargo.Nitrogen);
            Console.WriteLine("Co2: " + cargo.Co2);
            input = Console.ReadLine();
        }

        
        
    }
}
