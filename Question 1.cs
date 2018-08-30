using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            Console.WriteLine("enter a integer");
            Num1 = int.Parse(Console.ReadLine());
            if (Num1 % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            Console.ReadLine();



        }
    }
}
