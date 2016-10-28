$(document).ready(function () {
    $('#Bus').addClass('active');
    main.showDiv('Bus', 'containerBus');
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
            $(this).css('background-color', '#dff0d8');
        });
        $('.containerTr').click(function () {
            $('.containerTr').css('font-size', 'unset');
            $(this).css('font-size', '20px');
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
                $('#divMapsTube').show();               
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
            
            google.maps.event.addListener(marker, 'click', function () {
                infowindow.open(map, marker);
            });
        })
    }
}
Bus = {
    Lines: function () {
        Bus.GetLine('1');
        main.getLine('Bus');
        $('#btnSearchBus').click(function () {
            var id = $('#inputSearshBus').val();
            if (id == null || id == "")
                $('#errorSearchBus').text('Enter Line!');
            else {
                Bus.GetLine(id);
            }
        });
        $('#btnSearchStop').click(function () {
            var text = $('#inputSearshStop').val();
            if (text == null || text == "")
                $('#errorSearchStop').text('Enter Stop!');
            else {
                stop.search(text);
            }
        }); 
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
            var id = $(this).attr('id');
            Bus.showStops(id,name);

        });
    },
    showStops: function (id,name) {
        $('#hStopPointName').text('Stop Point: "' + name + '"');
        stop.getRoutes(id);
        stop.GetPrediction(id);
        $('#btnUpdateTimeTable').click(function () {
            $('#tableTimeArrivals').empty();
            stop.GetPrediction(id);
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
                stop.renderAvRouts(output);
            },
            error: function () {
                alert('Error geting routes');
            }
        });
    },
    search: function (query) {
        $.ajax({
            type: 'GET',
            url: '/Transport/searchstop/' + query,
            asynch: true,
            success: function (output, status, xhr) {
                if (output != "") {                    
                    $('#errorSearchStop').text('');
                    $('#resultSearch').show();
                    $('#tableResultSearch').empty();
                    $('#addStationsBusTmpl').tmpl(output).appendTo('#tableResultSearch');
                    $('.trStationBus').click(function () {
                        var name = $(this).attr('stationName');
                        var id = $(this).attr('id');
                        Bus.showStops(id, name);
                    });
                    $('#btnSearchHide').click(function () {
                        $('#inputSearshStop').val('');
                        $('#resultSearch').hide();
                    })
                } else {
                    $('#resultSearch').hide();
                    $('#errorSearchStop').text('This stop was not found');
                }
            },
            error: function () {
                alert('Error search');
            }
        });
    },
    renderTimeTable: function (output) {
        $('#tableTimeArrivals').empty();
        $('#addTimeTableTmpl').tmpl(output).appendTo('#tableTimeArrivals');
    },
    renderAvRouts: function (output) {
        $('#tableAvaibleRouts').empty();
        $('#addRoutsTmpl').tmpl(output).appendTo('#tableAvaibleRouts');
    }
}
