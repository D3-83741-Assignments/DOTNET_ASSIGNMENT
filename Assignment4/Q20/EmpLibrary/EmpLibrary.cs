﻿using System.Collections;

namespace EmpLibrary
{
    [Serializable]
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


    [Serializable]
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
        public override string ToString()
        {
            return " Name: " + Name + " Address: " + Address + " " + " Gender: " + Gender + " " + birth.ToString();
        }

    }


    [Serializable]
    public enum DepartmentType
    {
        HR = 0,
        FINANCE,
        SALES
    };

    [Serializable]
    public class Employee : Person
    {
        private int id;

        private double salary;

        private string designation;

        private DepartmentType dept;

        private static int autogenerate = 1;

        public Employee()
        {

            this.id = autogenerate++;
            this.dept = DepartmentType.HR; // default HR department

        }

        public Employee(double salary, string designation, DepartmentType dept)
        {

            this.id = autogenerate++;
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;

        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }


        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter salary");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter designation");
            Designation = Console.ReadLine();
            Console.WriteLine("Choose your department from menu shown below:");

            switch (menu())
            {
                case 1:
                    dept = DepartmentType.HR;
                    break;
                case 2:
                    dept = DepartmentType.FINANCE;
                    break;
                case 3:
                    dept = DepartmentType.SALES;
                    break;

                default:
                    Console.WriteLine("WRONG CHOICE SENDING YOU IN HR DEPARTMENT AS PUNISHMENT!");
                    break;
            }
        }

        public void Print()
        {
            base.ToString();
            Console.WriteLine("Emp ID: " + Id + ",Salary: " + Salary + "Designation: " + Designation + "DepartmentType: " + Dept);
        }

        public override string ToString()
        {
            return base.ToString() + "Emp ID: " + Id + ",Salary: " + Salary + "Designation: " + Designation + "DepartmentType: " + Dept;
        }

        int menu()
        {
            Console.WriteLine("1. HR \n 2. Finance\n  3. Sales");
            return Convert.ToInt32(Console.ReadLine());
        }

    }


    public delegate void ptr();
    [Serializable]
    public class Company
    {
        private string name;
        private string address;
        private ArrayList empList;
        private double salaryExpense;
        public event ptr OnEmpListChanged ;
        

        public Company()
        {
            this.empList = new ArrayList();

        }

        public Company(string name, string address, ArrayList empList, double salaryExpense)
        {
            this.name = name;
            this.address = address;
            this.empList = empList;
            this.salaryExpense = salaryExpense;

        }


        public double SalaryExpense
        {
            get { return salaryExpense; }
            set { salaryExpense = value; }
        }


        public ArrayList EmpList
        {
            get { return empList; }
            set { empList = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public void Accept()
        {


            int num = 0;
            Console.WriteLine("Enter name of the company");
            name = Console.ReadLine();

            Console.WriteLine("Enter Address of the company");
            address = Console.ReadLine();

            Console.WriteLine("Enter number of employees in the company");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {

                Console.WriteLine("******************************************************");
                Employee emp = new Employee();
                emp.Accept();
                AddEmployee(emp);

                num--;
            }
            //Console.WriteLine("Enter S");
            //salaryExpense = Console.ReadLine();



        }

        public void AddEmployee(Employee e)
        {

            Console.WriteLine("******************************************************");
            //e.Accept();
            empList.Add(e);

            OnEmpListChanged();
            //CalculateSalaryExpense();

            e = null;

        }

        public bool RemoveEmployee(int id)
        {
            Employee node = FindEmployee(id);
            if (node != null)
            {
                empList.Remove(node);
                OnEmpListChanged();
                //CalculateSalaryExpense();
                return true;
            }
            return false;
        }

        // Method to find an employee by ID
        public Employee FindEmployee(int id)
        {
            foreach (Employee emp in empList)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public void Print()
        {

            Console.WriteLine($"Company Name: {Name}");
            Console.WriteLine($"Company Address: {Address}");
            Console.WriteLine($"Salary Expense per Month: {SalaryExpense}");
            Console.WriteLine("Employees:");
            PrintEmployees();

        }
        public void PrintEmployees()
        {
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp);
            }
        }

        public void CalculateSalaryExpense()
        {
            double totalSalary = 0;
            foreach (Employee emp in empList)
            {
                totalSalary += emp.Salary;
            }
            salaryExpense = totalSalary;
        }

        public override string ToString()
        {
            return $"Company Name: {Name}, Company Address: {Address}, Salary Expense per Month: {SalaryExpense}";
        }

    }
}
