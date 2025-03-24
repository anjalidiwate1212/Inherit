using System;

namespace Inheritance_Group_3
{
    // Base class (Parent class)
    public class UniversityMember
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    // Derived class (Student)
    public class Student : UniversityMember
    {
        public string Major { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying {Major}.");
        }
    }

     public class ClassRepresentative : Student
    {
        public string ClassName { get; set; }

        public void LeadClass()
        {
            Console.WriteLine($"{Name} is the class representative for {ClassName}.");
        }
    }
    // New intermediate level: GraduateStudent
    public class GraduateStudent : Student
    {
        public string ResearchTopic { get; set; }

        public void ConductResearch()
        {
            Console.WriteLine($"{Name} is conducting research on {ResearchTopic}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects for Student and ClassRepresentative
            Student student = new Student { Name = "Alice", Age = 21, Major = "Computer Science" };
            GraduateStudent gradStudent = new GraduateStudent { Name = "Bob", Age = 24, Major = "Data Science", ResearchTopic = "Machine Learning" };
            ClassRepresentative classRep = new ClassRepresentative { Name = "John", Age = 22, Major = "Software Engineering", ClassName = "CS 101" };
            // ClassRepresentative classRep = new ClassRepresentative { Name = "John", Age = 22, Major = "Software Engineering", ClassName = "CS 101" };

            // Calling methods from all levels of inheritance
            student.Introduce();
            student.Study();

            Console.WriteLine(); // For spacing

            gradStudent.Introduce();
            gradStudent.Study();
            gradStudent.ConductResearch();

            Console.WriteLine(); // For spacing

            classRep.Introduce();
            classRep.Study();
            classRep.LeadClass();

            Console.ReadLine();
        }
    }
}
