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
	}
}
