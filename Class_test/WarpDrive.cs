using System;
using System.Collections.Generic;
using System.Text;

namespace Class_test
{
    
    class WarpDrive
    {
        //Player time status
        static Double time = 0;
        static Double yearsTraveled = 0;
        //Warp level for upgrade and travel calculation
        static int warpLevel = 2;
        static double TimeYears = 0;

        public void WarpUpgrade()
        {
            warpLevel += 1;
        }
       public void WarpTravelEarth()
        {
            double Speed;
            Speed = Math.Pow(warpLevel, (10.0 / 3)) + Math.Pow(10 - warpLevel, (-11 / 3.0));
            TimeYears = 4.0 / Speed;
            Console.WriteLine("You have travled for: " + TimeYears + " Years");
            Console.ReadLine();
        }

}
}
