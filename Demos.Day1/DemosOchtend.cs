using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day1
{

    /*
    Console.WriteLine("Integer Demo");
    IntegerDemo();
    DrawLine("=");

    Console.WriteLine("Float Demo");
    FloatDemo();
    DrawLine();

    Console.WriteLine("Operator Demo");
    OperatorDemo();

    DrawLine();
    */

    internal class DemosOchtend
    {
        static void DrawLine(string lineCharacter = "-")
        {
            for (var i = 0; i < 10; i++)
                Console.Write(lineCharacter);
            Console.WriteLine();
        }

        static void IntegerDemo()
        {
            // bit: 1 of 0
            // byte: 8 bits, 0-255, -128 - 127

            // integer: hele getallen
            byte b = byte.MinValue;
            short s = 100;

            var leeftijd = 36;
            float andereLeeftijd = 25.5f;

            long heelgrootgetal = long.MaxValue;
            long heelkleingetal = long.MinValue;

        }

        static void FloatDemo()
        {
            // float, decimaal getal, 4 bytes
            float temperature = 21.5f;
            double worldPosition = 1000000000.999999999999999;
            // 0.125 * 10^3

            // cast van float naar int
            uint temperatureAsInt = (uint)temperature;
            int temperateAsLong = (int)temperatureAsInt;


            //double number = 0f;
            /*
            for (int i = 0; i < 1000; i++)
            {
                double number = 0.001 * (i + 1);
                Console.WriteLine(number);
            }*/

            // decimal, 16 bytes, 2x8
            decimal moneyValue = (decimal)(0.0001f * 123087);


        }

        static void OperatorDemo()
        {

            // operators
            // + - * / %
            var deling = 9 / 2;
            var rest = 5 % 2;
            var floatdeling = 5 / 2d;

            // comparison operators
            // > < >= <= == != 
            var gelijk = (5 == 5);
            var ongelijk = 10 != 34;

            // boolean operators
            // and or xor not
            var booldemo0 = true || false;
            var booldemo1 = true && false;
            var booldemo2 = !true;
            var booldemo3 = true ^ true;


        }
    }
}
