/**
 * Created by svadmin on 12/28/2016.
 */
var xyz =$;

$(document).ready(function(){

    $('#addButton').click(function () {
        var proUtils = new ProUtils();
        proUtils.addProduct("abc", "def");
    });
    $('#ShowTable').click(function () {
        //proUtils = new ProUtils();
        //var showAll =ProUtils.getAllTheProducts;
        //var drawingTable = drawTable();
		drawTable();
        //document.getElementById("mainTable").innerHTML = drawingTable;
    });

    function drawTable() {

        console.log("Draw");
        var proUtils = new ProUtils();
        var allProducts = proUtils.getAllTheProducts();

        $("#mainTable").attr("xys", "abc");
        var someVAr = $("#mainTable").append($('<table>'));
        var theTable = $("#mainTable table");
        for(var i =0;i<allProducts.length;i++) {
            theTable.append($('<tr>'));
            var theRow = theTable.find("tr:last");
            theRow.attr("id",allProducts[i].id );
            theRow.append($('<td>'));
            var theLastTD = theRow.find("td:last");
            theLastTD.text(allProducts[i].id);
            theRow.append($('<td>'));
            theLastTD = theRow.find("td:last");
            theLastTD.text(allProducts[i].name);
            theRow.append($('<td>'));
            theLastTD = theRow.find("td:last");
            theLastTD.text(allProducts[i].label);
        }
		var xx = "xxx";

/*
        var tableHtml = ('<table>');
        for(var i =0;i<allProducts.length;i++) {
            var makeRows = "<tr "+allProducts[i].id+"+><td>" +allProducts[i].id + "</td><td>" + allProducts[i].name + "</td><td>" + allProducts[i].label + "</td></tr>";
            tableHtml += makeRows;
        }
        tableHtml = tableHtml + "</table>";
        $("#mainTable").append(tableHtml);

        */


        /*
        //create table
        var table = ('<table>');
        //geting all product data from local storage
        var proUtils = new ProUtils();

        var showAll = proUtils.getAllTheProducts();

        for(var i =0;i<showAll.length;i++) {
            var makeRows = "<tr "+showAll[i].id+"+><td>" +showAll[i].id + "</td><td>" + showAll[i].name + "</td><td>" + showAll[i].label + "</td></tr>";
            table += makeRows;
        }
        table = table + "</table>";
        console.log("i am done with my table" + table);
        return table;
        */
    }
    /*$('#addButton').click(function () {
        proUtils = new ProUtils();
        proUtils.addProduct("abc", "def");
    });
	$('#showTable').click(function () {
       drawTable();
    });
	function drawTable(){
		 // TODO display the table
		proUtils = new ProUtils();
		var theTableDiv = $('#prductTable');
		var allProducts = proUtils.getAllTheProducts();
		var theWholeText = "<table>";
		for(var i =0 ; i< allProducts.length;i++){
			var thisProduct = allProducts[i];
			theWholeText = theWholeText + '<tr id=\"'+ allProducts[i].id+ '"\">';
			for (var property in thisProduct) {
				if (thisProduct.hasOwnProperty(property)) {
					if(property != "xxxProperty" && property !="id")
					theWholeText = theWholeText + '<td>'+ allProducts[i][property] + '</td>';
				}
			}
			theWholeText = theWholeText + "</tr>";
        }
		theWholeText = theWholeText + "</table>";
		theTableDiv.html( theWholeText );
		// use getAllTheProducts and loop thourgh and generate html
	};
	drawTable();*/
	
});