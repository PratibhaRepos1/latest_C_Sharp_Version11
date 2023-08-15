using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string here: ");
            string userInput = Console.ReadLine();

            Console.WriteLine("Enter the character to search:");
            string searchChar = Console.ReadLine();

            int searchIndex = userInput.IndexOf(searchChar);

            Console.WriteLine("Index of character {0} in string is {1} ", searchChar, searchIndex);

            

            Console.WriteLine("Enter your First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + lastName;

            Console.WriteLine("Your full name is {0}", fullName);

            Console.ReadLine();



        }
    }
}
