let center = [52.262618748248734,104.26161807164198];

function init() {
	let map = new ymaps.Map('map-test', {
		center: center,
		zoom: 26
	});

	let placemark = new ymaps.Placemark(center, {}, {
		iconLayout: 'default#image',
		iconImageHref: 'https://cdn.icon-icons.com/icons2/1750/PNG/512/015location_113739.png',
		iconImageSize: [40, 40],
		iconImageOffset: [-19, -44]
	});

    var myPolygon = new ymaps.Polygon([[
        // Координаты вершин внешней границы многоугольника.
        [52.262921116180614,104.26125531513284],
        [52.263225580868976,104.26108901817398],
        [52.26326343308879,104.26129286605908],
        [52.26289807552409,104.26145648080907],
        [52.262911241615015,104.2613572390754],
        [52.262921116180614,104.26125531513284]
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
        [52.26237472022775,104.26157449800554],
        [52.26248992475658,104.26138674337457],
        [52.26262487825065,104.26135187465742],
        [52.2627878093581,104.26123385746074],
        [52.26287997214235,104.26145648080907]
    ], {
        hintContent: "PolyLine"
    }, {
        draggable: true,
        strokeColor: '#2f2f2f',
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