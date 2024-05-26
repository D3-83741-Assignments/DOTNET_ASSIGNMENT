namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number of students");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] student = null;

            CreateArray(student, size);


            Console.ReadLine();
        }
        public static void CreateArray(Student[] s, int size)
        {
            s = new Student[size];
            acceptInfo(s, size);
        }

        public static void acceptInfo(Student[] s, int size)
        {
            for (int i = 0; i < size; i++)
            {
                s[i].acceptDetails();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            printInfo(s, size);
        }

        public static void printInfo(Student[] s, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Details about student: ");
                s[i].printDetails();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

            reverseArray(s, size);
        }

        public static void reverseArray(Student[] s, int size)
        {
            int i = size - 1;
            int j = 0;
            Student[] ns = new Student[size];
            //for (i = size - 1, j = 0; i >= 0, j < size ;i--,j++ )
            //{

            //}
            Console.WriteLine("Reversed array :");
            while (i >= 0)
            {
                ns[j] = s[i];
                j++;
                i--;
            }
            for (int k = 0; k < size; k++)
            {
                ns[k].printDetails();
            }

        }
    }
    struct Student
    {

        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;


        public Student(string n, bool g, int a,
        int s,
        char d,
        double m)
        {
            name = n;
            gender = g;
            age = a;
            std = s;
            div = d;
            marks = m;
        }



        public int Age
        {
            get { return age; }
            set { age = value; }
        }



        public String Name
        {
            get { return name; }
            set { name = value; }
        }



        public int Std
        {
            get { return std; }
            set { std = value; }
        }


        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }




        public char Div
        {
            get { return div; }
            set { div = value; }
        }




        public void acceptDetails()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender");
            gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter standard");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter division");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter marks");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public bool isMale()
        {
            if (gender)
                return true;
            else return false;
        }

        public void printDetails()
        {

            Console.WriteLine("name: " + name);

            if (isMale())
                Console.WriteLine("gender :Male");
            else
                Console.WriteLine("Female");

            Console.WriteLine("age: " + age);
            Console.WriteLine("standard: " + std);
            Console.WriteLine("division: " + div);
            Console.WriteLine("marks: " + marks);
        }
    }
}
