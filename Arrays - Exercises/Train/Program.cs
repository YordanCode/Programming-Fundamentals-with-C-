using System;

namespace Train
{
    internal class Program
    {
        static void Main()
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] wagons;
            wagons = new int[numberOfWagons];

            int totalPeople = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                int countPeopleInWagon = int.Parse(Console.ReadLine());
                wagons[i] = countPeopleInWagon;
                totalPeople += countPeopleInWagon;
                Console.Write(wagons[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPeople);
        }
    }
}
