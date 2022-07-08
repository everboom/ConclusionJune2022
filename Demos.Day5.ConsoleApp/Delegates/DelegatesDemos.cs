using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day5.ConsoleApp.Delegates
{
    // enum struct class delegate


    public class ButtonMetEvent
    {
        public event Actie ButtonClickedHandlers;


        public void ClickButton()
        {
            ButtonClickedHandlers();
        }
    }

    public delegate void Actie();
    public class ButtonMetList
    {
        public List<Actie> ButtonClickedHandlers { get; set; } = new List<Actie>();

        public void ClickButton()
        {
            foreach (var actie in ButtonClickedHandlers)
                actie();
        }
    }

    public static class DelegatesDemos
    {
        public static void Exercises()
        {
            var list = new List<int> { 1, 5, 546, 345, 1000, 1001, -123, 456 };
            var strings = new List<string> { "abc", "def", "123", "456", "1000", "ghi" };


            // where - functie die boolean teruggeeft, parameter met datatype van list
            var result1a = list.Where(GroterDanNul).ToList();
            var result1b = list.Where((int value) => value > 0).ToList();

            // select - input gelijk aan dataype van lijst, zelf kiezen wat output is
            var result2 = list.Select(VermenigVuldigMet5).ToList();

            var result3 = list.Take(5);


            Predicate<int> pred = GroterDanNul;
            Predicate<int> lambda1 = value => value > 0;
            Predicate<int> lambda2 = (int value) => value > 0;
            Predicate<int> lambda3 = (int value) => { return value > 0; };

            return;
        }
        private static bool GroterDanNul(int value) => value > 0;

        private static int VermenigVuldigMet5(int value) => value * 5;


        public static void LinqDemos()
        {
            var list = new List<int>() { 1, 5, 100, 1000 };
            foreach (var item in list.Where(IntFilter))
                Console.WriteLine(item);
            //foreach (var item in list.Select(ConverteerNaarString))
                //Console.WriteLine(item);
        }
        private static bool IntFilter(int param1)
        {
            return param1 > 10;
        }


        public static void DoDemos()
        {

            Actie actie1 = PrintGetal1;
            Actie actie2 = PrintGetal2;


            var button = new ButtonMetList();
            button.ButtonClickedHandlers.Add(actie1);
            button.ClickButton();


            return;
        }

        private static void VoerActieUit(Actie actie)
        {
            actie();
        }



        private static void PrintGetal1()
        {
            Console.WriteLine("Getal 1");
        }
        private static void PrintGetal2()
        {
            Console.WriteLine("Getal 2");
        }

    }
}
