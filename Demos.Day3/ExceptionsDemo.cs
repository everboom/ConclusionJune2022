using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Day3
{
    
    public static class ExceptionsDemos
    {
        static void Demo1()
        {

            try
            {
                //throw new OutOfMemoryException();

                throw new DemoException("Dit is mijn demo message");
            }
            catch (DemoException e)
            {
                Console.Write("Failed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


    [Serializable]
    public class DemoException : Exception
    {
        public DemoException() { }
        public DemoException(string message) : base(message) { }
        public DemoException(string message, Exception inner) : base(message, inner) { }
        protected DemoException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
