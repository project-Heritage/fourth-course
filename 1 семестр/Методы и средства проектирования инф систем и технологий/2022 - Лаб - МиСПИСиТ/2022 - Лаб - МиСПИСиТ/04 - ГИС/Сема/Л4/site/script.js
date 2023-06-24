let center = [52.263132479233846,104.25915826077028];

function init() {
	let map = new ymaps.Map('map-test', {
		center: center,
		zoom: 19
	});

	let placemark = new ymaps.Placemark(center, {}, {
		iconLayout: 'default#image',
		iconImageHref: 'https://cdn.icon-icons.com/icons2/2073/PNG/512/location_map_twitter_icon_127126.png',
		iconImageSize: [40, 40],
		iconImageOffset: [-19, -44]
	});

    var myPolygon = new ymaps.Polygon([[
        [52.26337934147319,104.25904426688717],
        [52.26340896484909,104.25918105954693],
        [52.26347644024217,104.25919715280101],
        [52.26347644024217,104.25928968901205],
        [52.26319748642417,104.25940502399965],
        [52.26321723542505,104.25900269264741],
        [52.26329458559339,104.25902280921503],
        [52.26337934147319,104.25904426688717]
    ]],
    {
        hintContent: "Polygon"
    }, {
        fillColor: '#89ac76',

        interactivityModel: 'default#transparent',
        strokeWidth: 8,
        opacity: 0.5
    });
    var polyline = new ymaps.Polyline([
        [52.26302180221475,104.25909858161971],
        [52.26290001602904,104.25921928102538],
        [52.26283089399031,104.259329251595],
        [52.26287862112387,104.25945263320966],
        [52.262814436346076,104.25953846389818],
        [52.26286051773445,104.25962965900469],
        [52.26290495331338,104.25954382831621],
        [52.26304319705051,104.25948750192686]
    ], {
        hintContent: "PolyLine"
    }, {
        draggable: true,
        strokeColor: '#000000',
        strokeWidth: 4,
        strokeStyle: '1 0'
    });
    map.geoObjects.add(polyline); 
map.setBounds(polyline.geometry.getBounds()); 

    map.controls.remove('geolocationControl'); 
  map.controls.remove('searchControl'); 
  map.controls.remove('trafficControl'); 
  
  map.geoObjects.add(placemark);

  map.geoObjects.add(myPolygon);
  map.setBounds(polygon.geometry.getBounds());
     

}

ymaps.ready(init);