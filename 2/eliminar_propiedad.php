<?php
session_start();

// Verificar si el usuario ha iniciado sesión y si es root
if (!isset($_SESSION['username']) ) {
    // Si no está autenticado o no es root, redirigir a login.php
    header("Location: login.php");
    exit();
}

// Incluir la conexión a la base de datos
include('db_connection.php');

// Verificar si se ha enviado el ID de la propiedad
if (isset($_GET['id'])) {
    $id = $_GET['id'];

    // Preparar la consulta para eliminar la propiedad de la base de datos
    $sql = "DELETE FROM propiedades WHERE id = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $id);

    if ($stmt->execute()) {
        // Redirigir al dashboard después de eliminar la propiedad
        header("Location: dashboard.php");
        exit();
    } else {
        // Manejo de errores si no se pudo eliminar
        echo "Error al eliminar la propiedad: " . $stmt->error;
    }
} else {
    // Si no se proporciona ID, redirigir al dashboard
    header("Location: dashboard.php");
    exit();
}
?>
