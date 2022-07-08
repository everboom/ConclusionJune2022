using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day1
{
    internal class Oefeningen1
    {

        static void Exercise1()
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());

            Exercise1(x, y, z);
        }
        static double Exercise1(double param1, double param2, double param3)
        {
            var result = (param1 + param2 + param3) / 3;

            return result;
        }


        static double Pythagoras(float length0, float length1)
        {
            return Math.Sqrt(length0 * length0 + length1 * length1);

        }

        static bool DeelbaarDoor(int teller, int deler)
        {
            return teller % deler == 0;

        }

        static bool IsLeapYear(int year)
        {
            if (!DeelbaarDoor(year, 4))
                return false;

            if (!DeelbaarDoor(year, 100))
                return true;

            if (DeelbaarDoor(year, 400))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
