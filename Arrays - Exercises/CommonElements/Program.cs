using System;
using System.Linq;

namespace CommonElements
{
    internal class Program
    {
        static void Main()
        {
            string[] firstArray, secondArray;
            string[] separator = { " " };
            firstArray = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            secondArray = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        Console.Write(secondArray[i] + " ");
                    }
                }

            }
        }
    }
}

