/**
 * Created by svadmin on 12/28/2016.
 */
$(document).ready(function(){

    // jQuery methods go here...
    console.log("xxxx");
    var proUtils = new ProUtils();
    var myProduct = new Product();
    myProduct.addProduct("aa", "bb", proUtils);
    console.log("The Id = "+ myProduct.id);
});