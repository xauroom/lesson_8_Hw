// Задача 60. Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;

public static class Program
{
	public static void Main()
	{
		void FillArray(int[,,] array)
		{
			int[] num = new int[90];
			for (int i = 0; i < 90; i++) num[i] = 0;
			int cnt = 0;
			int rand;
			for (int i = 0; i < array.GetLength(0); i++)
				for (int j = 0; j < array.GetLength(1); j++)
					for (int k = 0; k < array.GetLength(2); k++)
					{
						rand = new Random().Next(10, 99);
						bool isExist = true;
						for (int m = 0; m < 90; m++)
						{
							if (rand != num[m]) isExist = false;
						}
						if (!isExist)
						{
							array[i, j, k] = rand;
							num[cnt] = rand;
							cnt++;
						}
						else k--;
					}
		}

		void PrintArray(int[,,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(1); j++)
				{
					string s = "";
					for (int k = 0; k < array.GetLength(2); k++)
						s += (array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
					System.Console.WriteLine(s);
				}
				System.Console.WriteLine("");
			}
		}

		Console.Clear();
		System.Console.WriteLine("Введите размер 3-мерного массива (2, 3 или 4)");
		int dim = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("");
		int[,,] array = new int[dim, dim, dim];
		FillArray(array);
		PrintArray(array);
	}
}
