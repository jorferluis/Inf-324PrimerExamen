<?php
session_start();

// Verificar si el usuario ha iniciado sesión
if (!isset($_SESSION['username'])) {
    header("Location: login.php");
    exit();
}

// Incluir la conexión a la base de datos
include('db_connection.php');

// Obtener el ID de la propiedad desde la URL
$idPropiedad = $_GET['id'];

// Preparar la consulta para obtener los detalles de la propiedad
$stmt = $conn->prepare("SELECT * FROM propiedades WHERE id = ?");
$stmt->bind_param('i', $idPropiedad);
$stmt->execute();
$result = $stmt->get_result();

// Verificar si la propiedad existe
if ($result->num_rows === 0) {
    echo "Propiedad no encontrada.";
    exit();
}

// Obtener los datos de la propiedad
$propiedad = $result->fetch_assoc();
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Detalles de la Propiedad</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <div class="container mt-5">
        <h2>Detalles de la Propiedad</h2>
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <td><?php echo htmlspecialchars($propiedad['id']); ?></td>
            </tr>
            <tr>
                <th>Descripción</th>
                <td><?php echo htmlspecialchars($propiedad['descripcion']); ?></td>
            </tr>
            <tr>
                <th>Dirección</th>
                <td><?php echo htmlspecialchars($propiedad['direccion']); ?></td>
            </tr>
            <tr>
                <th>Zona</th>
                <td><?php echo htmlspecialchars($propiedad['zona']); ?></td>
            </tr>
            <tr>
                <th>Distrito</th>
                <td><?php echo htmlspecialchars($propiedad['distrito']); ?></td>
            </tr>
            <tr>
                <th>Coordenadas Iniciales (X, Y)</th>
                <td><?php echo htmlspecialchars($propiedad['x_ini']) . ', ' . htmlspecialchars($propiedad['y_ini']); ?></td>
            </tr>
            <tr>
                <th>Coordenadas Finales (X, Y)</th>
                <td><?php echo htmlspecialchars($propiedad['x_fin']) . ', ' . htmlspecialchars($propiedad['y_fin']); ?></td>
            </tr>
            <tr>
                <th>Superficie</th>
                <td><?php echo htmlspecialchars($propiedad['superficie']); ?> m²</td>
            </tr>
            <tr>
                <th>Precio</th>
                <td><?php echo htmlspecialchars($propiedad['precio']); ?> Bs.</td>
            </tr>
            <tr>
                <th>CI del Propietario</th>
                <td><?php echo htmlspecialchars($propiedad['ci']); ?></td>
            </tr>
            <tr>
                <th>Fecha de Registro</th>
                <td><?php echo htmlspecialchars($propiedad['fecha_registro']); ?></td>
            </tr>
        </table>
        <a href="dashboard.php" class="btn btn-primary">Volver al Panel</a>
    </div>
</body>
</html>
