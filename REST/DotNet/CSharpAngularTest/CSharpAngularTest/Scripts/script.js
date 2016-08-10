/// <reference path="angular.js" />
var myModule = angular.module("myModule", []);
myModule.controller("myController", function ($scope) {
    $scope.Math = Math;
    var myArray = [
        { 'Name': 'Ahmed', 'Color': 'Red', 'img': '/Images/composer.png', 'sval': Math.sin(Math.PI / 2) },
        { 'Name': 'Mustafa', 'Color': 'Green', 'img': '/Images/composer.png', 'sval': Math.sin(Math.PI / 4) }
    ];
    $scope.myArray = myArray;
});