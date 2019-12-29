using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingLogicalQuestions
{
    class LogicalFunctionImplementation
    {
        public string ReverseString(string inputStr)
        {
            string outputStr = "";
            
            //Using LINQ Function 
            IEnumerable<char> reversedChar = inputStr.Reverse();
            foreach (var item in reversedChar)
                outputStr += item;

            //Using character Array 
            char[] characterArrayOfGivenString = inputStr.ToCharArray();
            for(int i =0, j=inputStr.Length-1; i<j; i++, j--)
            {
                characterArrayOfGivenString[i] = inputStr[j];
                characterArrayOfGivenString[j] = inputStr[i];
            }
            string outputStrUsingCharArray = new string(characterArrayOfGivenString);

            return $"LINQ Output - [{outputStr}]. CHAR ARRAY Output - [{outputStrUsingCharArray}]";
        }

        public string IsPalindrome(string inputStr)
        {
            bool isPalindrome = false;
            bool isPalindromeFromCharArrayCheck = true;
            string outputStr = "";

            //LINQ Function 
            IEnumerable<char> reversedChar = inputStr.Reverse();
            foreach (var item in reversedChar)
                outputStr += item;

            if (string.Compare(inputStr, outputStr, true) == 0)
                isPalindrome = true;

            //Using Array's 
            char[] characterArrayOfGivenString = inputStr.ToCharArray();
            for (int i = 0, j = inputStr.Length - 1; i < j; i++, j--)
            {
                if (inputStr[j] != inputStr[i])
                {
                    isPalindromeFromCharArrayCheck = false;
                    break;
                }
            }
            return $"{inputStr} is Palindrome - {isPalindrome} ";
        }

        public int AngleBetweenTime(decimal inputHr, decimal inputMinute)
        {
            return 0;
        }

        public int Return3rdLargestIntegerInArray(int[] inputArray)
        {
            int max3Integer = int.MinValue;
            int max2Integer = int.MinValue;
            int max1Integer = int.MinValue;
            for(int i=0; i < inputArray.Length-1; i++)
            {
                if (inputArray[i] > max1Integer)
                {
                    max3Integer = max2Integer;
                    max2Integer = max1Integer;
                    max1Integer = inputArray[i];
                }
                else if (inputArray[i] > max2Integer)
                {
                    max3Integer = max2Integer;
                    max2Integer = inputArray[i];
                }
                else if (inputArray[i] > max3Integer)
                    max3Integer = inputArray[i];
            }
            return max3Integer;
        }

        public string Return2DimensionalTo1DimensionalArray(int[,] inputArray)
        {
            int[] columnWiseArray = new int[inputArray.Length];
            int[] rowWiseArray = new int[inputArray.Length];
            int index = 0;

            int height = inputArray.GetLength(0);
            int width = inputArray.GetLength(1);
            for(int x=0; x<height; x++)
            {
                for(int y=0; y < width; y++)
                {
                    columnWiseArray[index] = inputArray[x,y];

                    index++;
                }
            }

            index = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    rowWiseArray[index] = inputArray[y, x];
                    index++;
                }
            }

            return $"Column Wise Array { string.Join(" ", columnWiseArray) }, Row Wise Array {string.Join(" ",rowWiseArray)}"; 
        }

        public string SumOfDigitsOfPositiveInteger(int inputInteger)
        {
            char[] transformedString = Convert.ToString(inputInteger).ToCharArray();
            int resultedTotal = 0;
            foreach(char item in transformedString)
                resultedTotal = resultedTotal + item;

            return $"Given Int total is {resultedTotal}";
        }

        public string[] UniqueNames(string[] names1, string[] names2)
        {
            List<string> finalResult = new List<string>();

            foreach (var item in names1)
                finalResult.Add(item);

            foreach (var item in names2)
                finalResult.Add(item);

            finalResult = finalResult.Distinct().ToList();

            string[] newStringList = new string[finalResult.Count];
            for (int i = 0; i < finalResult.Count; i++)
                newStringList[i] = finalResult[i];

            return newStringList;
        }

        /// <summary>
        /// Make an Unique list of integers 
        /// for example if input is {1,2,2,3,4,5} 
        /// then output is {1,2,6,3,4,5}
        /// </summary>
        /// <param name="arr"></param>
        public void MakeListUnique(List<int> arr)
        {
            int minSum = 0;
            arr.Sort();
            int j = 0;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] != arr[j])
                {
                    minSum = arr.Sum();
                    j = i;
                }
                else
                {
                    arr[i] = arr[i] + 1;
                    arr.Sort();
                    minSum = arr.Sum();
                    j++;
                }
            }


            Console.WriteLine(minSum);

            //return IntArray;
        }

        /// <summary>
        /// Even- Odd Operations from LeetCode
        /// https://leetcode.com/discuss/interview-question/452872/mapbox-hackerrank
        /// </summary>
        /// <param name="IntArray"></param>
        /// <returns></returns>
        public int SumOfIntegerArray(List<int> IntArray)
        {
            int finalVal = 0;
            bool isOdd = true;
            int totalElementsInArr = IntArray.Count;

            for (int i = 0; i < totalElementsInArr; i++)
            {
                if (isOdd)
                {
                    finalVal += IntArray.Sum();
                    IntArray = filteredArray(IntArray);
                    isOdd = false;

                }
                else
                {
                    finalVal -= IntArray.Sum();
                    IntArray = filteredArray(IntArray);
                    isOdd = true;
                }

            }
            return finalVal;
        }

        private List<int> FilteredArray(List<int> IntArray)
        {
            if (IntArray.ElementAt(0) < IntArray.ElementAt(IntArray.Count - 1))
                IntArray.RemoveAt(IntArray.Count - 1);
            else
                IntArray.RemoveAt(0);


            return IntArray;
        }

        public  List<int> BinarySortingAlg(List<int> intArr)
        {
            int sizeOfInput = intArr.Count;
            List<int> finalOut = new List<int>();
            //int[,] sortedArray = new int[sizeOfInput, sizeOfInput];
            //for(int i=0; i< sizeOfInput; i++)
            //{
            //    sortedArray[i,0] = intArr[i];
            //    sortedArray[i,1] = countSetBits(intArr[i]);
            //}
            //sortedArray
            //List<KeyValuePair<int, int>> sortedValue = new List<KeyValuePair<int, int>>();
            // for (int i = 0; i < sizeOfInput; i++)
            // {
            //     sortedValue.Add(new KeyValuePair<int, int>( intArr[i], countSetBits(intArr[i]) ));
            // }
            // sortedValue.Sort(x => x.Value)/
            //var descendingComparer = Comparer<int>.Create((x, y) => y.CompareTo(x));
            SortedList<int, int> sortedListVal = new SortedList<int, int>();
            for (int i = 0; i < sizeOfInput; i++)
                sortedListVal.Add(intArr[i], countSetBits(intArr[i]));

            for (int i = 0; i < sizeOfInput; i++)
            {
                int currentMaxVal = sortedListVal.Values.Max();
                int currentMaxValIndex = sortedListVal.IndexOfValue(currentMaxVal);
                finalOut.Add(sortedListVal.Keys[currentMaxValIndex]);
                sortedListVal.RemoveAt(currentMaxValIndex);
            }


            return null;

        }
        static int countSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    }
}
