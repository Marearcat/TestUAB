using System;

namespace Intern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 20);
                Console.Write(array[i] + " ");
            }
            System.Collections.ArrayList unique = new System.Collections.ArrayList();


        }
    }
}
