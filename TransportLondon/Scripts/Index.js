$(document).ready(function () {
    $('.navBarIndex').click(function () {       
        $('.navBarIndex').removeClass('active');
        $(this).addClass('active');
        main.showDiv($(this).attr('id'), $(this).attr('idContainer'));
    });
});
main = {
    showDiv: function (id, idc) {
        $('.contentContainer').hide();      
        $('#' + idc).show();
        
        $.ajax({
            type: 'GET',
            url: '/Transport/Line/?Mode=Tube',
            //data: ({ Name: name, Password: pass, Role: role }),
            asynch: true,
            success: function (output, status, xhr) {
                $('#addLinesTubeTmpl').tmpl(output).appendTo('#tableLineTube');
            },
            error: function () {
                alert('Error');
            }
        });

    }
}
