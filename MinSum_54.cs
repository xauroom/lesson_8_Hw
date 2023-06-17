// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов:
// 1 строка

using System;

public static class Program
{
	public static void Main()
	{
		void FillArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
				for (int j = 0; j < array.GetLength(1); j++)
					array[i, j] = new Random().Next(-30, 31);
		}

		void PrintArray(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
					Console.Write($"{array[i, j],3}    ");
				System.Console.WriteLine("");
			}
		}
		
		void MinSum(int[,] array)
		{
			int[] sum = new int[array.GetLength(0)];
			for (int i = 0; i < array.GetLength(0); i++)
			{
				sum[i] = 0;
				for (int j = 0; j < array.GetLength(1); j++)
				{
					sum[i] += array[i,j];
				}
			}
			int minSum = sum[0];
			int min = 0;
			for(int i = 0; i<array.GetLength(0); i++)
			{
				if(sum[i]<minSum)
				{
					min = i;
					minSum = sum[i];
				}
			}
			System.Console.WriteLine($"{min} строка");
		}
		
		Console.Clear();
		System.Console.WriteLine("Введите количество строк");
		int rows = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("Введите количество столбцов");
		int cols = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("");
		int[,] array = new int[rows, cols];
		FillArray(array);
		PrintArray(array);
		System.Console.WriteLine("");	
		MinSum(array);
	}
}
