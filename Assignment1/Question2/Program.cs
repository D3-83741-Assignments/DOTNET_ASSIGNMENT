using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            Console.WriteLine(" 0-Exit\n 1-Add\n 2-Sub\n 3-Mul\n 4-Div ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Thank u!");
                    break;

                case 1:

                    Console.WriteLine("Addition is :"+(a + b));
                    break;
                case 2:
                    Console.WriteLine("Substraction is :" + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is :"+ (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division is :" +(a / b));
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
