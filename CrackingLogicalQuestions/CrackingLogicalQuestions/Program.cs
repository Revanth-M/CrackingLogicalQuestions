using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingLogicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicalFunctionImplementation logics = new LogicalFunctionImplementation();
            //Reverese a string
            Console.WriteLine("Please Input a string");
            Console.WriteLine(logics.ReverseString(Console.ReadLine()));

            Console.ReadLine();
        }
       
    }
}
