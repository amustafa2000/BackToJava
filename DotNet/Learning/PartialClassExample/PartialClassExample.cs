#define ZZTOP
#undef ZZTOP
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
	class PartialClassExample
	{
		const int constInt = 0;
		static void Main(string[] args)
		{
			int x = constInt + 3;
#if(ZZTOP)
			x =10;
#elif(ITSTWO)// in conditional compiling symbol
			x = 20;
#else
			x = 30;
#endif
			Employee myemployee = new Employee();
			myemployee.DoWork();
			myemployee.GoToLunch();
		}
	}
	public partial class Employee
	{
		public void DoWork()
		{
		}
	}

	public partial class Employee
	{
		public void GoToLunch()
		{
		}
	}
}
