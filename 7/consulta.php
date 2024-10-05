<?php
include('db_connection.php');

// Consulta SQL
$sql = "
SELECT 
    p.ci,
    CONCAT(p.nombre, ' ', p.paterno) AS nombre_completo,
    CASE 
        WHEN prop.id BETWEEN 100000 AND 199999 THEN 'Impuesto Alto'
        WHEN prop.id BETWEEN 200000 AND 299999 THEN 'Impuesto Medio'
        WHEN prop.id BETWEEN 300000 AND 399999 THEN 'Impuesto Bajo'
        ELSE 'Tipo de impuesto desconocido'
    END AS tipo_impuesto,
    prop.id AS propiedad_id
FROM 
    Persona p
JOIN 
    propiedades prop ON p.ci = prop.ci;
";

$result = $conn->query($sql);

// Comenzar a generar la tabla HTML
if ($result->num_rows > 0) {
    // Estructura de la tabla
    echo "<!DOCTYPE html>
    <html>
    <head>
        <title>Lista de Personas por Tipo de Impuesto</title>
        <link rel='stylesheet' href='assets/css/style.css'> 
        <link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>
    </head>
    <body>
        <header class='bg-primary text-white text-center py-5 mb-4'>
            <div class='container'>
                <img src='assets/images/logo.jpeg' alt='Logo' class='logo mb-3'>
                <h1 class='display-4'>Información General de la HAM-LP</h1>
                <p class='lead'>Lista de Personas por Tipo de Impuesto</p>
            </div>
        </header>
        <div class='container'>
            <table class='table table-striped'>
                <thead>
                    <tr>
                        <th>Cédula de Identidad</th>
                        <th>Nombre Completo</th>
                        <th>Impuesto Alto</th>
                        <th>Impuesto Medio</th>
                        <th>Impuesto Bajo</th>
                    </tr>
                </thead>
                <tbody>";

    // Crear un array para almacenar las propiedades por tipo de impuesto
    $data = [];
    while ($row = $result->fetch_assoc()) {
        $tipo_impuesto = $row['tipo_impuesto'];
        $ci = $row['ci'];
        $nombre_completo = $row['nombre_completo'];
        $propiedad_id = $row['propiedad_id'];

        // Agregar la propiedad a la estructura de datos
        if (!isset($data[$ci])) {
            $data[$ci] = [
                'nombre_completo' => $nombre_completo,
                'impuesto_alto' => [],
                'impuesto_medio' => [],
                'impuesto_bajo' => [],
            ];
        }

        // Clasificar las propiedades según el tipo de impuesto
        if ($tipo_impuesto == 'Impuesto Alto') {
            $data[$ci]['impuesto_alto'][] = $propiedad_id;
        } elseif ($tipo_impuesto == 'Impuesto Medio') {
            $data[$ci]['impuesto_medio'][] = $propiedad_id;
        } elseif ($tipo_impuesto == 'Impuesto Bajo') {
            $data[$ci]['impuesto_bajo'][] = $propiedad_id;
        }
    }

    // Mostrar los datos en la tabla
    foreach ($data as $ci => $info) {
        echo "<tr>
                <td>" . $ci . "</td>
                <td>" . $info['nombre_completo'] . "</td>
                <td>" . implode(", ", $info['impuesto_alto']) . "</td>
                <td>" . implode(", ", $info['impuesto_medio']) . "</td>
                <td>" . implode(", ", $info['impuesto_bajo']) . "</td>
            </tr>";
    }

    echo "      </tbody>
            </table>
        </div>
        <div class='text-center'>
            <a class='btn btn-success' href='dashboard.php'>Panel de Control</a> 
        </div>

        <footer class='bg-dark text-white text-center py-3 mt-4'>
        <div class='container'>
            <p>&copy; 2024 HAM-LP. Todos los derechos reservados.</p>
            <p>
                <a href='#' class='text-white'>Política de Privacidad</a> | 
                <a href='#' class='text-white'>Términos de Servicio</a>
            </p>
        </div>
        </footer>
        <script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'></script>
        <script src='https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js'></script>
        <script src='https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js'></script>
    </body>
    </html>";
} else {
    echo "<p>No se encontraron resultados.</p>";
}

// Cerrar la conexión
$conn->close();
?>
