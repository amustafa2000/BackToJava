using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrambleString
{
	class Program
	{
		static void Main(string[] args)
		{
			StringBuilder jumbleSB = new StringBuilder();
			jumbleSB.Append("ABC");
			for (int i = 0; i < jumbleSB.Length; i++)
			{
				
				Random random = new Random();
				int indexFirst = random.Next() % jumbleSB.Length;
				int indexNext = random.Next() % jumbleSB.Length;
				char temp = jumbleSB[indexFirst];
				jumbleSB[indexFirst] = jumbleSB[indexNext];
				jumbleSB[indexNext] = temp;


			}
			Console.WriteLine(jumbleSB);
			Console.ReadKey();
		}
	}
}
