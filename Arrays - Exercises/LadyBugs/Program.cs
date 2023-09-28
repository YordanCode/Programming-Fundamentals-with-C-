using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] separator = { " " };

            int[] indexesWithLadyBugs = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).
            Select(int.Parse).ToArray();
            int[] initialField = new int[fieldSize];
            int[] ActivateIndexes(int[] field, int[] numberOfIndexes)
            {
                for (int i = 0; i < numberOfIndexes.Length; i++)
                {
                    int activeIndex = numberOfIndexes[i];
                    if (activeIndex < 0 || activeIndex > fieldSize - 1)
                        continue;
                    field[activeIndex] = 1;
                }
                return field;
            }
            initialField = ActivateIndexes(initialField, indexesWithLadyBugs);
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int ladyBugPosition = int.Parse(cmdArgs[0]);
                string ladyBugFlyDirection = cmdArgs[1];
                int ladyBugFly = int.Parse(cmdArgs[2]);
                Move(ladyBugPosition, ladyBugFlyDirection, ladyBugFly, initialField);
            }
            void Move(int currentPosition, string direction, int fly, int[] field)
            {
                int newIndex = currentPosition;
                if (currentPosition < 0 || currentPosition > field.Length - 1)
                {
                    return;
                }
                if (field[currentPosition] == 0)
                    return;
                if (fly == 0)
                    return;
                switch (direction)
                {
                    case "left": newIndex -= fly; break;
                    case "right": newIndex += fly; break;
                }
                if (newIndex < 0 || newIndex > field.Length - 1)
                {
                    field[currentPosition] = 0;
                    return;
                }
                if (direction == "left")
                {
                    if (field[newIndex] == 1)
                    {
                        for (int i = newIndex; i > -1; i -= fly)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                field[currentPosition] = 0;
                                break;
                            }
                            else if (i - fly < 0)
                            {
                                field[currentPosition] = 0;
                                break;
                            }
                            else if (field[i] == 1)
                                continue;
                        }
                    }
                    else
                    {
                        field[newIndex] = 1;
                        field[currentPosition] = 0;
                    }
                }
                else if (direction == "right")
                {
                    if (field[newIndex] == 1)
                    {
                        for (int i = newIndex; i <= field.Length - 1; i += fly)
                        {
                            if (field[i] == 0)
                            {
                                field[i] = 1;
                                field[currentPosition] = 0;
                                break;
                            }
                            else if (i + fly > field.Length - 1)
                            {
                                field[currentPosition] = 0;
                                break;
                            }
                            else if (field[i] == 1)
                                continue;
                        }
                    }
                    else
                    {
                        field[newIndex] = 1;
                        field[currentPosition] = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", initialField));
        }
    }
}






