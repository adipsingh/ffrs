function StartProcess() {
    //$(".preloader").fadeIn("slow");
    $(".page-loader-wrapper").fadeIn();
}
function StopProcess() {
    //$(".preloader").fadeOut("slow");
    $(".page-loader-wrapper").fadeOut();
}
function funToastr(status, msg) {
    var colorName = "";
    if (status) {
        colorName = 'bg-green';
    }
    else {
        colorName = 'bg-deep-orange';
    }
    var allowDismiss = true;
    $.notify({
        message: msg
    },
        {
            type: colorName,
            allow_dismiss: allowDismiss,
            newest_on_top: true,
            timer: 100000,
            placement: {
                from: 'top',
                align: 'right'
            },
            animate: {
                enter: 'animated fadeInDown',
                exit: 'animated fadeOutUp'
            },
            template: '<div data-notify="container" class="bootstrap-notify-container alert alert-dismissible {0} ' + (allowDismiss ? "" : "") + '" role="alert">' +
             '<button type="button" aria-hidden="true" class="close" data-notify="dismiss">×</button>' +
             '<span data-notify="icon"></span> ' +
             '<span data-notify="title">{1}</span> ' +
             '<span data-notify="message">{2}</span>' +
             '<div class="progress" data-notify="progressbar">' +
             '<div class="progress-bar progress-bar-{0}" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 0%;"></div>' +
             '</div>' +
             '<a href="{3}" target="{4}" data-notify="url"></a>' +
             '</div>'
        });
}