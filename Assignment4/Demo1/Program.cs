using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.accept();
            student.display();

        }
    }

    public struct Student
    {
        private string name;
        private int std;
        private int age;
        private string gender;
        private char div;
        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public char Div
        {
            get { return div; }
            set { div = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public int Std
        {
            get { return std; }
            set { std = value; }
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void accept()
        {
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
            Console.WriteLine("enter the standard");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enteer the gender ");
            gender = Console.ReadLine();
            Console.WriteLine("enter the div");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the marks");
            marks = Convert.ToDouble(Console.ReadLine());
            //Console.ReadLine(); 

        }
        public void display()
        {
            Console.WriteLine("name" + name + "Standard" + std + "Age" + age + "gender" + gender + "division" + div + "marks" + marks);
        }

    }

}

