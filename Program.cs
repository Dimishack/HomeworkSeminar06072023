﻿using System;

namespace HomeworkSeminar06072023
{
    internal class Program
    {
        static void Main()
        {
			try
			{

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
                Console.WriteLine("\nНажмите любую клавишу для выхода из программы...");
				Console.ReadKey(true);
            }
        }
    }
}