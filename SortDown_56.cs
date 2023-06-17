// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

		void SortDown(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{	
				for (int j = 0; j < array.GetLength(1); j++)
				{	
					int temp = array[0,i];
					for(int k=j+1; k<array.GetLength(1); k++)
					{
						if(array[i,k]>array[i,j])
						{
							temp = array[i,k];
							array[i,k] = array[i,j];
							array[i,j]=temp;
							
						}
						
					}
					Console.Write($"{array[i, j],3}    ");
				}
				Console.WriteLine("");
			}
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
		SortDown(array);
	}
}
