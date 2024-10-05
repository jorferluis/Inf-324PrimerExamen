<?php
$servername = "localhost";
$username1 = "root"; // Si estás usando XAMPP, el usuario por defecto es 'root'
$password1 = ""; // En XAMPP, normalmente no se establece una contraseña para 'root'
$dbname = "bdjorge"; // Asegúrate de que este es el nombre correcto de tu base de datos

// Crear conexión
$conn = new mysqli($servername, $username1, $password1, $dbname);

// Verificar la conexión
if ($conn->connect_error) {
    die("Conexión fallida: " . $conn->connect_error);
}
?>

