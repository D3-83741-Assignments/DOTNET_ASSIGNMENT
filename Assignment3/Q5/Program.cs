﻿namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor s = new Supervisor();
            s.Accept();
            s.Print();

        }
    }
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            day = 1;
            month = 1;
            year = 1;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }



        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void acceptDate()
        {
            Console.WriteLine("Enter day : ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month : ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year : ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void printDate()
        {
            Console.WriteLine("Date : " + day + "/" + month + "/" + year);
        }

        public bool isValid()
        {
            if (year > 1000 && year <= 3000)
            {
                if (day > 0 && day <= 31)
                {
                    if (month < 13)
                    {
                        if (month % 2 == 1 || month == 8)
                        {
                            if (day >= 0 && day <= 31)
                            {
                                return true;
                            }
                        }
                        else if (month == 2)
                        {
                            if (day >= 0 && day <= 28)
                            {
                                return true;
                            }
                        }
                        else
                        {
                            if (day > 0 && day <= 30)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static Date operator -(Date date1, Date date2)
        {
            Date d3 = new Date();

            d3.Year = date1.Year - date2.Year;
            d3.Month = date1.Month - date2.Month;
            d3.Day = date1.Day - date2.Day;

            return d3;
        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

    }
    public class Person
    {
        private string name;
        private bool gender;
        private Date birth;
        private string address;

        public Person()
        {
            birth = new Date();
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.address = address;
        }



        public String Name
        {
            get { return name; }

        }
        public String Gender
        {
            get { return gender ? "Male" : "Female"; }

        }
        public Date Birth
        {
            get { return birth; }

        }
        public String Address
        {
            get { return address; }

        }



        public void Accept()
        {
            Console.WriteLine("Enter name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter gender :");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter address :");
            address = Console.ReadLine();

            birth.acceptDate();

        }

        public void Print()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Gender :" + Gender);
            Console.WriteLine("Address :" + Address);
        }
        public override string ToString()
        {
            return " Name: " + Name + " Address: " + Address + " " + " Gender: " + Gender + " " + birth.ToString();
        }

    }

    public class Employee : Person
    {


        private static int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private String designation;

        public String Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        public Employee()
        {
            id++;
        }
        public Employee(int id1, double salary1, string designation1)
        {
            id = id1;
            salary = salary1;
            designation = designation1;

        }

        public enum DepartmentType
        {
            Manager, HR, Finance
        }

        private DepartmentType dept;

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public override string ToString()
        {
            return "id :" + id + " Salary :" + salary + " Designation :" + designation + " Department : " + dept;
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter designation: ");
            designation = Console.ReadLine();

            Console.WriteLine("Enter department ");
            Console.WriteLine("1.Manager");
            Console.WriteLine("2.HR ");
            Console.WriteLine("3.Finance");
            Console.WriteLine("Enter choice");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    dept = DepartmentType.Manager;
                    break;
                case 2:
                    dept = DepartmentType.HR;
                    break;
                case 3:
                    dept = DepartmentType.Finance;
                    break;
            }


        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Designation :" + Designation);
            Console.WriteLine("Department :" + Dept);
        }
    }

    public class Manager : Employee
    {
        private double bonus;



        public Manager()
        {

        }
        public Manager(double bonus1)
        {
            bonus = bonus1;

        }
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public void Accept()
        {
            base.Accept();

            Designation = "Manager";

            Console.WriteLine("Enter bonus : ");
            bonus = Convert.ToDouble(Console.ReadLine());
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("Bonus : " + Bonus);
        }


        public override string ToString()
        {
            return base.ToString() + "Bonus" + Bonus;
        }

    }


    public class Supervisor : Employee
    {

        private int subbordinates;

        public Supervisor() : base()
        {



        }

        public Supervisor(int subbordinates, double salary, string designation, DepartmentType dept)
        {
            this.subbordinates = subbordinates;


        }

        public int Subbordinates
        {
            get { return subbordinates; }
            set { subbordinates = value; }
        }

        public void Accept()
        {
            base.Accept();
            Designation = "Supervisor";
            Console.WriteLine("Enter Number of assistants");
            Subbordinates = Convert.ToInt32(Console.ReadLine());


        }

        public void Print()
        {
            base.Print();
            Console.WriteLine(" Number of assistants: " + Subbordinates);
        }

        public override string ToString()
        {
            return base.ToString() + " Number of assistants: " + Subbordinates;
        }


    }

}
