using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {

			//Practice.B6_P1_6_1DReadConsoleMassive();
			//Practice.B6_P2_6_3DMassiveMaxInRow();
			//Practice.B6_P3_6_1DMasiveSort();
			//Practice.B6_P4_6_Pyatnashki();
			//Practice.B6_P5_6_CutString();
			Practice.B6_P6_6_ReplaceInPoem();

			int[] massivSix = new[] { 1, 2, 3, 4, 5, 6 };
			for (int i = 0; i < massivSix.Length; i++)
			{
				Console.WriteLine($"{massivSix[i]}");

			}
			Console.WriteLine(string.Join(", ", massivSix));

			for (int i = massivSix.Length - 1; i >= 0; i--)
			{
				Console.WriteLine($"{massivSix[i]}");

			}
			const int X_SIZE = 3;
			const int Y_SIZE = 4;
			Random rnd = new Random();
			int[,] table = new int[X_SIZE  ,Y_SIZE];// { { 1, 2, 3 }, { 4, 5, 6 }, { 7,8,9} }
			int tmp = 1;
			for(int i = 0; i < X_SIZE; i++)
			{
				for(int j = 0; j < Y_SIZE; j++)
				{
					table[i, j] = tmp; //rnd.Next(1, 100);
					tmp++;
				}
			}

			OutTable(table);
			TextGeneration();

			int temp = 0;
			for(int i  = 0; i<table.GetLength(0); i++)
			{
				
				for(int j = 0; j<table.GetLength(1); j++)
				{
					temp = 0;
					if (table[i,j] >= temp)
					{
						temp = table[i, j];
					}
					//Console.WriteLine(temp);

				}
			}
			Console.ReadLine();
		}
		public static void TextGeneration()
		{
			char[][] text = new char[100][];
			Random rnd = new Random();
			for(int i = 0; i<100; i++)
			{
				var word = new char[rnd.Next(10)];
				for(int j = 0; j < word.Length; j++)
				{
					word[j] = (char)rnd.Next(1039, 1103);
				}
				text[i] = word;
			}
			//Вывод используя цикл for
			/*
			for(int i = 0; i < text.Length; i++)
			{
				Console.WriteLine(text[i]);
			}
			*/
			//Вывод используя цикл foreach
			foreach (var word in text)
			{
				Console.WriteLine(word);
			}
		}

		
		public static void OutTable(int[,] table)			
		{
			for (int i = 0; i < table.GetUpperBound(0)+1; i++)
			{
				int temp3 = table.Length / table.GetUpperBound(0);
				for (int j = 0; j < (table.Length / (table.GetUpperBound(0)+1)); j++)
				{
					Console.Write($"{table[i, j],5}");
				}
				Console.WriteLine($"");
			}

		}
		
		public static void Pyatnashki()
        {
           

        }

        public static void PoemExample()
        {
            
        }
    }
}
