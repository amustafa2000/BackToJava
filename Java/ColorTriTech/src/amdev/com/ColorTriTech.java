package amdev.com;

public class ColorTriTech {

	public static void main(String[] args) {
		int daysAfterToday = 18;
		try {
			String color = color_of_the_day(daysAfterToday);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	public static String color_of_the_day(int daysAfterToday) throws Exception
	{
		String[] colorArray = new String[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };
		String colorAfterDays = "No Color";
		//Throw exception for -ve
		if (daysAfterToday < 0){
			throw new Exception("daysAfterToday cannot be negative");
		}
		// Saturday or Sun day
		if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6){
			return colorAfterDays;
		}
		int numOfSevenDayPeriod = (daysAfterToday) / 7;
		int daysAfterSevenDayPeriods = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
		int colorChangeDays = (daysAfterSevenDayPeriods) % 7;
		System.out.println("daysAfterToday = " + daysAfterToday);
		System.out.println("numOfSevenDayPeriod = " + numOfSevenDayPeriod);
		System.out.println("daysAfterSevenDayPeriods = " + daysAfterSevenDayPeriods);
		System.out.println("colorChangeDays = " + colorChangeDays);
		System.out.println("COLOR Using colorArray= " + colorArray[colorChangeDays]);
		return colorArray[colorChangeDays];
	}
}
