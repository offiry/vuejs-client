'use strict';

var homeMixin = {
    data: function () {
        return {
            loader: false
        }
    },
    methods: {
        async getAllProducts(onSuccess) {
            this.loader = true;
            return await this.$getAllProducts(onSuccess);
        },
    },
    created: function () {

    }
}