using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorOfTheDay
{
	public class Program
	{
		public static void Main(string[] args)
		{
			int daysAfterToday = 18;
			try
			{
				string color = color_of_the_day(daysAfterToday);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		/*
		 *	Assume today is Monday and company is making Red Cars 
		 *
		 */
		public static String color_of_the_day(int daysAfterToday)
		{
			/*Dictionary<int, string> colorDict = new Dictionary<int, string>();
			colorDict.Add(0, "Red");
			colorDict.Add(1, "Orange");
			colorDict.Add(2, "Yellow");
			colorDict.Add(3, "Green");
			colorDict.Add(4, "Blue");
			colorDict.Add(5, "Purple");
			colorDict.Add(6, "Black");*/

			String[] colorArray = new String[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };

			String colorAfterDays = "No Color";
			//Throw exception for -ve
			if (daysAfterToday < 0)
			{
				throw new Exception("daysAfterToday cannot be negative");
			}

			// Saturday or Sun day
			if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6)
			{
				return colorAfterDays;
			}

			int numOfSevenDayPeriod = (daysAfterToday) / 7;
			int daysAfterSevenDayPeriods = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
			int colorChangeDays = (daysAfterSevenDayPeriods) % 7;
			Console.WriteLine("daysAfterToday = " + daysAfterToday);
			Console.WriteLine("numOfSevenDayPeriod = " + numOfSevenDayPeriod);
			Console.WriteLine("daysAfterSevenDayPeriods = " + daysAfterSevenDayPeriods);
			Console.WriteLine("colorChangeDays = " + colorChangeDays);
			/*Console.WriteLine("COLOR Using Dictionary= " + colorDict[colorChangeDays]);*/
			Console.WriteLine("COLOR Using colorArray= " + colorArray[colorChangeDays]);
			return colorAfterDays;
		}
	}
}
