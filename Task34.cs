using System;

namespace HomeworkSeminar06072023
{
    /*
     * Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
     * Напишите программу, которая покажет количество чётных чисел в массиве.
     * [345, 897, 568, 234] -> 2
     */
    internal class Task34
    {
        internal static void QuantityEvenNum()
        {
            Random rnd = new();
            var quantity = 0;
            var array = new int[6];

            Console.Write("Массив из 3-значных чисел: \n[");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 999);
                if (array[i] % 2 == 0) quantity++;
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine("] \nКоличество четных чисел в массиве: " + quantity);
        }
    }
}
