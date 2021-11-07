using System;
using System.Collections.Generic;

namespace HW3_2
{
    abstract class Student
    {
        private string name;
        protected string state;

        public Student(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public string GetStatus()
        {
            return state;
        }
        public void Relax()
        {
            state += " Relax";
        }
        public void Read()
        {
            state += " Read";
        }
        public void Write()
        {
            state += " Write";
        }
        abstract public void Study();
    }

    class GoodStudent: Student
    {
        public GoodStudent(string name): base(name)
        {
            state = "Good:";
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

    class BadStudent: Student
    {
        public BadStudent(string name): base(name)
        {
            state = "Bad:";
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
        private string nameGroup;
        private List<Student> students = new();

        public Group(string nameGroup)
        {
            this.nameGroup = nameGroup;
        }
        
        public void AddStudent(Student st)
        {
            students.Add(st);
        }
        public void GetInfo()
        {
            Console.WriteLine(nameGroup);
            foreach (var item in students)
            {
                Console.WriteLine(item.GetName());
            }
        }
        public void GetFullInfo()
        {
            Console.WriteLine(nameGroup);
            foreach (var item in students)
            {
                Console.WriteLine(item.GetName());
                Console.WriteLine(item.GetStatus());
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Petrov = new GoodStudent("Petro Petrov");
            Student Sokolov = new BadStudent("Maksim Sokolov");
            Student Linkov = new GoodStudent("Miron Linkov");

            Group K25 = new("K25");

            K25.AddStudent(Petrov);
            K25.AddStudent(Sokolov);
            K25.AddStudent(Linkov);
            Petrov.Study();
            Sokolov.Study();
            Linkov.Study();

            K25.GetFullInfo();
        }
    }
}
