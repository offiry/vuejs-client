(function () {
    'use strict';

    function createToast(variant, content, title) {
        this.$bvToast.toast(content, {
            title: title,
            solid: true,
            variant: variant,
            toaster: 'b-toaster-bottom-left',
            showclosebutton: true,
            bodyClass: 'toastBody',
            autoHideDelay: 10000,
        });
    }

    axios.interceptors.response.use(
        res => {
            //let self = new Vue();
            //createToast.call(self, 'success', res.data, 'Success');

            return res;
        },
        err => {
            return err;
        }
    )

})();