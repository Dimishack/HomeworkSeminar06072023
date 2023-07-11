using System;

namespace HomeworkSeminar06072023
{
    /*
     * Задача 38: Задайте массив вещественных чисел. 
     * Найдите разницу между максимальным и минимальным элементов массива.
     * [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
     */
    internal class Task38
    {
        internal static void DifferenceMaxMin()
        {
            Random rnd = new Random();
            double max = 0.0, min = 0.0;
            var array = new double[10];

            Console.Write("Массив вещественных чисел: \n[");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(rnd.NextDouble() * Math.Exp(rnd.Next(1, 4)), 2);
                if (i == 0)
                    max = min = array[i];
                else
                    if (max < array[i])
                    max = array[i];
                    else if (min > array[i])
                    min = array[i];
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("] \nРазница между максимальным ({0}) и минимальным ({1}) значением = {2}",
                max, min, Math.Round(max - min, 2));
        }
    }
}
