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
        if (id == 'Tube')
            Tube.GetLine();
        if (id == 'Bus')
            Bus.GetLine();
        //if (idc == 'DLR')
        //    Tube.GetLine();
        //if (idc == 'NRail')
        //    Tube.GetLine();


        //$.ajax({
        //    type: 'GET',
        //    url: '/Transport/Line/?mode='+id,
        //    //data: ({ Name: name, Password: pass, Role: role }),
        //    asynch: true,
        //    success: function (output, status, xhr) {
        //        $('#addLinesTubeTmpl').tmpl(output).appendTo('#tableLineTube');
        //        $('.containerTr').mouseover(function () {
        //            $(this).css('background-color', 'white');
        //        });
        //        $('.containerTr').mouseout(function () {
        //            $(this).css('background-color', 'whitesmoke');
        //        });
        //        $('.containerTr').click(function () {

        //        });
        //    },
        //    error: function () {
        //        alert('Error');
        //    }
        //});

    },
    getLine: function (mode) {
        $.ajax({
            type: 'GET',
            url: '/Transport/Lines/?mode=' + mode,
            asynch: true,
            success: function (output, status, xhr) {
                if (mode == 'Tube')
                    Tube.RenderLine(output);
            },
            error: function () {
                alert('Error geting line ' + mode);
            }
        });
    },

}


Tube = {
    GetLine: function () {
        main.getLine('Tube');       

    },
    RenderLine: function (output) {
        $('#tableLineTube').empty();
        $('#addLinesTubeTmpl').tmpl(output).appendTo('#tableLineTube');
        
        $('.containerTr').mouseover(function () {         
            $(this).css('background-color', 'white');
        });
        $('.containerTr').mouseout(function () {
            $(this).css('background-color', 'whitesmoke');
        });
        $('.containerTr').click(function () {
            $('.containerTr').css('font-size', 'unset');
            $(this).css('font-size', 'large');
            Tube.GetLineStops($(this).attr('id'));
        });
        $('#btnHideStationTube').click(function () {
            $('#tubeStations').hide();
        });
    },
    GetLineStops: function (id) {
        $.ajax({
            type: 'GET',
            url: '/Transport/Line/' + id,
            asynch: true,
            success: function (output, status, xhr) {
                $('#tubeStations').show();
                $('#tableStaationsTube').empty();                
                $('#addStationsTubeTmpl').tmpl(output).appendTo('#tableStaationsTube');
                $('#btnShowMApTube').click(function () {
                    Tube.showMap(output);
                })          

            },
            error: function () {
                alert('Error getting Station Tube');
            }
        });
    },
    showMap: function (output) {
        google.maps.visualRefresh = true;
        var London = new google.maps.LatLng(51.50853, -0.12574);
        var mapOptions = {
            zoom: 10,
            center: London,
            mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP
        };
        var map = new google.maps.Map(document.getElementById("divMapsTube"), mapOptions);
        var myLatlng = new google.maps.LatLng(51.50853, -0.12574);
        //var marker = new google.maps.Marker({
        //    position: myLatlng,
        //    map: map,
        //    title: 'Station of Tube'
        //});
        //marker.setIcon('http://maps.google.com/mapfiles/ms/icons/red-dot.png');

        $.each(output, function (i, item) {
            var marker = new google.maps.Marker({
                'position': new google.maps.LatLng(item.Lat, item.Lon),
                'map': map,
                'title': item.Name
            });
            marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png');
            var infowindow = new google.maps.InfoWindow({
                content: "<div class='stationInfo'><h4>" + item.Name+"</h4>"
            });

            // обработчик нажатия на маркер объекта
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.open(map, marker);
            });
        })
    }
}
Bus = {
    GetLine: function(){
}
}
