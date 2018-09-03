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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
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
            if (time >= 40)
            {
                Console.Clear();
                EndCredits();
            }
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 13.0 / Speed;
            time += TimeYears;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.WriteLine("You have traveled a total of: " + time + "Years");
            Console.ReadLine();
        }
        
            
       public void EndCredits()
        {
            Tradingpost tradingpost = new Tradingpost();
            tradingpost.EndCreditsMoney();
            Console.WriteLine("You have traveled for: " + time + " Years");
        }
            
        
       


    }
}
