using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int positivecount = 0;
            int negativecount = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                    positivecount += item;
                else if (item % 2 != 0)
                    negativecount -= item;
            }

            return positivecount + negativecount;
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string>();
            stringList.Add(str1);
            stringList.Add(str2);
            stringList.Add(str3);
            stringList.Add(str4);
            stringList.Sort((a,b) => a.Length.CompareTo(b.Length));
            return stringList[0].Length;


            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>();
            intList.Add(number1);
            intList.Add(number2);
            intList.Add(number3);
            intList.Add(number4);
            return intList.Min();

            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
                return true;
            else
                return false;
            
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            if (input == null  ||  input.Any(char.IsLetter) || input.Any(x => !char.IsDigit(x)))
                return false;
            else if (input.Contains('*') || input.Contains('#'))
                return false;

            
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;
            int othersCounter = 0;
            
            foreach (object item in objs)
            {
                if (item == null)
                    nullCounter++;
                else
                    othersCounter++;
            }
            if (nullCounter > othersCounter)
                return true;
            else if (nullCounter <= othersCounter)
                return false;

            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            var collector = numbers.Where(i => i % 2 == 0);

            if (collector.Count() == 0)
                return 0;
            else
                return collector.Average();

                
            
            
            
        }
            
        public int Factorial(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            else if (number < 0)
                throw new ArgumentOutOfRangeException();
            else
                return number * Factorial(number - 1);
            
            
            
            
        }
    }
}
