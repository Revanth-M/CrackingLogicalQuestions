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
            bool canContinue = true;
            while (canContinue)
            {
                canContinue = false;

                //Reverese a string
                Console.WriteLine("Please Input a string");
                //Console.WriteLine(logics.ReverseString(Console.ReadLine()));
                Console.WriteLine(logics.IsPalindrome(Console.ReadLine()));

                Console.WriteLine("Continue, Yes or No ?");
                if (Convert.ToString(Console.ReadLine()).Trim().ToUpper() == "YES")
                    canContinue = true;

            }
            Console.WriteLine("This program is about to be terminated !!");
            Console.Read();           
        }
       
    }
}
