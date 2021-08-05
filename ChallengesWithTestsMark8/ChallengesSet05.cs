using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0 || startNumber % n == 0)
                startNumber++;

            while(startNumber%n!=0)
            {
                startNumber++;
            }
            return startNumber;
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var Business in businesses)
            {
                if(Business.TotalRevenue==0)
                {
                    Business.Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool returnValue = false;

           
            if (numbers == null || numbers.Length <= 0)
                return false;
            else if (numbers.Length == 1)
                return true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    returnValue = false;
                    break;
                }
                else if (numbers[i] <= numbers[i + 1])
                    returnValue = true;
            }
            return returnValue;
        }
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            for(int i =0; i<numbers.Length-1; i++)
            {
                if (numbers[i]%2==0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
                return "";
            if (words[0] == " " && words[1] == " ")
                return "";
            
            List<string> builderList = new List<string>();
            foreach (string c in words)
                builderList.Add(c);
            for (int i = 0; i < builderList.Count; i++)
            {
                builderList[i] = builderList[i].Trim();
            }
            builderList.RemoveAll(s => s == ","|| s=="" || s==" ");
            string secondStepString =string.Join(" ", builderList);
            StringBuilder builderString = new StringBuilder(secondStepString);
            builderString.Append(".");
            return builderString.ToString();








        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] emptyarray = new double[0];
            List<double> returnList = new List<double>();
            if (elements == null)
                return emptyarray;
            
            for (int i = 0; i < elements.Count; i++)
            {
                if((i+1)%4==0)
                {
                    returnList.Add(elements[i]);
                }
                
            }

            return returnList.ToArray();

            
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool returnCheck = false;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        returnCheck = true;   
                    }
                }
            }
            return returnCheck;
        }
    }
}
