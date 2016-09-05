using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amdev.com
{
	class BoxingAndDynamic
	{
		static void Main(string[] args)
		{
			
			MySuperClass superClass = new MySuperClass(1);
			superClass.ChildrenDoIt(1);
			Console.WriteLine("superClass.day = " + superClass.day);
			MySubClass subClass = new MySubClass(2);
			subClass.ChildrenDoIt(2);
			// subClass.DynamicMethod(1);// NOT ALLOWED
			subClass.DynamicMethod(1, 3);
			subClass.DynamicMethod("Really", "x", "y", "z");
			subClass.DynamicMethod("Really", "x", "y", 1);
			MySuperClass fromSubClass = subClass;
			MySubClass sameSubClass = (MySubClass)fromSubClass;
			// *** dynamic
			// object x
			dynamic x = 1;
			Console.WriteLine("Type now = " + x.GetType());
			x = "x";
			Console.WriteLine("Type now = " + x.GetType());
			x = subClass;
			x.SubClassMethod();
			Console.WriteLine("Type now = " + x.GetType());
			sameSubClass.printMe();
			int xxxx = 2;
		}
	}
	public class MySuperClass
	{

		public enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat }; 
		public int id;
		public int day;
		public string dayString;
		public MySuperClass()
		{
		}
		public MySuperClass(int id)
		{
			this.id = id;
			this.day = (int)Days.Fri;
			//this.dayString = Days.Fri;
		}
		public virtual void ChildrenDoIt(int x)
		{
			Console.WriteLine("In Parent virtual method ");
		}
	}
	public class MySubClass : MySuperClass
	{
		public MySubClass()
		{
		}
		public MySubClass(int id)
		{
			base.id = id;
		}
		public void SubClassMethod()
		{
			var x = "";
		}
		public void TryEnumInhereit()
		{
			Console.WriteLine("Enumeration Cannot be inherited *******");
			//this.Days
			// Does not work
		}
		public void DynamicMethod(dynamic x, dynamic z, params dynamic [] xx)
		{
			Console.WriteLine("the type is = " + x.GetType());
			
		}
		public virtual void ChildrenDoIt(int x)
		{
			Console.WriteLine("In CHILDREN virtual method ");
		}
		public void printMe()
		{
			int x = 8;
			for (int i = 0; i <= 15; i++) {  
                if (i == 4) {  
                    continue;  
                }  
                Console.WriteLine("I = " + i);
				if (i == 10) break;
            }
			int xxx = 0;
		}
	}

}
