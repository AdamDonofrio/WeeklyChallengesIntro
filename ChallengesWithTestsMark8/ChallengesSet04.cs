using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evenOddSum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenOddSum += num;
                }
                else
                {
                    evenOddSum -= num;
                }
            }
            return evenOddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var shortest = str1;
            var arr = new string[3];

            arr[0] = str2;
            arr[1] = str3;
            arr[2] = str4;  

            for (int i = 0; i < arr.Length; i++)
            {
                if (shortest.Length > arr[i].Length)
                {
                    shortest = arr[i];
                }
            }
            return shortest.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var shortest = number1;
            var arr = new int[3];

            arr[0] = number2;
            arr[1] = number3;
            arr[2] = number4;

            for (int i = 0; i < arr.Length; i++)
            {
                if (shortest > arr[i])
                {
                    shortest = arr[i];
                }
            }
            return shortest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            bool onlyNumber = true;
            var stringList = new List<char>();

            if (input == null || input == "")
            {
                return false;
            }

            for (int i = 0;i < input.Length; i++)
            {
                stringList.Add(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                var temp = char.IsNumber(input[i]);

                if (!char.IsNumber(input[i]))
                {
                    if(input[i] != '.'&& input[i] != '-')
                    {
                        onlyNumber = false;
                    }
                    
                }
            }
            return onlyNumber;
            
            // Teacher strat:
            //return double.TryParse(input, out double number);


        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullcount = 0;

            for (int i =0;i<objs.Length;i++)
            {
                if (objs[i] == null)
                {
                    nullcount++;
                }
            }

            if (((int)(objs.Length / 2)) < nullcount)
            {
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {
            int evenCount = 0;
            double averEvens = 0;

            if (numbers == null) { return 0; }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                    averEvens += num;
                }
            }

            if(evenCount != 0)
            {
                averEvens /= evenCount;
            }
            else
            {
                evenCount = 0;
            }

            return averEvens;
        }

        public int Factorial(int number)
        {
            var fact = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for(int i = number; i > 0; i--) 
            {
                fact *= i;
            }
            return fact;
        }
    }
}
