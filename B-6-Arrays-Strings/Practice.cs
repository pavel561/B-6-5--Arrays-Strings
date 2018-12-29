using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
	class Practice
	{
		static public void B6_P1_6_1DReadConsoleMassive()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B6_P1_6_1DReadConsoleMassive");
			Console.WriteLine("Программа выводит на экран элементы одномерного массива");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			const int ARRAY_SIZE = 6;
			int[] array = new int[ARRAY_SIZE];
			for(int i = 0; i < array.Length; i++)
			{
				Console.Write($"Ввведите {i+1}-й элемент массива из {array.Length}  >> ");
				array[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine();
			Console.Write($" Результат ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i],3}");
			}		
			Console.ReadLine();
		}

		static public void B6_P2_6_3DMassiveMaxInRow()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B6_P2_6_3DMassiveMaxInRow");
			Console.WriteLine("Программа выводит на экран элементы двухмерного массива");
			Console.WriteLine("а также максимальные значения элементов в каждой строке");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			const int X_SIZE = 3;
			const int Y_SIZE = 3;
			//int[,] table = new int[X_SIZE, Y_SIZE] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };	//Заполняем таблицу при объявлении
			int[,] table = new int[X_SIZE, Y_SIZE];
			Random rnd = new Random();
			// Заполняем таблицу через Random
			for( int i = 0; i < X_SIZE; i++ )
			{
				for(int j = 0; j < Y_SIZE; j++)
				{
					table[i, j] = rnd.Next(1, 100);
				}
			}
			Console.WriteLine("Двухмерный массив ");
			//Выводим таблицу
			for (int i = 0; i < X_SIZE; i++)
			{
				for (int j = 0; j < Y_SIZE; j++)
				{
					Console.Write($"{table[i, j],5}");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			//Ищем максимальное значение в строках
			for (int i = 0; i < X_SIZE; i++)
			{
				int maxValue = 0;
				for (int j = 0; j < Y_SIZE; j++)
				{
					if(maxValue < table[i,j])
					{
						maxValue = table[i, j];
					}
				}
				Console.WriteLine($"Максимальное значение в {i+1}-й строке - {maxValue}");
			}
			Console.ReadLine();
		}

		static public void B6_P3_6_1DMasiveSort()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B6_P3_6_1DMasiveSort");
			Console.WriteLine("Программа сортирует элементы одномерного массива");
			Console.WriteLine("Массив заполняется с помощью класса Random");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================

			const int ARRAY_SIZE = 10;
			int[] array = new int[ARRAY_SIZE];
			Random rnd = new Random();
			//Инициальзируем элементы массива
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(1, 100);
			}
			//Выводим элементы массива в консоль
			Console.WriteLine($" Исходный массив ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i], 3}");
			}
			Console.WriteLine("");
			//Сортируем массив методом пузырька
			for (int iteration = 1; iteration < array.Length; iteration++)
			{
				for (int i = 0; i <= array.Length-1-iteration; i++)
				{
					if(array[i]>array[i+1])
					{
						int temp = array[i];
						array[i] = array[i + 1];
						array[i + 1] = temp;
					}
				}
			}
			//Выводим в консоль отсортированный массив
			Console.WriteLine($" Отсортированный массив ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write($"{array[i],3}");
			}
			Console.ReadLine();
		}
	}
}
