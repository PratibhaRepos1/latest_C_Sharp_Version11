using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "";

            Console.WriteLine("Please enter your name and press enter: ");
            myName = Console.ReadLine();
            string myNameUpperCase = string.Format("Upper Case: {0}", myName.ToUpper());
            string myNameLowerCase = string.Format("Lower Case: {0}", myName.ToLower());
            string myNameTrimmed = string.Format("Trim the string: {0}", myName.Trim());
            string myNameSubString = string.Format("Substring: {0}", myName.Substring(0, 5));

           
            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrimmed);
            Console.WriteLine(myNameSubString);

            Console.ReadLine();



        }
    }
}
