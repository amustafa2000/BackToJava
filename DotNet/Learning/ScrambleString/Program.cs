using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrambleString
{
	class Program
	{
        /*
         *  Developers should avoid a "method-level Random object" if the method is called repeatedly
         *  in the same time frame.
         *  Instead, calling the same Random (Example static) is a safer plan.
         * */
        static Random random = new Random();
        static void Main(string[] args)
		{
            int minValue = 0;
            int maxValue = 1000000000;
			StringBuilder jumbleSB = new StringBuilder();
			jumbleSB.Append("ABCDEFGH");
            
            for (int i = 0; i < jumbleSB.Length; i++)
			{
				int indexFirst = random.Next(minValue, maxValue) % jumbleSB.Length;
				int indexNext = random.Next(minValue, maxValue) % jumbleSB.Length;
				char temp = jumbleSB[indexFirst];
				jumbleSB[indexFirst] = jumbleSB[indexNext];
				jumbleSB[indexNext] = temp;
                //Console.WriteLine("Using String Buffer : " + jumbleSB);
            }
			Console.WriteLine("Using String Buffer : " + jumbleSB);

            String jumbleS = "ABCDEFGH";
            for (int i = 0; i < jumbleS.Length; i++)
            {
                int indexFirst2 = random.Next(minValue, maxValue) % jumbleS.Length;
                int indexNext2 = random.Next(minValue, maxValue) % jumbleS.Length;
                char temp2 = jumbleS[indexFirst2];
                if(indexFirst2 != jumbleS.Length -1)
                    jumbleS = jumbleS.Substring(0, indexFirst2)+ jumbleS[indexNext2] + jumbleS.Substring(indexFirst2+1);
                else
                    jumbleS = jumbleS.Substring(0, indexFirst2) + jumbleS[indexNext2];

                if (indexNext2 != jumbleS.Length - 1)
                    jumbleS = jumbleS.Substring(0, indexNext2) + temp2 + jumbleS.Substring(indexNext2 + 1);
                else
                    jumbleS = jumbleS.Substring(0, indexNext2) + temp2;

                //Console.WriteLine("Using String : " + jumbleS);

            }
            Console.WriteLine("Using String : " + jumbleS);
            Console.ReadKey();
		}
	}
}
