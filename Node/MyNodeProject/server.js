// Load the http module to create an http server.
var http = require('http');
var x = "3";
var y = 2;

// Configure our HTTP server to respond with Hello World to all requests.
var server = http.createServer(function (request, response) {
  response.writeHead(200, {"Content-Type": "text/plain"});
  response.end("Hello World\n");
  color_of_the_day(18)
  console.log("XXX After writing Hello World XXX" + x);
});




// Listen on port 8000, IP defaults to 127.0.0.1
server.listen(8090);

// Put a friendly message on the terminal
console.log("Server running at http://127.0.0.1:8000/");

function color_of_the_day(daysAfterToday){
	var colorArray = ["Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black"];
	var colorAfterDays = "No Color";
	//Throw exception for -ve
	if (daysAfterToday < 0){
		throw new Exception("daysAfterToday cannot be negative");
	}
	// Saturday or Sun day
	if ((daysAfterToday + 1) % 7 == 0 || (daysAfterToday + 1) % 7 == 6){
		return colorAfterDays;
	}
	var numOfSevenDayPeriod = (daysAfterToday) / 7;
	var daysAfterSevenDayPeriods = numOfSevenDayPeriod * 5 + daysAfterToday % 7;
	var colorChangeDays = (daysAfterSevenDayPeriods) % 7;
	console.log("daysAfterToday = " + daysAfterToday);
	console.log("numOfSevenDayPeriod = " + numOfSevenDayPeriod);
	console.log("daysAfterSevenDayPeriods = " + daysAfterSevenDayPeriods);
	console.log("colorChangeDays = " + colorChangeDays);
	console.log("COLOR Using colorArray= " + colorArray[colorChangeDays]);
	return colorArray[colorChangeDays];
}