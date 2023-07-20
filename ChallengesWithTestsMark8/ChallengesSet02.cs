using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Any() == false)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            if ((str1 == null) || (str2 == null))
            {
                return 0;
            }

            if (str1.Count() < str2.Count())
            {
                return str1.Count();
            }

            if (str1.Count() > str2.Count())
            {
                return str2.Count();
            }
            
            if (str1.Count() == str2.Count()) 
            { 
                return str1.Count(); 
            }
            return 0;
        }

        public int Sum(int[] numbers)
        {
            int sumOfNumbers = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach (int num in numbers)
            {
                sumOfNumbers += num;
            }
            return sumOfNumbers;
        }

        public int SumEvens(int[] numbers)
        {
            int sumOfEvenNumbers = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int num in numbers)
            {
                if (IsNumberEven(num))
                {
                    sumOfEvenNumbers += num;
                }
            }
            return sumOfEvenNumbers;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sumOfNumbers = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (int num in numbers)
            {
                sumOfNumbers += num;
            }

            return IsNumberOdd(sumOfNumbers);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long sumOfNumbers = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    sumOfNumbers++;
                }
            }
            return sumOfNumbers;
        }
    }
}
