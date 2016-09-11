using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			MySigneton ms = MySigneton.getInstance();
			Console.WriteLine("id ms = {0}", ms.GetId());
			MySigneton ms1 = MySigneton.getInstance();
			Console.WriteLine();
			Console.WriteLine("id ms = {0}", ms1.GetId());
			Console.WriteLine("ms1 == ms2 " + (ms1 == ms));
			int i = 0;
		}
	}

	public class MySigneton
	{
		private static MySigneton instance = null;
		private static int id = -1;
		private MySigneton()
		{
			MySigneton.id = 0;
		}
		public static MySigneton getInstance()
		{
			if (instance == null)
			{
				instance = new MySigneton();
				return instance;
			}
			MySigneton.id = MySigneton.id + 1;
			return instance;
		}
		public int GetId()
		{
			return id;
		}

	}
}
