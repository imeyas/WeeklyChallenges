using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            vals = new bool[vals.Length];

            if(vals.Contains(false))
            {
                return true;
            }
            return vals.Contains(true);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            numbers = new List<int>(numbers);


            var result = (numbers.Sum() % 2 != 0) ? true : false;
            return result;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isUpper = false;
            var isLower = false;
            var isNumber = false;

            for (var i = 0; i < password.Length; i++)
            {
                if(char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    isNumber = true;
                }

            }
            
            if (isUpper == true && isLower == true && isNumber == true)
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

            char firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char lastLetter = val[val.Length - 1];

            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            decimal quotient = dividend / divisor;
            return quotient;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            int counter = 0;
            for (int i = 1; i < 100; i += 2)
            {
                odds[counter] = i;
                counter++;
            }

            return odds;
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
