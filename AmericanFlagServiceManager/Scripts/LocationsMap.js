//google.load("maps", "2");
//var contactid = $("#map")[0].dataset("variableid")
// make a json request to get the map data from the Map action
jQuery(document).ready(function() {
    $.getJSON("http://" + window.location.host + "/api/map/" + MapId, initialise);
});

function initialise(mapData) {
    //$("#mapName").text(mapData.Name);

    var mapOptions = {
        zoom: 17,
        center: new google.maps.LatLng(mapData.Locations[0].Coord.Latitude, mapData.Locations[0].Coord.Longitude),

    };

    var map = new google.maps.Map($("#map")[0],mapOptions);


    $.each(mapData.Locations, function(i, location) {
        setupLocationMarker(map, location);
    });
}

function setupLocationMarker(map, location) {

    var latlng = new google.maps.LatLng(location.Coord.Latitude, location.Coord.Longitude);
    var marker = new google.maps.Marker(
        {
            position: latlng,
            map: map,
            title: location.Name,
        });

    //google.maps.event.addListener(marker, 'click', function (latlng) {
    //    $("#info").text(location.Name);
    //    $("#image")[0].src = "../../Content/" + location.Image;
    //}
        
        //);


    
}



