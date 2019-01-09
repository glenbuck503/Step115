using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_115
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Please enter two numbers one at a time. You do not need to enter anything for the second number.");
            int userInuput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            string userInput2 = Console.ReadLine();
            Numbers number = new Numbers();
            int total;
            if (userInput2 == "")
            {
                total = number.Addition(userInuput1);
            }
            else
            {
               total =  number.Addition(userInuput1, Convert.ToInt32(userInput2));
            }
            Console.WriteLine(total);

            Console.ReadLine();

        }
    }
}
