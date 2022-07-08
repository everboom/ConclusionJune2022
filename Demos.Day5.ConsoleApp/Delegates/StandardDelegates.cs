using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day5.ConsoleApp.Delegates
{
    public static class StandardDelegates
    {
        public static void DoDemo()
        {
            Action action = DemoAction;

            Func<string> myFunc;
            Func<bool> mySecondFunc = ProvideBooleanResult;

            Predicate<string> myPredicate = ProvideBooleanResult;
        }

        private static void DemoAction()
        { }

        private static bool ProvideBooleanResult() { return true; }


        private static bool ProvideBooleanResult(string myInput) 
        {
            return myInput.Length == 3; 
        }
    }
}
