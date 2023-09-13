using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            foreach (var item in words)
            {
                if (ignoreCase)
                {
                    if (item.ToLower().Contains(word.ToLower())) 
                    { 
                            return true;
                    }
                }
                else
                {
                    if(item ==  word)
                    {
                        return true;
                    }
                }
            }
            return false;
            
            /*for(var i = 0; i < words.Count(); i++)
            {
                if (ignoreCase)
                {
                    if (words[i].ToLower().Contains(word.ToLower())) { }
                }
            }*/
            
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 2) return true;

            if(num == 0 || num <= 1 || num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }         
            }
                

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            List<int> rowList = new List<int>();
            List<char> charList = new List<char>();
            char[] charArray = new char[str.Length];

            int index = -1;
            bool uindex;


            for (var i = 0; i < str.Length; i++)
            {
                uindex = true;
                for (var j = 0; j < str.Length; j++)
                {
                    
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if (uindex)
                {
                    index = i;
                }
            }
                return index;
        }

            
        

        public int MaxConsecutiveCount(int[] numbers)
        {

            int inARow = 0;
            List<int> rowList = new List<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                
                for (var j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        inARow++;
                    }
                    else
                    {
                        rowList.Add(inARow);
                        inARow = 0;
                    }
                }
            }
            return rowList.Max();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            

            double[] emptyResult = new double[0];
            List<double> doubleList = new List<double>();

            

            if(elements == null || n <= 0 || n > elements.Count)
            {
                return emptyResult;
            }

            for (var i = n - 1; i < elements.Count; i+=n)
            {
                //if(i == n)
                //{
                    doubleList.Add(elements[i]);
                //}
            }

            return doubleList.ToArray();
        }
    }
}
