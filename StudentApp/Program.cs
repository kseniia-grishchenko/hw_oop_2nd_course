using System;
using System.Collections.Generic;

/* A program containing 4 classes: base class Student and two derived classes
GoodStudent and Bad Student, also class Group */
/* Class Student is abstract and contains two public fields and methods
that allow an object to study, write, read, relax, constructor*/
/* Classes GoodStudent and BadStudent derive all the fields and methods
from class Student and contain override method Study(), constructors*/
/* Class Group allows to form list of objects from class Student
and contains methods for getting info about objects*/
/*Let`s demonstrate result of the program on determined data set*/

namespace StudentApp
{
    abstract class Student
    {
        public string name;
        public string state;

        public Student(string st_name)
        {
            name = st_name;
            state = "";
        }
        public abstract void Study();
        public void Read()
        {
            state += "Read";
        }
        public void Write()
        {
            state += "Write";
        }
        public void Relax()
        {
            state += "Relax";
        }
    }

    class GoodStudent : Student
    {
        public GoodStudent(string st_name) : base(st_name)
        {
            state += "good";
        }

        public override void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }

    class BadStudent : Student
    {
        public BadStudent(string st_name) : base(st_name)
        {
            state += "bad";
        }

        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        public string name;
        public List<Student> students;
        public Group(string gr_name)
        {
            name = gr_name;
            students = new List<Student>();
        }
        public Group(string gr_name, List<Student> students_)
        {
            name = gr_name;
            students = students_;
        }
        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine(name);
            foreach (Student st in students)
            {
                Console.WriteLine($"{st.name} ");
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine(name);
            foreach (Student st in students)
            {
                Console.WriteLine($"{st.name} {st.state} ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GoodStudent st1 = new GoodStudent("Mary");
            GoodStudent st2 = new GoodStudent("John");
            GoodStudent st3 = new GoodStudent("Bob");
            List<Student> st_1 = new List<Student> { st1, st2, st3 };
            foreach (Student st in st_1)
            {
                st.Study();
            }
            Group first = new Group("K-14", st_1);
            first.GetInfo();
            first.GetFullInfo();

            BadStudent st4 = new BadStudent("Jane");
            BadStudent st5 = new BadStudent("Kira");
            BadStudent st6 = new BadStudent("Paul");
            List<Student> st_2 = new List<Student> { st4, st5, st6 };
            foreach (Student st in st_2)
            {
                st.Study();
            }
            Group second = new Group("K-24", st_2);
            second.GetInfo();
            second.GetFullInfo();
        }
    }
}
