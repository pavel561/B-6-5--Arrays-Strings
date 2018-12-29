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
		static public void B6_P4_6_Pyatnashki()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B6_P4_6_Pyatnashki");
			Console.WriteLine("Игра \"Пятнашки\"");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================

			Console.WriteLine("Для управления используйте клавиши");
			Console.WriteLine("W - Вверх, A - Влево, S - Вниз, D - Вправо");
			Console.WriteLine("Также, можно использовать стрелки ))");

			Console.WriteLine();
			Console.WriteLine("Для выхода из игры используйте клавишу \"Q\"");
			Console.WriteLine();
			Console.WriteLine("Для начала игры нажмите любую клавишу...");
			Console.ReadKey();
			Console.Clear();

			bool run = true;			//Флаг для остановки игры
			const int TABLE_HEIGHT = 4;	//Высота таблицы
			const int TABLE_WIDTH = 4;	//Ширина таблицы
			const int cellCount = TABLE_HEIGHT * TABLE_WIDTH;	//Количество ячеек таблицы
			int[,] table = new int[TABLE_WIDTH, TABLE_HEIGHT];	//Сама таблица
			Random rnd = new Random();	//Экземпляр рандома
			int nullPosition_x = 0;	//Текущее положение нуля в матрице
			int nullPosition_y = 0; //Текущее положение нуля в матрице

			//Создаем массив с числами от 1 до 15
			//а затем его перемешиваем
			int[] numbers = new int[cellCount - 1];	//Массив с числами
			for(int i = 0; i < cellCount-1; i++)	//Заполняем его
			{
				numbers[i] = i + 1;
			}
			//Этот кусок кода честно подсмотрел в интернете
			//Он перетусовывает массив чисел случайным образом
			int count = numbers.Length;
			while (count > 1)
			{
				count--;
				int k = rnd.Next(count + 1);
				var value = numbers[k];
				numbers[k] = numbers[count];
				numbers[count] = value;
			}

			//Заполняем таблицу числами из подготовленного массива
			int numberPosition = 0;
			for (int y = 0; y < TABLE_HEIGHT; y++)
			{
				for (int x = 0; x < TABLE_WIDTH; x++)
				{
					if(x==(TABLE_HEIGHT-1) && y==(TABLE_WIDTH-1))
					{
						//В последнюю ячейку записываем Нуль.
						table[x, y] = 0;
						nullPosition_x = x;
						nullPosition_y = y;
					}
					else
					{
						//В остальные ячейки пишем числа из массива
						//table[x, y] = rnd.Next(1, cellCount);	//Рандом генерил одинаковые числа, пришлось от него отказаться =(
						table[x, y] = numbers[numberPosition];
						numberPosition++;
					}
				}	
			}
			//Основной цикл, в котором  вертится вся логика программы
			while(run)
			{
				//Выводим таблицу в консоль
				for (int y = 0; y < TABLE_HEIGHT; y++)
				{
					for (int x = 0; x < TABLE_WIDTH; x++)
					{
						Console.Write($"{table[x, y],5}");
					}
					Console.WriteLine();
				}
				//Ждем нажатия кнопки и выполняем перемещения
				var pressedKey = Console.ReadKey(true).Key;
				switch (pressedKey)
				{
					case ConsoleKey.UpArrow:
					case ConsoleKey.W:
						{
							if (nullPosition_y > 0)
							{
								int temp = table[nullPosition_x, nullPosition_y - 1];
								table[nullPosition_x, nullPosition_y - 1] = table[nullPosition_x, nullPosition_y];
								table[nullPosition_x, nullPosition_y] = temp;
								nullPosition_y--;
							}
							break;
						}
					case ConsoleKey.LeftArrow:
					case ConsoleKey.A:
						{
							if(nullPosition_x > 0)
							{
								int temp = table[nullPosition_x - 1, nullPosition_y];
								table[nullPosition_x - 1, nullPosition_y] = table[nullPosition_x, nullPosition_y];
								table[nullPosition_x, nullPosition_y] = temp;
								nullPosition_x--;
							}
							break;
						}
					case ConsoleKey.DownArrow:
					case ConsoleKey.S:
						{
							if (nullPosition_y < TABLE_HEIGHT - 1)
							{
								int temp = table[nullPosition_x, nullPosition_y + 1];
								table[nullPosition_x, nullPosition_y + 1] = table[nullPosition_x, nullPosition_y];
								table[nullPosition_x, nullPosition_y] = temp;
								nullPosition_y++;
							}
							break;
						}
					case ConsoleKey.RightArrow:
					case ConsoleKey.D:
						{
							if (nullPosition_x < TABLE_WIDTH-1)
							{
								int temp = table[nullPosition_x + 1, nullPosition_y];
								table[nullPosition_x + 1, nullPosition_y] = table[nullPosition_x, nullPosition_y];
								table[nullPosition_x, nullPosition_y] = temp;
								nullPosition_x++;
							}
							break;
						}
					case ConsoleKey.Q:
						{
							run = false;
							Console.WriteLine("Выход из игры.");
							break;
						}
					default:
						{
							break;
						}
				}
				//Очищаем экран
				Console.Clear();
			}
			Console.ReadKey();
		}

		static public void B6_P5_6_CutString()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B6_P5_6_CutString");
			Console.WriteLine("Программа для обрезки введенной строки");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.Write("Введите предложение >> ");
			string inputMessage = Console.ReadLine();
			if(inputMessage.Length > 13)
			{
				string outputMessage = inputMessage.Substring(0, 13).Insert(13, "...");
				Console.WriteLine(outputMessage);
			}
			else
			{
				Console.WriteLine(inputMessage);
			}
			Console.ReadKey();
		}

		static public void B6_P6_6_ReplaceInPoem()
		{
			//=========================================================
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B6_P5_6_CutString");
			Console.WriteLine("Программа для разбиения строки на подстроки");
			Console.WriteLine("====================================");
			Console.WriteLine("");
			//=========================================================
			Console.WriteLine("Введите стихотворение, разделяя строки точкой с запятой");
			Console.Write(" >> ");
			string inputMessage = Console.ReadLine();			//Вводим стихотворение
			string[] poemArray = inputMessage.Split(';');		//Разбиваем его на подстроки
			for(int i = 0; i < poemArray.Length; i++)
			{
				poemArray[i] = poemArray[i].Replace('О', 'А');	//Заменяем буквы
				poemArray[i] = poemArray[i].Replace("Л", "ЛЬ"); //Заменяем сочетания
				poemArray[i] = poemArray[i].Replace("ТЬ", "Т"); //Заменяем сочетания
			}
			for (int i = 0; i < poemArray.Length; i++)
			{
				Console.WriteLine(poemArray[i]);                 //Выводим в консоль результат  построчно
			}
			Console.ReadKey();
		}
	}
}
