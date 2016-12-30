/**
 * Created by svadmin on 12/28/2016.
 */


$(document).ready(function(){
    $('#addButton').click(function () {
        proUtils = new ProUtils();
        proUtils.addProduct("abc", "def");
    });
});