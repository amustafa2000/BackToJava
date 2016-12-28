/**
 * Created by svadmin on 12/28/2016.
 */

function ProUtils() {
}

ProUtils.prototype = {
    constructor: ProUtils,
    generateProductId: function () {
        var max = 10000;
        var random = Math.floor(Math.random() * max);
        return random;
    }
}
