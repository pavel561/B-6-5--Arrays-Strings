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
			int[] massivSix = new[] { 1, 2, 3, 4, 5, 6 };
			for(int i=0;i<massivSix.Length;i++)
			{
				Console.WriteLine($"{massivSix[i]}");

			}
			Console.WriteLine(string.Join(", ", massivSix));
            
			for (int i = massivSix.Length - 1; i >= 0; i--)
			{
				Console.WriteLine($"{massivSix[i]}");

			}
			Console.ReadLine();
		}

        public static void Pyatnashki()
        {
           

        }

        public static void PoemExample()
        {
            
        }
    }
}
