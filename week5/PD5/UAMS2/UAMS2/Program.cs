
namespace UAMS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                ConsoleUtility.Header();
                option = ConsoleUtility.Menu();
                ConsoleUtility.clearScreen();
                if (option == 1)
                {
                    if (DegreeDL.programList.Count > 0)
                    {
                        Student s = TakeInputForStudent();
                        StudentDL.AddIntoStudentList(s);
                    }
                    else
                    {
                        Console.Write("Can't add student program list is empty...!");
                    }
                }
                else if (option == 3)
                {
                    List<Student> sortedStuList = StudentDL.SortStudentByMerit();
                    GiveAdmission(sortedStuList);
                    StudentUI.printstudents();
                }
                else if (option == 4)
                {
                    ViewRegisteredStudent();
                }
                else if (option == 5)
                {
                    Console.Write("Enter Degree Name: ");
                    string degName = Console.ReadLine();
                    ViewStudentInDegree(degName);
                }
                else if (option == 6)
                {
                    Console.Write("Enter the Student name: ");
                    string stuName = Console.ReadLine();
                    Student stu = StudentPresent(stuName);
                    if (stu != null)
                    {
                        ViewSubjects(stu);
                        RegSubjects(stu);
                    }
                }
                else if (option == 7)
                {
                    CalculateFeeForAll();
                }
                ConsoleUtility.clearScreen();
            } while (option != 8);
            Console.ReadKey();
        }


        static Student StudentPresent(string name)
        {
            foreach (Student stu in StudentDL.studentList)
                if (name == stu.name)
                    return stu;
            return null;
        }

        static void CalculateFeeForAll()
        {
            foreach (Student s in StudentDL.studentList)
            {
                Console.WriteLine($"{s.name} has {s.CalculateFee()} fees");
            }
        }

        static void RegSubjects(Student stu)
        {
            Console.Write("How many subjects do you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter subject code: ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in stu.regDegree.subjects)
                {
                    if (sub.code == code && !stu.regSubjects.Contains(sub))
                    {
                        stu.RegStudentSubject(sub);
                        flag = true;
                        break;
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Enter a valid courseISD");
                        i--;
                    }
                }
            }
        }
          static void GiveAdmission(List<Student> sortedstuList)
        {
            foreach (Student s in sortedstuList)
            {
                foreach (Degree d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }

        static void ViewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            foreach (Student s in StudentDL.studentList)
                if (s.regDegree != null)
                    if (s.regDegree.degreeName == degName)
                        Console.WriteLine($"{s.name}\t{s.fscMarks}\t{s.ecatMarks}\t{s.age}");
        }
        static void ViewRegisteredStudent()
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            foreach (Student s in StudentDL.studentList)
                if (s.regDegree != null)
                    Console.WriteLine($"{s.name}\t{s.fscMarks}\t{s.ecatMarks}\t{s.age}");
        }
        static void addIntoDegreeList(Degree d)
        {
            DegreeDL.programList.Add(d);
        }
        static Degree TakeInputfordegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.Write("Enter degree name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter degree duration: ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.Write("Enter seats for degree: ");
            seats = int.Parse(Console.ReadLine());
            Degree deg = new Degree(degreeName, degreeDuration, seats);
            Console.Write("Enter how many Subjects to enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                deg.AddSubject(SubjectUI.TakeInputForSubject());
            }
            return deg;
        }


        static Student TakeInputForStudent()
        {
            string name;
            int age, matricMarks, ecatMarks, fscMarks;
            List<Degree> preferences = new List<Degree>();
            Console.Write("Enter  student name: ");
            name = Console.ReadLine();
            Console.Write("Enter  student age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter  student matric Marks: ");
            matricMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter  student fsc marks: ");
            fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter  student ecat marks: ");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.Write("Available Degree programs:- ");
            DegreeUI.ViewDegreePrograms();
            Console.Write("How many preferences do you want to register: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter degree name: ");
                string degname = Console.ReadLine();
                bool flag = false;
                foreach (Degree deg in DegreeDL.programList)
                {
                    if (deg.degreeName == degname && !preferences.Contains(deg))
                    {
                        preferences.Add(deg);
                        flag = true;
                        break;
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Enter a valid degree program...!");
                        i--;
                    }
                }
            }
            return new Student(name, age, matricMarks, ecatMarks, fscMarks, preferences);
        }



        static void ViewSubjects(Student s)
        { 
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code\t\tSub Type");
                foreach (Subject sub in s.regDegree.subjects)
                    Console.WriteLine($"{sub.code}\t\t{sub.type}");
            }
        }
    }
}