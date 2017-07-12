function submit() {
    var email = $('#email').val();
    if (validateEmail(email)) {
        $('.validate').hide();
        $('.email-valid').css('padding-bottom', '20px');
        // send email
        console.log(email);
        
        $.confirm({
            backgroundDismiss: function () {
                $('#email').val('');
                return true; // modal close.
            },
            title: 'E-mail cadastrado com sucesso!',
            content: 'Entraremos em contato no lançamento :)',
            buttons: {
                OK: {
                    btnClass: 'btn-default',
                    action: function () {
                        $('#email').val('');
                    }
                }
            }
        });
    }
    else {
        $('.email-valid').css('padding-bottom', '0');
        $('.validate').show();
    }
}

function validateEmail(email) {
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}