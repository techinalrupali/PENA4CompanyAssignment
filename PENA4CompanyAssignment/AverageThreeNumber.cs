using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4CompanyAssignment
{
    //Write a C# Program to average of 3 numbers and print
    class AverageThreeNumber
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, avarage;

            Console.Write("Enter 1st number :");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number :");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number :");
            number3 = int.Parse(Console.ReadLine());

            avarage = (number1 + number2 + number3) / 3;

            Console.WriteLine("Avarage of three numbers is {0}", avarage);

            
        }
    }
}
