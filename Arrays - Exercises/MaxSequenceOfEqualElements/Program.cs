using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers;

            numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int sequenceLenght = 1;
            int longestSequence = 1;
            int longestSequenceValue = 0;
            List<int> longestSequenceContent = new();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] == numbers[i])
                {
                    sequenceLenght += 1;
                }
                else
                {
                    sequenceLenght = 1;
                }

                if (sequenceLenght > longestSequence)
                {
                    longestSequence = sequenceLenght;
                    longestSequenceValue = numbers[i];
                    if (longestSequenceContent.Count > 0)
                        longestSequenceContent.Clear();
                    longestSequenceContent.AddRange
                        (Enumerable.Repeat(longestSequenceValue, longestSequence));
                }
            }

            foreach (var number in longestSequenceContent)
            {
                Console.Write(number + " ");
            }
        }
    }
}



