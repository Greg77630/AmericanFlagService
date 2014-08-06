//google.load("maps", "2");

// make a json request to get the map data from the Map action
jQuery(document).ready(function() {
    //if (google.maps.BrowserIsCompatible()) {
    //    //$.getJSON("http://" + window.location.host + "/Home/Map", initialise);
        
    //}
    $.getJSON("http://" + window.location.host + "/api/map/1", initialise);

    //$.getJSON("http://" + window.location.host + "/api/map/1",
    //    function (mapData) {
    //        $("#mapName").text(mapData.Name);

    //        var map = new google.maps.Map($("#map")[0]);
    //        map.addControl(new google.maps.SmallMapControl());
    //        map.addControl(new google.maps.MapTypeControl());
    //        map.setMapType(G_SATELLITE_MAP);

    //        var latlng = new google.maps.LatLng(mapData.LatLng.Latitude, mapData.LatLng.Longitude);
    //        var zoom = mapData.Zoom;

    //        map.setCenter(latlng, zoom);

    //        $.each(mapData.Locations, function (i, location) {
    //            setupLocationMarker(map, location);
    //        });
    //    })
});

function initialise(mapData) {
    //$("#mapName").text(mapData.Name);

    var mapOptions = {
        zoom: 17,
        center: new google.maps.LatLng(mapData.Locations[0].Coord.Latitude, mapData.Locations[0].Coord.Longitude),
       // mapTypeId: 'ROADMAP',
        //mapTypeControlOptions: {
        //    mapTypeIds: ['ROADMAP', google.maps.MapTypeId.ROADMAP],
        //    style: google.maps.MapTypeControlStyle.DROPDOWN_MENU
        //}


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

    //map.addOverlay(marker);

    //google.maps.event.addListener(marker, 'click', function (latlng) {
    //    $("#info").text(location.Name);
    //    $("#image")[0].src = "../../Content/" + location.Image;
    //}
        
        //);


    
}



