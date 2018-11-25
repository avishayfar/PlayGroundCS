using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundCS
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFunctionThatReturnThisObject();

            Console.ReadLine();
        }

        private static void TestFunctionThatReturnThisObject()
        {
            Console.WriteLine();
            var c = new Calc();
            int sum = c.Add(2).Add(2).mul(10).mul(2).Add(4).GetSum();
            Console.WriteLine("2+2*10*2+4=" + sum);
        }

    }
}
