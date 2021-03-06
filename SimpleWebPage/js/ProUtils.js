/**
 * Created by svadmin on 12/28/2016.
 */

function ProUtils() {
}

ProUtils.prototype = {
    constructor: ProUtils,
    generateProductId: function () {
        //var max = 100000;
        //var random = Math.floor(Math.random() * max);
        //return random;
        /*var allProducts = this.getAllTheProducts();
        var nextId = 0;
        for(var i =0 ; i< allProducts.length;i++){
            var thisItemId = allProducts[i].id;
            if(thisItemId >= nextId) {
                nextId = thisItemId + 1;
            }
        }
        return nextId;*/
        var lastId = localStorage.getItem("lastId");
        if (lastId == null){
            localStorage.setItem("lastId", "0");
            return 0;
        }else {
            localStorage.setItem("lastId", parseInt(lastId)+1);
            return parseInt(lastId)+1;
        }
    },
    addProduct: function (name, label) {
        var myProducts = this.getAllTheProducts();
        var newProduct = new Product();
        newProduct.addProduct(name, label, this);
        myProducts.push(newProduct);
        proUtils.saveProducts(myProducts);
    },
    getAllTheProducts: function () {
        var myProducts = localStorage.getItem("myProducts");
        if (myProducts == null){
            return [];
        }else {
            return JSON.parse(myProducts);
        }
    },
    saveProducts: function (productsToSave) {
        localStorage.setItem("myProducts", JSON.stringify(productsToSave));
    },
    getProductWithId: function (idToFind) {
        var allProducts = this.getAllTheProducts();
        for(var i =0 ; i< allProducts.length;i++){
            if(allProducts[i].id == idToFind) {
                return allProducts[i];
            }
        }
        return null;
    },
    deleteProductWithId: function (idToDelete) {
        var allProducts = this.getAllTheProducts();
        var indexToRemove = -1;
        for(var i =0 ; i< allProducts.length;i++){
            if(allProducts[i].id == idToDelete) {
                indexToRemove = i;
                break;
            }
        }
        if(indexToRemove > 0){
            allProducts.splice(indexToRemove, 1);
            this.saveProducts(allProducts);
        }
    },
    updateProduct: function (productToUpdate) {
        var allProducts = this.getAllTheProducts();
        for(var i =0 ; i< allProducts.length;i++){
            if(allProducts[i].id == productToUpdate.id) {
                allProducts[i].name = productToUpdate.name;
                allProducts[i].label = productToUpdate.label;
                break;
            }
        }
        this.saveProducts(allProducts);
    },
    /*
    * Expected element id is like productId:someAttrubute. attributes can be like id, name, labe
    * Expected input is 1213:Id or 8989:label...
     */
    getProductIdFromElemetId: function (elementId) {
        var splitedStuff = elementId.split(":");
        return splitedStuff[0];
    }
}
