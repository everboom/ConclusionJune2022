using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day2.Lib
{
    // var auto = new Auto();
    // auto.PrintBouwjaar();
    public class Auto
    {
        private int bouwjaar;

        public void PrintBouwjaar()
        {
            Console.WriteLine(this.bouwjaar);
        }

    }

    // var tests = new AutoCodeTests()
    // AutoCodeTests.DoTests()
    public static class AutoCodeTests
    {
        public static void DoTests()
        {

        }
        
    }



    public class DemoSingleton
    {
        private static DemoSingleton _instance = new DemoSingleton();
        public static DemoSingleton Instance
        {
            get 
            { 
                if (_instance == null)
                    _instance = new DemoSingleton();
                return _instance; 
            }
        }

    }
}
