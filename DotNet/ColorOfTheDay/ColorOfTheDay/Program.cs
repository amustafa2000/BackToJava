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
		}
		/*
		 *	Assume today is Monday and company is making Red Cars 
		 *
		 */
		public static String color_of_the_day(int daysAfterToday)
		{
			String[] colorArray = new String[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };
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
			int daysAfterSevenDayPeriods = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
			int colorChangeDays = (daysAfterSevenDayPeriods) % 7;
			return colorArray[colorChangeDays];
		}
	}
}
