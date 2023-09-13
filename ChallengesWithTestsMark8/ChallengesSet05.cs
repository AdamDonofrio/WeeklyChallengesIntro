using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int i = 1;
            do 
            {
                if ((startNumber + i) % n == 0)
                {
                    return startNumber + i;
                }
                i++;

            } while (true);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sumResult = 0;
            int test;
            for(var i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0 && (i + 1) != numbers.Length)
                {
                    test = numbers[i + 1];
                    sumResult += numbers[i + 1];
                    
                }
            }
            return sumResult;
        }

        public string TurnWordsIntoSentence(string[] words)           
        {

            if (words == null || words.Length == 0)
            {
                return "";
            }

            string returnString = "";

            foreach(string word in words)
            {
                if(word.Trim().Length > 0)
                {
                    returnString += word.Trim() + " ";
                }
                
            }

            if(returnString.Length == 0)
            {
                return "";
            }

            returnString = returnString.Trim();
            returnString += '.';

            return returnString;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null)
            {
                return Array.Empty<double>();
            }
            double[] result = new double[(int)(elements.Count / 4)];
           
            int j = 0;
            for(var i = 0; i < elements.Count;i++)
            {

                if ((i + 1) % 4 == 0)
                {
                    
                    result[j] = elements[i];
                    j++;
                }
            }

            //double[] result = new double[elements.Count];

            return result;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if(nums == null || nums.Length == 0) { return false; }

            if(nums.Length == 1)
            {               
                return false;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber && i != j)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }
    }
}
