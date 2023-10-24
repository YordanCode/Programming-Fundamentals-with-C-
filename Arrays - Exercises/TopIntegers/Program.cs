using System;
using System.Linq;


namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { " " };
            int[] numbers = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[i] > numbers[j + i])
                    {
                        continue;
                    }
                    else
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
