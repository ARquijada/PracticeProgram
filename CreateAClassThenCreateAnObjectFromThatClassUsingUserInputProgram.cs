using System.ComponentModel.Design;
using System.Transactions;

namespace CreateAClassThenCreateAnObjectFromThatClassUsingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Student Add & Search - Type 'Y' to SEARCH Student and 'N' to ADD Student ");
            Console.WriteLine();
            Console.Write("Enter Answer : ");
            string answer = Console.ReadLine();

            if (answer.Equals("y", StringComparison.InvariantCultureIgnoreCase))

            {
                Console.WriteLine();
                Console.WriteLine("Student SEARCH");
                Console.Write("Enter Student First Name : ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Student Last Name : ");
                string lastName = Console.ReadLine();


                if (firstName.Equals("alexis", StringComparison.InvariantCultureIgnoreCase) && (lastName.Equals("quijada", StringComparison.InvariantCultureIgnoreCase)))
                {
                    searchStudent s1 = new searchStudent(firstName, lastName);
                }                
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Student Not Found!");
                }         

            }
            else if (answer.Equals("n", StringComparison.InvariantCultureIgnoreCase))
            {

                Console.WriteLine();
                Console.WriteLine("Student ADD");
                Console.Write("Enter Student First Name : ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Student Last Name : ");
                string lastName = Console.ReadLine();

                addStudent add = new addStudent(firstName, lastName);

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid Parameter");
            }
        }
    }

    class addStudent
    {

        public string firstName;
        public string lastName;

        public addStudent(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            Console.WriteLine();
            Console.WriteLine("Student was added : " + firstName.ToUpper() + " " + lastName.ToUpper());
            Console.WriteLine("Student was added : " + firstName.ToUpper() + " " + lastName.ToUpper());

        }
    }


    class searchStudent
    {

        public string firstName;
        public string lastName;

        public searchStudent(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            Console.WriteLine();
            Console.WriteLine("Student exist in the database! - " +firstName.ToUpper() + " " + lastName.ToUpper());
        }
    }

}
