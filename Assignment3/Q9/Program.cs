using Assignment_3_Q8;

namespace Assignment_3_Q9
{
    internal class Program
    {
        public static int menu()
        {
            Console.WriteLine("1.Add Employee to company : ");
            Console.WriteLine("2.Remove Employee from the company : ");
            Console.WriteLine("3.Find Employee by id : ");
            Console.WriteLine("4.Display company info : ");
            Console.WriteLine("5.Display all employees :");
            Console.WriteLine("Enter the choice :");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choice;
            Employee emp = null;

            Company c = new Company();
            while ((choice = menu()) != 0)
            {

                switch (choice)
                {
                    case 1:
                        emp = new Employee();
                        emp.Accept();
                        c.Accept();
                        c.AddEmployee(emp);
                        Console.WriteLine("Employee added");
                        break;

                    case 2:
                        Console.WriteLine("Enter Id to remove the employee :");
                        int id = Convert.ToInt32(Console.ReadLine());

                        if (c.RemoveEmployee(id))
                        {
                            Console.WriteLine("Employee removed");
                        }
                        else
                        {
                            Console.WriteLine("Not found");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter Id to search the employee :");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        LinkedListNode<Employee> employee = (c.FindEmployee(id1));
                        //foreach (LinkedListNode<Employee> node in employee) 
                                Console.WriteLine(employee.Value); 


                        break;
                    case 4:
                        c.Print();
                        c.CalculateSalaryExpense();
                        break;
                    case 5:
                        c.PrintEmployees();
                        break;
                }
            }
        }
    }
}
