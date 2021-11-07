using System;

namespace HW3_2
{
    class Group
    {
        private Student[] groups = new Student[3];
        public Group(Student student1, Student student2, Student student3)
        {
            groups[0] = student1;
            groups[1] = student2;
            groups[2] = student3;
        }

        public void DisplayInfo()
        {
            foreach (Student std in groups)
            {
                Console.WriteLine(std.Name);
                std.Study();
                std.Read();
                std.Write();
                std.Relax();
                Console.WriteLine();
            }
        }
    }

    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Study()
        {
            Console.WriteLine("Studies");
        }
        public virtual void Read()
        {
            Console.WriteLine("Reads");
        }
        public virtual void Write()
        {
            Console.WriteLine("Writes");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Resting");
        }
    }

    class GoodStudent: Student
    {
        public override void Study()
        {
            Console.WriteLine("Studies well");
        }
        public override void Read()
        {
            Console.WriteLine("Reads well");
        }
        public override void Write()
        {
            Console.WriteLine("Writes well");
        }
        public override void Relax()
        {
            Console.WriteLine("Resting enough");
        }
    }

    class BadStudent: Student
    {
        public override void Study()
        {
            Console.WriteLine("Studies badly");
        }
        public override void Read()
        {
            Console.WriteLine("Reads badly");
        }
        public override void Write()
        {
            Console.WriteLine("Writes badly");
        }
        public override void Relax()
        {
            Console.WriteLine("Resting a lot");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Petro = new GoodStudent() { Name = "Petro Tochenko" };
            Student Maksim = new GoodStudent() { Name = "Maksim Rybak" };
            Student Volodymyr = new BadStudent() { Name = "Volodymyr Vlasov" };
            Group K25 = new(Petro, Maksim, Volodymyr);
            K25.DisplayInfo();
        }
    }
}
