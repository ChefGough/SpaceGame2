using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{

    class WarpDrive
    {
        //Player time status
        static double time = 0;
        static double yearsTraveled = 0;
        //Warp level for upgrade and travel calculation
        static int warpLevel = 2;
        static double TimeYears = 0;

        //Earth Warps
        public void WarpUpgrade()
        {
            warpLevel += 1;
        }
        public void EarthToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 4.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EarthToM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 27.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EarthToGilese()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 10.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EarthToWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 13.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EarthToRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 18.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EarthToEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 37.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EarthToVirginis()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 50.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }

        //AC warps
        public void ACtoEarth()
        
            {
                double Speed;
                Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
                TimeYears = 4.0 / Speed;
                time += TimeYears;
                Console.WriteLine("You have travled for: " + TimeYears + " Years");
                Console.WriteLine("You have traveled a total of: " + time + "Years");
                Console.ReadLine();
            }
        public void ACtoM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 23.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void ACtoGelise()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 8.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void ACtoWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 11.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void ACtoRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 14.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void ACtoEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 33.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void ACtoVirginis()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 46.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }

        //M63 Warps
        public void M63toEarth()
        
            {
                double Speed;
                Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
                TimeYears = 27.0 / Speed;
                time += TimeYears;
                Console.WriteLine("You have travled for: " + TimeYears + " Years");
                Console.WriteLine("You have traveled a total of: " + time + "Years");
                Console.ReadLine();
            }
        public void M63ToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 23.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }


        //Gilese Warps
        public void GileseToEarth()
        
            {
                double Speed;
                Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
                TimeYears = 10.0 / Speed;
                time += TimeYears;
                Console.WriteLine("You have travled for: " + TimeYears + " Years");
                Console.WriteLine("You have traveled a total of: " + time + "Years");
                Console.ReadLine();
            }
        public void GileseToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 8.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }

        //Wolf Warps
        public void WolfToEarth()
        
            {
                double Speed;
                Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
                TimeYears = 13.0 / Speed;
                time += TimeYears;
                Console.WriteLine("You have travled for: " + TimeYears + " Years");
                Console.WriteLine("You have traveled a total of: " + time + "Years");
                Console.ReadLine();
            }
        public void WolfToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 11.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }


        //Ross Warps 
        public void RossToEarth()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 18.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void RossToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 14.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }

        //Eridani Warps
        public void EridaniToEarth()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 37.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EridaniToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 33.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }

        //Virginis Warps
        public void VirginisToEarth()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 50.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void VirginisToAC()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 46.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }


    }
}
