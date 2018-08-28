using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    class Tradingpost
    {
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
            Cargo cargo = new Cargo();
            
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
           // Console.WriteLine("Oxygen: " + Oxygen);
           // Console.WriteLine("Nitrogen: " + Nitrogen);
          //Console.WriteLine("Co2: " + Co2);
            input = Console.ReadLine();
        }
        public void TradeScreenAlphaCentauri()
        {

        }
        
        
    }
}
