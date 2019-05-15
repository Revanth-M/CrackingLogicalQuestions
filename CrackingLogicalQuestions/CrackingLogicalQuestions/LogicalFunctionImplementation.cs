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
    }
}
