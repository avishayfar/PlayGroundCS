using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndSaySequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();
            Console.WriteLine("Enter times");
            int times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            PrintSequence(number, times);

            Console.ReadKey();
        }

        static void PrintSequence(string baseNumber, int times)
        {
            string number = baseNumber; 
            for (int i =0; i < times; i++)
            {
                Console.WriteLine(number);
                number = GetNextNumber(number);
            }
        }

        static string GetNextNumber(string number)
        {
            char lastChar = number[0];
            int amount = 1;

            var sb = new StringBuilder();
            for (int i = 1; i < number.Length; i++)
            {
                char curChar = number[i];
                if (curChar == lastChar)
                {
                    amount++;
                }
                else
                {
                    sb.Append(amount);
                    sb.Append(lastChar);
                    lastChar = curChar;
                    amount = 1;
                }
            }

            sb.Append(amount);
            sb.Append(lastChar);

            return  Convert.ToString(sb);
        }
    }
}
