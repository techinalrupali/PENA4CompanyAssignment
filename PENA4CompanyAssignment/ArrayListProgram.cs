using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4CompanyAssignment
{
    //Write a asp.net Program to Print an Array List using a for-each loop
    class ArrayListProgram
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Sunday");
            arr.Add("Monday");
            arr.Add("Tuesday");
            arr.Add("Wednesday");
            arr.Add("Thusday");
            arr.Add("Friday");
            arr.Add("Saturday");
            Console.WriteLine("The elements of the ArrayList are:");
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
