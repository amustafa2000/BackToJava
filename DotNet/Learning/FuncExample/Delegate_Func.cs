using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndFunc
{
	class DelegateAndFunc
	{
		// ** A delegate can be seen as a placeholder for a/some method(s).
		public delegate int AddOne(int somthing);
		public delegate int AddTwoNumbers(int somthing, int something2);
        public sealed class Circle
        {
            private double radius =5;

            public double Calculate(Func<double, double> op)
            {
                return op(radius);
            }
        }

        static IEnumerable<int> FilterEven(List<int> anIntegerList)
		{
			int total = 0;
			foreach (int i in anIntegerList)
			{
				if (i % 2 == 0)
				{
					yield return i;
				}
                else
                {
                    total = total + i;
                }
			}
			Console.WriteLine("Total ODD = " + total);
		}
        static void Main(string[] args)
		{
            // Reverse a string
            string toReverse = "abcd";
            // Array.Reverse
            char[] tra = toReverse.ToArray();
            Array.Reverse(tra);
            //Normal
            StringBuilder sb = new StringBuilder();
            for (int i = toReverse.Length-1; i > -1; i--)
            {
                sb.Append(toReverse[i]);
            }

            Console.WriteLine(sb.ToString());

            // Sum all the even numbers of any arrary using ****YEILD****
            int[] anIntegerArray = { 1,2,3,4};
            List<int> anIntegerList = anIntegerArray.ToList<int>();

            int sumTotalEven = 0;
            foreach (int i in FilterEven(anIntegerList))
            {
                sumTotalEven = sumTotalEven + i;
            }
            Console.WriteLine("Total EVEN = " + sumTotalEven);

            Circle c = new Circle();
            Func<double, double> fff = theDouble => theDouble;
            var radius = c.Calculate(r => r);

            Func<int, int, string> funcAddTwoIntsLambda = (numberOne, numberTwo) => (numberOne + numberTwo).ToString();
            Console.WriteLine("Func using Lamda " + funcAddTwoIntsLambda(1, 3));

            Func<int, int, string> funcAddTwoIntsDelegate = delegate (int numberOne, int numberTwo) {
                return (numberOne + numberTwo).ToString();
            };
            Console.WriteLine("Func using Delegate " + funcAddTwoIntsDelegate(1, 3));

            Func<int, int> funcAddOne = theInt => theInt + 1;
			Console.WriteLine("xxxxxxxxxxx " + funcAddOne(2));

            Func<int, int, int, int> funcThreeInputs = (x, y, z) => x + y + z + 1;
            Console.WriteLine("funcThreeInputs = " + funcThreeInputs(1,2,3));
            Action<int, int, int, int> funcThreeInputsNoOutputs = (x, y, z,zz) => Console.WriteLine("No output actions = " + x+y+z +zz);
            funcThreeInputsNoOutputs(1,2,3,4);

            AddOne  addOne = AddOneActual;
			Console.WriteLine("Actual " + AddOneActual(2));
			Console.WriteLine("Actual " + addOne(2));

			AddOne addOne2 = AddOneWrong;
			Console.WriteLine("Wrong " + addOne2(2));
			Console.WriteLine("Wrong " + AddOneWrong(2));

			Func<string, int, int> anotherTest = delegate(string x, int someIntx)
			{
				int xxxxxxx = AddOneActual(3);
				return someIntx + 4;
			};
			Console.WriteLine("delegate XX " + anotherTest("", 2));
			
			AddTwoNumbers addTwoNUmbers = AddTwoNumbersImpl;
			Console.WriteLine("delegate AddTwoNumbersImpl " + addTwoNUmbers(3, 2));

			Console.ReadKey();
		}

		public static int AddOneActual(int something)
		{
			
			return something +1;
		}
		public static int AddOneWrong(int something)
		{
			return something + 2;
		}
		public static int AddTwoNumbersImpl(int something, int something2)
		{
			return something + something2;
		}
	}
}
