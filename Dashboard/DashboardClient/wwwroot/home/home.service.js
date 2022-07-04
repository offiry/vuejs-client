(function () {
    'use strict';

    var homeService = {
        install: function (Vue, options) {
            Vue.prototype.$getAllProducts = function (onSuccess, onError) {
                return axios.get("/api/Dashboard/GetAllProducts", { params: {} })
                    .then(onSuccess).catch(onError);
            };
        }
    }

    Vue.use(homeService);
})();