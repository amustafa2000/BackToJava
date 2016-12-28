/**
 * Created by svadmin on 12/28/2016.
 */
function Product() {
    this.name = "";
    this.label = "";
    this.id = "";
}

Product.prototype = {
    constructor: Product,
    getProducts: function () {
        // TODO get all the products from the local storage
    },
    getProduct: function (id) {
        // TODO get the product from the local storage
    },
    addProduct: function (name, label, proUtils) {
        // Set name label and id for the product
        this.name = name;
        this.label = label;
        this.id = proUtils.generateProductId();
    },
    deleteProduct: function (id) {
        //TODO delete the project from the local storage

    },
    updateProduct: function (name, label) {
        this.name = name;
        this.label = label;
    }
}