using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            int timesToRotate = rotations % array.Length;
            for (int i = 1; i <= timesToRotate; i++)
            {

                int firstElement = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }
                array[array.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", array));

        }
    }
}


