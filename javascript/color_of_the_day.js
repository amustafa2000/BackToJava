function color_of_the_day(daysAfterToday){
    var colorArray = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black"];
    //Throw exception for -ve
    if (daysAfterToday < 0){
        throw new Error("daysAfterToday cannot be negative");
    }
    // Saturday or Sun day
    if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6){
        return "No Color";
    }
    var numOfSevenDayPeriod = Math.floor(daysAfterToday/7);
    var daysAfterSevenDayPeriods = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
    var colorChangeDays = (daysAfterSevenDayPeriods) % 7;
    return colorArray[colorChangeDays];
}
if(process.argv.length != 3){
    console.log("No value sent for days after");
}else{
    console.log("Color after "+ process.argv[2] +" day will be " + color_of_the_day(process.argv[2]));
}
