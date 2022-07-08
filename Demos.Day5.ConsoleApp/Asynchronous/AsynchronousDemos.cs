using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day5.ConsoleApp.Asynchronous
{
    public static class AsynchronousDemos
    {
        public static void DoDemos()
        {
            int result = DoSomeWork().Result;

            Console.WriteLine("Result: " + result);

            return;
        }

        private static async Task<int> DoSomeWork()
        {
            Console.WriteLine("Before work");
            
            await Task.Delay(5000);

            Console.WriteLine("After work");

            return 5;
        }
    }


}
