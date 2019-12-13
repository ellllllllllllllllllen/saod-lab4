using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Кол-во эл-тов массива: "+ number);
            int[] array = new int[number];
            Random rand = new Random();
            for (int i = 1; i < number; i++)
                array[i] = rand.Next(-100, 100);
            Console.WriteLine("Исходный массив: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

           

            int count = 0;
            for (int i = 1; i < number; i++)
                for (int j = i + 1; j < number; j++)
                    if (array[i] > array[j])
                    {
                        int temp2 = array[i];
                        array[i] = array[j];
                        array[j] = temp2;
                        count++;
                    }
            Console.WriteLine("\nОтсортированный массив: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nКоличество операций перестановки: {0}", count);


            int count2 = 0;
            int temp = array.Max();
            for (int i = 0; i < number; i++)
            {
                count2++;
                if (temp == array[i])
                {
                    Console.WriteLine("Наибольший элемент массива: " + temp);
                    Console.WriteLine("Количество операций сравнения в линейном поиске: " + count2);
                }

            }
            int searchValue = array.Max();
            int count3 = 0;
            int low = 0;
            int high = number;
            int mid;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (searchValue == array[mid])
                {
                    Console.WriteLine("Наибольший элемент массива: " + searchValue);
                    count3++;
                    break;
                }
                else if (searchValue > array[mid])
                {
                    low = mid + 1;
                    count3++;
                }
                else
                {
                    high = mid - 1;
                    count3++;
                }
            }
            Console.WriteLine("Количество операций сравнения в бинарном поиске: " + count3);
        }
    }
}
