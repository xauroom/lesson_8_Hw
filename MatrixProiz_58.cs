// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

public static class Program
{
	public static void Main()
	{
		void FillMatrix(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
				for (int j = 0; j < array.GetLength(1); j++)
					array[i, j] = new Random().Next(-10, 11);
		}

		void PrintMatrix(int[,] matr0, int[,] matr1)
		{
			for (int i = 0; i < matr0.GetLength(0); i++)
			{
				for (int j = 0; j < matr0.GetLength(1); j++)
					Console.Write($"{matr0[i,j],3}    ");
					Console.Write("|   ");
				for (int j = 0; j < matr0.GetLength(1); j++)
					Console.Write($"{matr1[i,j],3}    ");
				System.Console.WriteLine("");
			}
		}
		
		void MatrixProiz(int[,] m0, int[,] m1)
		{
			int[,] proiz = new int[m0.GetLength(0),m1.GetLength(1)];
			for (int i = 0; i < m0.GetLength(0); i++)
    		{
        		for (int j = 0; j < m1.GetLength(1); j++)
        		{	
					for (int k = 0; k < m0.GetLength(1); k++)
					proiz[i,j] += m0[i,k] * m1[k,j];
				}
			}
			int n = proiz.GetLength(0);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write($"{proiz[i, j], 7}");
				}
				Console.WriteLine();
			}
		}

		Console.Clear();
		System.Console.WriteLine("Введите размер матриц");
		int size = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("");
		int[,] matrix0 = new int[size, size];
		int[,] matrix1 = new int[size, size];
		FillMatrix(matrix0);
		FillMatrix(matrix1);
		PrintMatrix(matrix0,matrix1);
		System.Console.WriteLine("");	
		MatrixProiz(matrix0,matrix1);
	}
}
