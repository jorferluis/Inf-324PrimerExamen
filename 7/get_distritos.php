<?php
header('Content-Type: application/json');

// Mapeo de distritos según la zona
$distritosPorZona = [
    'Centro' => ['Distrito 1', 'Distrito 2', 'Distrito 3'],
    'Sur' => ['Distrito 4', 'Distrito 5', 'Distrito 6'],
    'Periférica' => ['Distrito 7', 'Distrito 8', 'Distrito 9'],
    'Max Paredes' => ['Distrito 10', 'Distrito 11'],
    'San Antonio' => ['Distrito 12', 'Distrito 13', 'Distrito 14']
];

// Obtiene la zona desde la solicitud
$zona = isset($_GET['zona']) ? $_GET['zona'] : '';

// Verifica si la zona existe en el arreglo
if (array_key_exists($zona, $distritosPorZona)) {
    echo json_encode($distritosPorZona[$zona]);
} else {
    echo json_encode([]);
}
?>
