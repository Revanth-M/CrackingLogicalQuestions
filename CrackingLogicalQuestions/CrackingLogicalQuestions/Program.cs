using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingLogicalQuestions
{
    class Program
    {
        LogicalFunctionImplementation logics;
        public Program()
        {
            logics = new LogicalFunctionImplementation();
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            bool canContinue = true;
            while (canContinue)
            {
                canContinue = false;

                Console.WriteLine("Reverse String - 1 \n Check For Palindrome - 2 \n " +
                    "3rd Largest Integer in an Array - 3 \n 2D to 1D Array - 4 " +
                    "Sum of digits of an Integer - 5 \n Unique Names from String Arrays - 6 " );

                switch (Convert.ToInt16(Console.ReadLine()))
                {
                    case 1:
                        test.CallReverseString();
                        break;
                    case 2:
                        test.CallIsPalindrome();
                        break;
                    case 3:
                        test.CallReturn3rdLargestIntegerInArray();
                        break;
                    case 4:
                        test.CallReturn2DimensionalTo1DimensionalArray();
                        break;
                    case 5:
                        test.CallSumOfDigitsOfPositiveInteger();
                        break;
                    case 6:
                        test.CallUniqueNames();
                        break;
                    default:
                        Console.WriteLine("Didn't choose a Valid Option !!");
                        break;

                }
                Console.WriteLine("Continue, Y or N ?");
                if (Convert.ToString(Console.ReadLine()).Trim().ToUpper() == "Y")
                    canContinue = true;

            }
            Console.WriteLine("This program is about to be terminated !!");
            Console.Read();           
        }

        private void CallReverseString()
        {
            Console.WriteLine("Please Input a string");
            Console.WriteLine(logics.ReverseString(Console.ReadLine()));
        }

        private void CallIsPalindrome()
        {
            Console.WriteLine("Please Input a string");
            Console.WriteLine(logics.IsPalindrome(Console.ReadLine()));
        }

        private void CallReturn3rdLargestIntegerInArray()
        {
            Console.WriteLine("Please Input an integer (Max 10)");
            int[] inputArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                inputArray[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(logics.Return3rdLargestIntegerInArray(inputArray));
        }

        private void CallReturn2DimensionalTo1DimensionalArray()
        {
            Console.WriteLine("Inputted 2D Array { { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 4 } }" +
                " and the result for 1D is as follows ");
            Console.WriteLine(logics.Return2DimensionalTo1DimensionalArray(new int[4, 2] { { 0, 1 }, { 1, 2 }, { 2, 3 }, { 3, 4 } }));
        }

        private void CallSumOfDigitsOfPositiveInteger()
        {
            Console.WriteLine("Please input an Integer to get its SUM !!");
            logics.SumOfDigitsOfPositiveInteger(Convert.ToInt16(Console.ReadLine()));
        }

        private void CallUniqueNames()
        {

            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            logics.UniqueNames(names1, names2);
        }
    }
}
