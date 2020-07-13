using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1,number2,number3,average;

            Console.WriteLine("Enter first num");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second num");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third num");
            number3 = Convert.ToInt32(Console.ReadLine());

            average = (number1 + number2 + number3) / 3;
            Console.WriteLine(average);
        }
    }
}
