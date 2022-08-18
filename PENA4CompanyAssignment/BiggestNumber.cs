using System;

namespace PENA4CompanyAssignment
{
 // Write a C# Program to Find biggest of three numbers using if else Statement
    class BiggestNumber 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number First:-");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number Second:-");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number Third:-");
            int num3 = int.Parse(Console.ReadLine());
           
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Number First is the Biggest!\n");
                }
                else
                {
                    Console.WriteLine("Number Third is the Biggest!\n");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("Number Second is the Biggest!\n");
            else
                Console.WriteLine("Number Third is the Biggest!\n");
        }
    }
}
       
    

