using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            {
                
                startNumber++;
            } while (startNumber % n != 0);
            return startNumber;
        }
        

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business bus in businesses)
            {
                if (bus.TotalRevenue <= 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
                return 0;

            var count = 0;
            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    count += numbers[i + 1];
                }
                    
            }
            return count;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) { return ""; }
            var answer = "";
            var space = " ";
            var period = ".";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                    answer = answer.Trim() + space + words[i].Trim() + space;

            }
            if (answer == "  ")
            { return ""; }
            else
            { return answer.Trim() + period; }

        }


        public double[] GetEveryFourthElement(List<double> elements)
        {
            var list = new List<double>();

            if(elements is null)
            {
                return list.ToArray();
            }

            for (int i = 3; i < elements.Count; i +=4)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length;i++)
            {
              
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
                
                
            }
            return false;
        }
    }
}
