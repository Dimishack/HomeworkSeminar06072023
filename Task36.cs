using System;

namespace HomeworkSeminar06072023
{
    /*
     * Задача 36: Задайте одномерный массив, заполненный случайными числами. 
     * Найдите сумму элементов, стоящих на нечётных позициях.
     * [3, 7, 23, 12] -> 19
     * [-4, -6, 89, 6] -> 0
     */
    internal class Task36
    {
        internal static void SumNumOvenPosition()
        {
            Random random = new();
            int sum = 0;
            var array = new int[10];

            Console.Write("Массив: \n[");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101);
                if (i % 2 == 1) sum += array[i];
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("] \nСумма чисел, стоящих на нечетных позициях: " + sum);
        }
    }
}
