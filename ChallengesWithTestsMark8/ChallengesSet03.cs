using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false) 
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumOfOdds = 0;

            if(numbers == null) { return false; }

            foreach(var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sumOfOdds += num;
                }
            }

            if(sumOfOdds % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool hasNumber = false;

            foreach(char val in password)
            {
                if (char.IsUpper(val))
                {
                    upper = true;
                }
                else if (char.IsLower(val))
                {
                    lower = true;
                }
                else if (char.IsNumber(val))
                {
                    hasNumber = true;
                }
            }
            if (upper && lower && hasNumber)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null) { return 0; }

            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            
            var oddsBelow100 = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsBelow100.Add(i);
                } 
            }
            return oddsBelow100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
