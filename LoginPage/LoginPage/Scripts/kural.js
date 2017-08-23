var Module = function () {

    //BtnKaydet
    var BtnKaydet = function () {
        var form1 = $('#form1'); //Form Adı
        var error1 = $('.alert-danger', form1);
        var success1 = $('.alert-success', form1);
        form1.validate({
            errorElement: 'span',
            errorClass: 'help-block help-block-error',
            focusInvalid: false,
            ignore: "",
            messages: {
                select_multi: {
                    maxlength: jQuery.validator.format("Max {0} items allowed for selection"),
                    minlength: jQuery.validator.format("At least {0} items must be selected")
                }
            },
            rules: { //Kurallar
                "Users.UserName": {
                    required: true,
                    number: true,
                    maxlength: 11,
                    minlength: 11
                },
                "Ilce.IlceKodu": {
                    number: true,
                    required: true
                },
                "Ilce.IlceAdi": {
                    minlength: 2,
                    required: true
                },
                "Ilce.DurumID": {
                    required: true
                }
            },

            invalidHandler: function (event, validator) {
                success1.hide();
                error1.show();
                App.scrollTo(error1, -200);
            },

            errorPlacement: function (error, element) {
                var cont = $(element).parent('.input-group');
                if (cont) {
                    cont.after(error);
                } else {
                    element.after(error);
                }
            },

            highlight: function (element) {

                $(element)
                    .closest('.form-group').addClass('has-error');
            },

            unhighlight: function (element) {
                $(element)
                    .closest('.form-group').removeClass('has-error');
            },

            success: function (label) {
                label
                    .closest('.form-group').removeClass('has-error');
            },

            submitHandler: function (form) {
                this.submit();
            }
        });
    }

    return {
        init: function () {
            BtnKaydet();
        }
    };
}();

jQuery(document).ready(function () {
    Module.init();
});