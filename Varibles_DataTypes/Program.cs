using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varibles_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables and data types
            int age = 10;
            string name = "Pratibha";
            string fullName = "Pratibha Jadhav";

            Console.WriteLine(age);
            
            Console.WriteLine("My name is " + name.ToUpper());

            //Implicit and explicit conversion

            //explicit Conversion

            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;

            Console.WriteLine(myInt);

            //Implicit Conversion
            int num = 139034;
            long bigNum = num;
            Console.WriteLine(bigNum);


            float myFloat = 13.34f;
            double myNewDouble = myFloat;
            Console.WriteLine(myNewDouble);

            //Type conversion

            string myString = myDouble.ToString();
            Console.WriteLine(myString);

            Console.WriteLine(myFloat.ToString());

            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);


            Console.ReadLine();


        }
    }
}
