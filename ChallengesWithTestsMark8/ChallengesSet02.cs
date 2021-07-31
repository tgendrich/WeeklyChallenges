using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            var result = Char.IsLetter(c);
            if (result == true)
                return true;
            else
                return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var a = vals.Count();
            if (a % 2 == 0)
                return true;
            else
                return false;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 != 0)
                return false;
            else
                return true;
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;

            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            if (numbers.Any())
            {
                var maxOfCollection = numbers.Max();
                var minOfCollection = numbers.Min();
                return maxOfCollection + minOfCollection;
            }
            
            else
                return 0;
            
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var lengthOfFirstString = str1.Count();
            var lengthOfSecondString = str2.Count();
            if (lengthOfFirstString < lengthOfSecondString)
                return lengthOfFirstString;
            else
                return lengthOfSecondString;
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else
            return numbers.Sum();
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            else if (numbers.Any())
            {
                var count = 0;
                foreach (var element in numbers)
                {

                    if (element % 2 == 0)
                    {
                        count += element;
                    }
                    continue;
                }
                return count;
                    
                    
                
            } 
            else
                return 0;
            
            
            
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            if (numbers.Any())
            {
                if (numbers.Sum() % 2 != 0)
                    return true;
                else
                    return false;

            }
            else
                return false;
            
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for (var i = number-1; i >= 0; i--)
            {
                if (i % 2 != 0)
                    count += 1;
                continue;
            }
            return count;

            
            //throw new NotImplementedException();
        }
    }
}
