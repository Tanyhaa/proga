using System;

namespace vybor
{
    internal class Program
    {//сортировка выбором
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            var arr = new int[size];

            Console.WriteLine("Enter array:");
                for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = 0, j = 0, index = 0, swap = 0;

            for (int i = 0; i < size; i++)
            {
                min = int.MaxValue;
                while (j < size)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        index = j;
                    }
                    j++;
                }
                j = i + 1;
                swap = arr[i];
                arr[i] = min;
                arr[index] = swap;

            }

            Console.WriteLine("New array:");
            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }

        }
    }
        
    
}
