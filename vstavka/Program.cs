using System;

namespace vstavka
{//сортировка вставками
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите размер массива:");
                int size = Convert.ToInt32(Console.ReadLine());
                var arr = new int[size];

                Console.WriteLine("Ввод массива");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                int j = 0, k = 0;

                for (int i = 1; i < arr.Length; i++)
                {
                    k = arr[i];
                    j = i - 1;

                    while (j >= 0 && arr[j] > k)
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = k;
                        j--;
                    }

                }

                Console.Write("Новый массив: ");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    
}
