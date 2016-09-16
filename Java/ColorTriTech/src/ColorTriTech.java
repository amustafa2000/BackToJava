public class ColorTriTech {

	public static void main(String[] args) {
		try {
			if(args.length!=1) throw new Exception("Please provide in Int");
			int daysAfterToday = Integer.parseInt(args[0]);
			String color = color_of_the_day(daysAfterToday);
			System.out.println("Color after "+ daysAfterToday +" day will be " + color);
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
	
	public static String color_of_the_day(int daysAfterToday) throws Exception{
		String[] colorArray = new String[] { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };
		//Throw exception for -ve
		if (daysAfterToday < 0){
			throw new Exception("daysAfterToday cannot be negative");
		}
		// Saturday or Sun day
		if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6){
			return "No Color";
		}
		int numOfSevenDayPeriod = (daysAfterToday) / 7;
		int daysAfterSevenDayPeriods = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
		int colorChangeDays = (daysAfterSevenDayPeriods) % 7;
		return colorArray[colorChangeDays];
	}
}
