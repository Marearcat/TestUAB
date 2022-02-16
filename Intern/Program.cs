using System;
using System.Collections.Generic;

namespace Intern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create array
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 20);
                Console.Write(array[i] + " ");
            }

            //Create List for unique results
            List<Unique> results = new List<Unique>();

            results.Add(new Unique { value = array[0], count = 1});
            for (int i = 1; i < array.Length; i++)
            {
                if (results.Exists(x => x.value == array[i]))
                {
                    results.Find(x => x.value == array[i]).count++;
                }
                else
                {
                    results.Add(new Unique { value = array[i], count = 1 });
                }
            }

            foreach (Unique result in results.FindAll(x=> x.count == 1))
            {
                Console.WriteLine(result.value);
            }
        }

        class Unique
        {
            public int value;
            public int count;
        }
    }
}
