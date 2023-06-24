let center = [52.2584109807715,104.26442237441388];

function init() {
	let map = new ymaps.Map('map-test', {
		center: center,
		zoom: 19
	});

	let placemark = new ymaps.Placemark(center, {}, {
		iconLayout: 'default#image',
		iconImageHref: 'https://cdn.icon-icons.com/icons2/2444/PNG/512/location_map_pin_mark_icon_148684.png',
		iconImageSize: [40, 40],
		iconImageOffset: [-19, -44]
	});

    var myPolygon = new ymaps.Polygon([[
        // Координаты вершин внешней границы многоугольника.
        [52.258014310104095,104.26452698056548],
        [52.25805216679475,104.26472278182356],
        [52.2583105789894,104.26459135358185],
        [52.258264492848994,104.26447333638517],
        [52.25828259812418,104.26438482348765],
        [52.258014310104095,104.26452698056548]
    ]],
    {
        hintContent: "Polygon"
    }, {
        fillColor: '#6699ff',
        // Делаем полигон прозрачным для событий карты.
        interactivityModel: 'default#transparent',
        strokeWidth: 8,
        opacity: 0.5
    });

    var polyline = new ymaps.Polyline([
        [52.25852619564978,104.26439823453275],
        [52.25883892023161,104.26423730199186],
        [52.25879118872824,104.26404150073375]
    ], {
        hintContent: "PolyLine"
    }, {
        draggable: true,
        strokeColor: '#000000',
        strokeWidth: 4,
        strokeStyle: '1 0'// Первой цифрой задаем длину штриха. Второй — длину разрыва.
    });
    map.geoObjects.add(polyline); // Добавляем линию на карту.
map.setBounds(polyline.geometry.getBounds()); // Устанавливаем карте границы линии.

    map.controls.remove('geolocationControl'); // удаляем геолокацию
  map.controls.remove('searchControl'); // удаляем поиск
  map.controls.remove('trafficControl'); // удаляем контроль трафика
  
  map.geoObjects.add(placemark);

  map.geoObjects.add(myPolygon);
  map.setBounds(polygon.geometry.getBounds());
     

}

ymaps.ready(init);