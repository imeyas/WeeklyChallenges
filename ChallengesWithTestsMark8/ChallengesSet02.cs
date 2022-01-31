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
           

            //throw new NotImplementedException();
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


            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 1 || num % 2 < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();

            double max = 0;
            double min = 10000;

            if (numbers == null)
            {
                return 0;
            }


            foreach ( double number in numbers)
            {
                if(number > max)
                {
                    max = number;
                }
            }

            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

                return min + max;

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();

            if(str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            


        }

        public int Sum(int[] numbers)
        {
                //throw new NotImplementedException();

                var sum = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach (int number in numbers)
                if (number >= 0)
                {
                    sum += number;
                }
               
            foreach (int number in numbers)
                if (number < 0)
                {
                    sum += number;
                }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null)
            {
                return 0;
            }

            var evensSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evensSum += numbers[i];
                }
            }

            return evensSum;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();

            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
