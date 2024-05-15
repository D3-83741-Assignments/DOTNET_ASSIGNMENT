using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int choice = -1;

            do
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1.Addtion");
                Console.WriteLine("2.Substraction");

                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");



                Console.WriteLine("enter the choice");

                string x = Console.ReadLine();
                choice = Convert.ToInt32(x);
                int res = 0;
                int num1 = 0, num2 = 0;
                if (choice > 0)
                {
                    Console.WriteLine("enter the 1st number ");
                    num1 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("enter the 2nd number ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }


                switch (choice)
                {
                    case 0:
                        Console.WriteLine("thank u!");
                        break;
                    case 1:
                        res = num1 + num2;
                        Console.WriteLine( "Addition is :"+res);
                        break;

                    case 2:
                        res = num1 - num2;
                        Console.WriteLine("Substarction is :" + res);
                        break;

                    case 3:

                        res = num1 * num2;
                        Console.WriteLine("Multiplication is :" + res);
                        break;

                    case 4:
                        res = num1 / num2;
                        Console.WriteLine("Multiplication is :" + res);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 0);


            Console.ReadLine();



        }
    }
}
