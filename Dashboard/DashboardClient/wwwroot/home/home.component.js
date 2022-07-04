(function () {
    'use strict';

    var homeComponent = new Vue({
        el: '#home-component',
        mixins: [homeMixin],
        data() {
            return {
                products: [],
                filter: ''
            }
        },
        props: [],
        methods: {
            getAllProductsEndpoint: function () {
                const onSuccess = (response) => {
                    this.products = response.data.products;
                    this.loader = false;
                };

                this.getAllProducts(onSuccess);
            },
        },
        watch: {

        },
        created: function () {
            this.getAllProductsEndpoint();
        },
        computed: {
            filteredProducts() {

                //return products
                //    .Where(function (x) {
                //        return x.Name.toLowerCase().includes(this.filter.toLowerCase());
                //    });

                return this.products.filter(product => {
                    if (this.products == null)
                        return this.products;

                    return product.name.toLowerCase().includes(this.filter.toLowerCase());
                });
            }
        }
    });
})();
