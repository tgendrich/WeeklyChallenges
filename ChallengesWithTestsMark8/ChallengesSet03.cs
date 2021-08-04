using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            Array.Sort(vals);

            if (vals == null || vals.Length==0)
                return false;

            else if (vals[0] == false)
            {
                return true;
            }
            else
                return false;       
            
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sumer = 0;
            if (numbers == null)
                return false;
            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    sumer += i;
                }
                else
                    continue;
            }
            if (sumer % 2 != 0)
                return true;
            else
                return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit) == true)
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            
        }

        public char GetLastLetterOfString(string val)
        {
            var lastIndex = val.Length;
            return val[lastIndex-1];
            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            
            else
                return dividend / divisor;
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsBelow100 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                    continue;
                else
                    oddsBelow100.Add(i);
            }


            return oddsBelow100.ToArray();
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            
            
            
        }
    }
}
