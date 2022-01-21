using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {

            var expectedDifference = minuend - subtrahend;
            return expectedDifference;


            //throw new NotImplementedException();
        }

        public int Add(int number1, int number2)
        {

            var expectedSum = number1 + number2;
            return expectedSum;

            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {

            if (number1 < number2)
            {
                return number1;
            }
            else if (number2 < number1)
            {
                return number2;
            }
            else if(number1 == number2)
            {
                return number2;
            }
           else
            {
                throw new ArgumentException();
            }

            //throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            var product = factor1 * factor2;
            //var product = Multiply(factor1, factor2); //Refactored code option not used
            return product;

            //throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return $"Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }

            //throw new NotImplementedException();
        }

        public string GetHey()
        {
            
            return $"HEY!";
            
            //throw new NotImplementedException();
        }
    }
}
