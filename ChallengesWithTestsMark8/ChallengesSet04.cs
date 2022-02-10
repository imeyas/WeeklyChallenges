using System;
using System.Linq;
using System.Collections.Generic;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var count = 0;

           for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    count += numbers[i];
                }

                if (numbers[i] % 2 != 0)
                {
                    count -= numbers[i];
                }
            }
            return count;


        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            var stringList = new List<int>();
            stringList.Add(str1.Length);
            stringList.Add(str2.Length);
            stringList.Add(str3.Length);
            stringList.Add(str4.Length);

            return stringList.Min();


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var intList = new List<int>();
            intList.Add(number1);
            intList.Add(number2);
            intList.Add(number3);
            intList.Add(number4);

            return intList.Min();

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
                biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            else return false;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
                return false;

            double digi = 0.00;
            bool result;

            if (result = double.TryParse(input, out digi))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
                
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;

            var objMajority = (amount / 2) + 1;

            var count = 0;

            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            if (count >= objMajority)
            {
                return true;

            }
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double sum = 0;
            double count = 0;

            foreach (var number in numbers)
            {


                if(number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
                
            }

            if (count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }


        }

        public int Factorial(int number)
        {
            if( number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }

            int fact = number;
            for (int i = number -1; i > 1; i--)
            {
                fact = fact * i;
            }
            
            return fact;  
            
        }
    }
}
