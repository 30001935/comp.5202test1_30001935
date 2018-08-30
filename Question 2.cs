using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the programme will compute the average of ten numbers");

            float total = 0;
            float average = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"enter number {i}; ");
                total = total + float.Parse(Console.ReadLine());
                average = total / 10;
            }
            Console.WriteLine($"the average number is : {average}"); 
                   
       
            }
       
    }
}
