using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubClassAndInterface
{
	public class SubClassAndInterfaceSORT
	{
		static void Main(string[] args)
		{
			//************** Here is an Example of Sorting using LINQ **************
			MyClassSub mcs1 = new MyClassSub();
			mcs1.Name = "mcs1";
			mcs1.Num = 1;
			MyClassSub mcs2 = new MyClassSub();
			mcs2.Name = "mcs2";
			mcs2.Num = 2;
			MyClassSub mcs3 = new MyClassSub();
			mcs3.Name = "mcs3";
			mcs3.Num = 3;
			List<MyClassSub> mcsList = new List<MyClassSub>();
			mcsList.Add(mcs1);
			mcsList.Add(mcs2);
			mcsList.Add(mcs3);

			// *** LINQ Sort by num acs
			mcsList = mcsList.OrderBy(item => item.Num).ToList();
			// *** LINQ sort by desc
			mcsList = mcsList.OrderByDescending(item => item.Num).ToList();

			// *** Old style
			mcsList.Sort(delegate(MyClassSub x, MyClassSub y)
			{
				return y.Num.CompareTo(x.Num);
			});

			InImpl inimpl = new InImpl();
			int result = inimpl.DoIt(5);
			int r2 = inimpl.DoIt2(6);
			MyInterface myInterface = new InImpl();
			myInterface.DoIt(5);
			int xx = 0;
		}
	}
	public interface MyInterface
	{
		int DoIt(int x);
	}
	public interface MyInterface2
	{
		int DoIt2(int x);
	}
	public class MyClass
	{
		public MyClass()
		{

		}

		public void MyClassMethod()
		{
		}
	}
	public class MyClassSub : MyClass
	{
		private int num;
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Num
		{
			get { return num; }
			set { num = value; }
		}
		public MyClassSub()
		{
			
		}

		public void MyClassMethodSub()
		{
		}
	}
	public class InImpl:MyInterface, MyInterface2
	{
		public int DoIt(int x)
		{
			return x + 1;
		}
		public int DoIt2(int x)
		{
			return x + 2;
		}
	}
}
