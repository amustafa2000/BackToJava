// Load the http module to create an http server.
var http = require('http');
var x = "3";
var y = 2;

// Configure our HTTP server to respond with Hello World to all requests.
var server = http.createServer(function (request, response) {
  response.writeHead(200, {"Content-Type": "text/plain"});
  response.end("Hello World\n");
  console.log("0 = " + color_of_the_day(0));
  console.log("1 = " + color_of_the_day(1));
  console.log("2 = " + color_of_the_day(2));
  console.log("3 = " + color_of_the_day(3));
  console.log("4 = " + color_of_the_day(4));
  console.log("5 = " + color_of_the_day(5));
  console.log("6 = " + color_of_the_day(6));
  console.log("7 = " + color_of_the_day(7));
  console.log("8 = " + color_of_the_day(8));
  console.log("9 = " + color_of_the_day(9));
  console.log("10 = " + color_of_the_day(10));
  console.log("11 = " + color_of_the_day(11));
  console.log("12 = " + color_of_the_day(12));
  console.log("13 = " + color_of_the_day(13));
  console.log("14 = " + color_of_the_day(14));
  console.log("15 = " + color_of_the_day(15));
  console.log("16 = " + color_of_the_day(16));
  console.log("17 = " + color_of_the_day(17));
  console.log("18 = " + color_of_the_day(18));
  console.log("19 = " + color_of_the_day(19));
  console.log("20 = " + color_of_the_day(20));
//console.log("XXX After writing Hello World XXX" + x);
});




// Listen on port 8000, IP defaults to 127.0.0.1
server.listen(8090);

// Put a friendly message on the terminal
console.log("Server running at http://127.0.0.1:8090/");

function color_of_the_day(daysAfterToday){
    console.log("daysAfterToday = " + daysAfterToday);
    var colorArray = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black"];
    //Throw exception for -ve
    if (daysAfterToday < 0){
        throw new Error("daysAfterToday cannot be negative");
    }
    // Saturday or Sun day
    console.log("(daysAfterToday + 1) % 7 = " + (daysAfterToday + 1) % 7);
    if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6){
        return "No Color";
    }
    var numOfSevenDayPeriod = Math.floor(daysAfterToday/7);
    var totalWorkDays = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
    var colorChangeDays = (totalWorkDays) % 7;// As thre are seven colors
    return colorArray[colorChangeDays];
}