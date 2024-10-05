<?php
session_start();

// Verificar si el usuario ha iniciado sesión y si es root
if (!isset($_SESSION['username']) || !$_SESSION['is_root']) {
    // Si no está autenticado o no es root, redirigir a login.php
    header("Location: login.php");
    exit();
}

// Incluir la conexión a la base de datos
include('db_connection.php');

// Verificar si se ha enviado el ID del usuario
if (isset($_GET['id'])) {
    $id = $_GET['id'];

    // Consultar el usuario por ID
    $stmt = $conn->prepare("SELECT * FROM usuarios WHERE id = ?");
    $stmt->bind_param('i', $id);
    $stmt->execute();
    $result = $stmt->get_result();

    // Verificar si el usuario existe
    if ($result->num_rows == 1) {
        $usuario = $result->fetch_assoc();
    } else {
        echo "<div class='alert alert-danger'>Usuario no encontrado.</div>";
        exit();
    }
} else {
    echo "<div class='alert alert-danger'>ID de usuario no especificado.</div>";
    exit();
}

// Verificar si se envió el formulario para actualizar
if ($_SERVER['REQUEST_METHOD'] == 'POST') {
    $username = trim($_POST['username']);
    $rol = trim($_POST['rol']);

    // Actualizar el usuario en la base de datos
    $sql = "UPDATE usuarios SET username = ?, rol = ? WHERE id = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param('ssi', $username, $rol, $id);

    if ($stmt->execute()) {
        echo "<div class='alert alert-success'>Usuario actualizado con éxito.</div>";
    } else {
        echo "<div class='alert alert-danger'>Error al actualizar el usuario: " . $conn->error . "</div>";
    }
}
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editar Usuario</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <div class="container mt-5">
        <h2>Editar Usuario</h2>
        <form action="editar_usuario.php?id=<?php echo $usuario['id']; ?>" method="POST">
            <div class="form-group">
                <label for="username">Nombre de Usuario:</label>
                <input type="text" class="form-control" id="username" name="username" value="<?php echo htmlspecialchars($usuario['username']); ?>" required>
            </div>
            <div class="form-group">
                <label for="rol">Rol:</label>
                <select class="form-control" id="rol" name="rol" required>
                    <option value="normal" <?php echo ($usuario['rol'] == 'normal') ? 'selected' : ''; ?>>Normal</option>
                    <option value="funcionario" <?php echo ($usuario['rol'] == 'funcionario') ? 'selected' : ''; ?>>Funcionario</option>
                    <option value="root" <?php echo ($usuario['rol'] == 'root') ? 'selected' : ''; ?>>Root</option>
                </select>
            </div>
            <button type="submit" class="btn btn-primary">Actualizar</button>
            <a href="dashboard.php" class="btn btn-secondary">Cancelar</a>
        </form>
    </div>
</body>
</html>
