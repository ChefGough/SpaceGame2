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

        
        public void WarpUpgrade()
        {
            warpLevel += 1;
        }

        //Earth Warps
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
        public void M63ToGilese()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 17.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void M63ToWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 14.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void M63ToRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 9.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void M63ToEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 10.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void M63ToVirginis()
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
        public void GileseToM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 17.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void GileseToWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 3.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void GileseToRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 8.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void GileseToEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 27.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void GileseToVirginis()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 40.0 / Speed;
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
        public void WolfToM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 14.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void WolfToGilese()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 3.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void WolfToRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 5.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void WolfToEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 24.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void WolfToVirginis()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 37.0 / Speed;
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
        public void RossToM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 9.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void RossToWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 5.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void RossToGilese()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 8.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void RossToEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 19.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void RossToVirginis()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 32.0 / Speed;
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
        public void EridaniToM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 10.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EridaniToWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 24.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EridaniToGilese()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 27.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EridaniToRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 19.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void EridaniToVirginis()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 13.0 / Speed;
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
        public void VirginisToM63()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 23.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void VirginisToWolf()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 37.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void VirginisToGilese()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 40.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void VirginisToRoss()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 32.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        public void VirginisToEridani()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 13.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }


    }
}
