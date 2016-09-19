using System;

namespace ColorOfTheDay
{
	public class ColorOfTheDayTest
	{
		public static void Main(string[] args)
		{
			try
			{
				int daysAfterToday = Int32.Parse(args[0]);
				string color = color_of_the_day(daysAfterToday);
				Console.WriteLine("Color after {0} day will be {1}", daysAfterToday, color);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			//Example Run from 0 (the same) day to 20
			for (int i = 0; i <= 20; i++)
			{
				Console.WriteLine("Color after {0} day will be {1}", i, color_of_the_day(i));
			}
			//Enable user to see the resutls
			Console.WriteLine("Press any key to exit the program");
			Console.ReadKey();
		}
		/*
		 *	Assume today is Monday and company is making Red Cars 
		 *
		 */
		public static string color_of_the_day(int daysAfterToday)
		{
			string[] colorArray = new string[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };
			//Throw exception for -ve
			if (daysAfterToday < 0)
			{
				throw new Exception("daysAfterToday cannot be negative");
			}
			// Saturday or Sun day
			if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6)
			{
				return "No Color";
			}
			int numOfSevenDayPeriod = (daysAfterToday) / 7;
			int totalWorkDays = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
			int colorChangeDays = (totalWorkDays) % 7;// As there are seven colors
			return colorArray[colorChangeDays];
		}
	}
}
