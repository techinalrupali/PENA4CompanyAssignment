using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENA4CompanyAssignment
{
    //Write a C# Program to enter two float input values and Multiply print roundup by 2 digit after decimal 
    class TwoFloatMultiply
    {
        static void Main(string[] args)
        {
           float f1=12.55555f;
            float f2 = 12.55555f;
            float res = f1 * f2;
            res = (float)Math.Round(res, 2, MidpointRounding.ToEven);
            Console.WriteLine(res);
        }






    }
}
