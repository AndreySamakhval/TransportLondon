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
            Bus.Lines();
        //if (idc == 'DLR')
        //    Tube.GetLine();
        //if (idc == 'NRail')
        //    Tube.GetLine();

    },
    getLine: function (mode) {
        $.ajax({
            type: 'GET',
            url: '/Transport/Lines/?mode=' + mode,
            asynch: true,
            success: function (output, status, xhr) {
                if (mode == 'Tube')
                    Tube.RenderLine(output);
                if (mode == 'Bus')
                    Bus.renderLines(output);
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
            $('#tdActive').remove();
            $(this).append('<td id="tdActive">></td>');
            Tube.GetLineStops($(this).attr('id'));           

        });
        $('#btnHideStationTube').click(function () {
            $('#tubeStations').hide();
            $('#tdActive').remove();
            $('.containerTr').css('font-size', 'unset');
            $('#divMapsTube').hide();
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
                var displayMaps = $('#divMapsTube').css('display');
                if (displayMaps != 'none')
                    Tube.showMap(output);
                $('#btnShowMApTube').click(function () {
                    $('#divMapsTube').show();
                    Tube.showMap(output);
                });                
                $('#btnHideMapTube').click(function () {
                    $('#divMapsTube').hide();                   
                });
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
            zoom: 11,
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
                content: "<div class='stationInfo'><p>" + item.Name+"</p>"
            });

            // обработчик нажатия на маркер объекта
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.open(map, marker);
            });
        })
    }
}
Bus = {
    Lines: function(){
        $('#btnSearchBus').click(function () {
            var id = $('#inputSearshBus').val();
            if (id == null || id == "")
                $('#errorSearchBus').text('Enter Line!');
            else {
                Bus.GetLine(id);
            }
        });
        $('#test').click(function () {
            $.ajax({
                type: 'GET',
                url: '/Transport/test/',
                asynch: true,
                success: function (output, status, xhr) {
                   
                },
                error: function () {                   
                }
            });
        });
        Bus.GetLine('1');
            main.getLine('Bus');
    },
    GetLine: function (id) {
                $('#errorSearchBus').text('');
                $('#nameLineTube').text('');
                $('#showLineDestination').empty();
                $('#tableStationBus').empty();
                $.ajax({
                    type: 'GET',
                    url: '/Transport/LineInfo/' + id,
                    asynch: true,
                    success: function (output, status, xhr) {
                        if (output == "") {
                            $('#errorSearchBus').text('This Line was not found!');
                        } else {
                            $('#nameLineTube').text('Information about bus line №' + id);
                            $('#showLineDestination').empty();
                            $('#showLineDestination').html(output);
                            Bus.getStations(id);
                        }
                    },
                    error: function () {
                        alert('Error');
                    }
                });

    },
    renderLines: function (output) {
        $('#tableAllBus').empty();
        $('#addLinesBusTmpl').tmpl(output).appendTo('#tableAllBus');
        $('.containerTrBus').click(function () {
            var id = $(this).attr('id');
            Bus.GetLine(id);
        })
    },
    renderStops:function(output){
        $('#tableStationBus').empty();
        $('#addStationsBusTmpl').tmpl(output).appendTo('#tableStationBus');
        $('.trStationBus').click(function () {
            $('.trStationBus').css('background-color', 'snow');
            $(this).css('background-color', 'lightcyan');
            var name = $(this).attr('stationName');
            $('#hStopPointName').text('Stop Point: "' + name + '"');
            stop.getRoutes($(this).attr('id'));
            stop.GetPrediction($(this).attr('id'));
        });
    },
    getStations: function (id) {
        $.ajax({
            type: 'GET',
            url: '/Transport/LineStops/' + id,
            asynch: true,
            success: function (output, status, xhr) {
                Bus.renderStops(output);
            },
            error: function () {
                alert('Error geting stops ');
            }
        });
    }
}

stop = {
    GetPrediction: function (id) {
        $.ajax({
            type: 'GET',
            url: '/Transport/Prediction/' + id,
            asynch: true,
            success: function (output, status, xhr) {
                stop.renderTimeTable(output)
            },
            error: function () {
                alert('Error geting prediction');
            }
        });
    },
    getRoutes:function(id){
        $.ajax({
            type: 'GET',
            url: '/Transport/Route/' + id,
            asynch: true,
            success: function (output, status, xhr) {
                $('#availableRoute').empty();
                $('#availableRoute').text(output);
            },
            error: function () {
                alert('Error geting routes');
            }
        });
    },
    renderTimeTable: function (output) {
        $('#tableTimeArrivals').empty();
        $('#addTimeTableTmpl').tmpl(output).appendTo('#tableTimeArrivals');
    }
}
