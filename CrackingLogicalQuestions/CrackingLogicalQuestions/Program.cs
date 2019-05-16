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
                //Console.WriteLine("Please Input a string");
                //Console.WriteLine(logics.ReverseString(Console.ReadLine()));
                //Console.WriteLine(logics.IsPalindrome(Console.ReadLine()));
                int[] inputArray = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    inputArray[i] = Convert.ToInt16( Console.ReadLine());
                }
                Console.WriteLine(logics.Return3rdLargestIntegerInArray(inputArray));

                Console.WriteLine("Continue, Y or N ?");
                if (Convert.ToString(Console.ReadLine()).Trim().ToUpper() == "Y")
                    canContinue = true;

            }
            Console.WriteLine("This program is about to be terminated !!");
            Console.Read();           
        }
       
    }
}
