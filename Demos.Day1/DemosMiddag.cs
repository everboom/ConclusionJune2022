using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day1
{
    // private internal public protected

    internal class DemosMiddag
    {
        internal static void ArraysDemo()
        {
            int[] twoints = new int[] { 10, 50 };

            int[,] ints = new int[10, 10];
            ints[5, 5] = 25;

            int[][] jaggedArray = new int[10][];
            for (var i = 0; i < 10; i++)
            {
                jaggedArray[i] = new int[100];
            }
        }

        public static void StringsDemo()
        {
            //var myString = "abc";
            //var myChar = (int)'a';

            var myBuilder = new StringBuilder("abc");

            for (var i = 0; i < 10000; i++)
            {
                myBuilder.Append("z");
            }

            var myString = myBuilder.ToString();
            // DRY, Don't Repeat Yourself

            var formatting0 = "abc" + 5 + "bla";

            var formatting1 = string.Format("Dit is een demo: {0} asdfasdf", 100);

            var number = 200;
            var formatting2 = $"Dit is een demo {number}";

        }
        /*
            int myLargeObject = 5;
            DoWorkOnLargeObject(in myLargeObject);
        */
        static void DoWorkOnLargeObject(in int obj)
        {
            //obj = 100; // not allowed
        }

        /*
            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
        */
        static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        static void DefaultValues(string paramValue = "abc", int configValue = 100)
        {

            Console.WriteLine(paramValue, configValue);
        }

        static void CalcAngles(int x0, int y0, int x1, int y1, out int sumx, out int sumy)
        {

            sumx = x0 + x1;
            sumy = y0 + y1;

        }

        static int AddValues(params int[] values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }

            return sum;
        }

        static void Loops()
        {
            var words = new[] { "dit", "is", "een", "zin" };
            Console.WriteLine("Foreach");
            foreach (var word in words)
            {
                if (word == "dit")
                    continue;

                Console.WriteLine(word);

            }

            Console.WriteLine("");
            Console.WriteLine("For");
            for (var i = 0; i < words.Length; i += 2)
            {
                var word = words[i];
                Console.WriteLine(word);

            }


            Console.WriteLine("");
            Console.WriteLine("While");

            Console.WriteLine("Geef aub een getal tussen 0 en 100");
            var userInput = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Dat was geen getal tussen 0 en 100");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < 0 || userInput > 100)
                    break;
            }


            bool firstTime = true;
            do
            {
                if (firstTime)
                    Console.WriteLine("Geef aub een getal tussen 0 en 100");
                else
                    Console.WriteLine("Dat was geen getal tussen 0 en 100");
                firstTime = false;

                userInput = int.Parse(Console.ReadLine());
            }
            while (userInput < 0 || userInput > 100);

            return;

            // for loop:
            // 

            // foreach

            // while


        }

        static void SwitchesDemo()
        {

            int key = 30;
            switch (key)
            {
                case 30: // er is op enter gedrukt
                    Console.WriteLine("Doe het ene");
                    break;

                case 31: // Home key
                    Console.WriteLine("Doe iets");
                    break;
            }
        }
    }
}
