using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            // lot of if statements- should see if we can get it down to just a few, maybe longer if conditionals?
            
            
            if (words == null)
                return false;
            
            if(ignoreCase==true)
            {
                foreach(var item in words)
                {
                    if (item == null)
                        return false;
                    else if (item.ToLower().Contains(word.ToLower()))
                        return true;
                }                    

            }
            
            foreach (var item in words)
            {
                if (item == null)
                    return false;
                else if (item.Contains(word))
                    return true;

            }
            return false;
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            
            if (num <= 1)
                return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;

            
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            /*
                256 represents the total number of chars that can be frequenced. the array freq allows one to add a
                numerical value to each character in the string. Since we want the last non repeated char,
                we count down instead of up in the second for loop to find the last instant of 1, or the last single unqiue character. 
                Run IndexOf in order to find the index, rather than the actual character.
            
             */
            
            
            int maxPossibleChars = 256;
            int[] freq = new int[maxPossibleChars];

           
            for (int i = 0; i < str.Length; i++)
                freq[str[i]]++;

        
            for (int i = str.Length - 1; i >= 0; i--)
            {

               
                char ch = str[i];

                
                if (freq[ch] == 1)
                {
                    
                    return str.IndexOf(ch);
                }

            }

            
            return -1;
        }
    

        public int MaxConsecutiveCount(int[] numbers)
        {
            int compareCount = 1;
            int count = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                compareCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        compareCount++;
                    }
                    else
                     break;
                }
                if(compareCount > count)
                {
                    count = compareCount;
                }
            }
            return count;
            throw new NotImplementedException();
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] emptyarray = new double[0];
            if (n < 0 || elements==null)
                return emptyarray;


            List<double> returnerList = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    returnerList.Add(elements[i]);
                }

            }

            return returnerList.ToArray();
        }
    }
}
