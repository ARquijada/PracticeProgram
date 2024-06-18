using static System.Collections.Specialized.BitVector32;
using System;

namespace StudentObjectSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("jose", "rizal", "INFORMATION TECHNOLOGY", "2nd Year", 'B', 93f, 92.1f, 99f, 98.7f, 91.2f);
            Student s2 = new Student("andress", "bonifacio", "COMPUTER SCIENCE", "3rd Year", 'E', 74.9f, 76f, 72.8f, 71.5f, 73.1f);

            s1.introduceSelf();
            s1.evaluateGrade();
            Console.WriteLine();
            Console.WriteLine();
            s2.introduceSelf();
            s2.evaluateGrade();            
        }
    }

    public class Student
    {
        public string firstName, lastName;
        public string course;
        public string year;
        public char section;
        public float english;
        public float science;
        public float math;
        public float filipino;
        public float history;

        public Student(string firstName, string lastName, string course, string year, char section, float english, float science, float math, float filipino, float history)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.year = year;
            this.section = section;
            this.english = english;
            this.science = science;
            this.math = math;
            this.filipino = filipino;
            this.history = history;
        }

        public void introduceSelf()
        { 
            Console.WriteLine("Name            : " + firstName.ToUpper() + " " + lastName.ToUpper());
            Console.WriteLine("Course          : " + course.ToUpper());
            Console.WriteLine("Year            : " + year.ToUpper());
            Console.WriteLine("Section         : " + section);
        }

        public void evaluateGrade()
        {
            float average = (english + science + math + filipino + history) / 5;
            Console.WriteLine("English         : " + english);
            Console.WriteLine("Science         : " + science);
            Console.WriteLine("Math            : " + math);
            Console.WriteLine("Filipino        : " + filipino);
            Console.WriteLine("History         : " + history);

            if (average > 100) Console.WriteLine("Invalid Grade!");
            else if (average >= 98 && average <= 100)   Console.WriteLine("AVERAGE         : " + average + " - With Highest Honor!");
            else if (average >= 95 && average <= 97.99) Console.WriteLine("AVERAGE         : " + average + " - With High Honor!");
            else if (average >= 90 && average <= 94.99) Console.WriteLine("AVERAGE         : " + average + " - With Honor!");
            else if (average >= 75 && average <= 89.99) Console.WriteLine("AVERAGE         : " + average + " - Passed!");
            else Console.WriteLine("AVERAGE         : " + average + " - Failed!");
        }
    }
}
