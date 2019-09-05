using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number1 => ");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            Console.WriteLine("Enter Number2 => ");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);

            Console.WriteLine("Enter Operator (+, -, /, *) => ");
            string input3 = Console.ReadLine();

            int output = 0;

            if (input3 == "+")
            {
                output = num1 + num2;
            }
            else if (input3 == "-")
            {
                output = num1 - num2;
            }
            else if (input3 == "*")
            {
                output = num1 * num2;
            }
            else if (input3 == "/")
            {
                output = num1 / num2;
            }

            Console.WriteLine(num1 + " " + input3 + " " + num2 + " = " + output +".");
            Console.ReadLine();
        }
    }
}
