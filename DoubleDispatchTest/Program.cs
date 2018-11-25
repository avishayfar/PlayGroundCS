using System;

namespace DoubleDispatchTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDoubleDispatch();

            //DoubleDispatchWithVisitor();

            Console.ReadLine();
        }

     
        private static void TestDoubleDispatch()
        {
           var dd = new DoubleDispatch();
           dd.TestDoubleDispatch();
        }


        private static void DoubleDispatchWithVisitor()
        {
           var dd = new DoubleDispatchWithVisitor();
           dd.TestDoubleDispatch();
        }
      
    }
}
