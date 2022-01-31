using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
                else if (vals[i] == true)
                {
                    return false;
                }
                
            }

            foreach (bool val in vals)
            {
                if (val == false)
                { return true; }
                else if (val == true)
                { return false;}
            }

            return true;


            //for (int i = 0; i < 0; i++)
            //{
            //    if (vals[i] == true || vals[i] == false)
            //    {
            //        return vals[i];
            //    }
            //}
            //return true;
            //return false;

            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            foreach (int i in numbers)
            {
                int sum = 0;
                for (int j = 0; j < sum; j++)
                {
                    if (j % 2 != 0)
                    {
                        return true;
                    }
                    //else
                    //{ return true; }
                }
            }

            return false;
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();

            char firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();
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



            //try
            //{
            //    quotient = dividend / divisor;
            //    return quotient;
            //}
            //catch
            //{
            //    DivideByZeroException exception;
            //}
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();

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
            throw new NotImplementedException();
        }
    }
}
