<?php
session_start();

// Verificar si el usuario ha iniciado sesión
if (!isset($_SESSION['username'])) {
    header("Location: login.php");
    exit();
}

// Incluir la conexión a la base de datos
include('db_connection.php');

// Verificar si se ha pasado el ID de la propiedad a editar
if (!isset($_GET['id'])) {
    header("Location: dashboard.php"); // Redirigir si no se proporciona el ID
    exit();
}

// Obtener el ID de la propiedad
$id = $_GET['id'];

// Consultar la propiedad para obtener sus datos
$sql = "SELECT * FROM propiedades WHERE id = ?";
$stmt = $conn->prepare($sql);
$stmt->bind_param("i", $id);
$stmt->execute();
$result = $stmt->get_result();

if ($result->num_rows === 0) {
    header("Location: dashboard.php"); // Redirigir si la propiedad no existe
    exit();
}

// Obtener los datos de la propiedad
$propiedad = $result->fetch_assoc();

// Procesar el formulario de edición
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    // Obtener los datos del formulario
    $descripcion = trim($_POST['descripcion']);
    $direccion = trim($_POST['direccion']);
    $zona = trim($_POST['zona']);
    $distrito = trim($_POST['distrito']);
    $x_ini = trim($_POST['x_ini']);
    $y_ini = trim($_POST['y_ini']);
    $x_fin = trim($_POST['x_fin']);
    $y_fin = trim($_POST['y_fin']);
    $superficie = trim($_POST['superficie']);
    $precio = trim($_POST['precio']); // Obtener el precio del formulario

    // Actualizar la propiedad en la base de datos
    $sql = "UPDATE propiedades SET descripcion = ?, direccion = ?, zona = ?, distrito = ?, x_ini = ?, y_ini = ?, x_fin = ?, y_fin = ?, superficie = ?, precio = ? WHERE id = ?";
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("ssssssssisi", $descripcion, $direccion, $zona, $distrito, $x_ini, $y_ini, $x_fin, $y_fin, $superficie, $precio, $id);
    
    if ($stmt->execute()) {
        header("Location: dashboard.php"); // Redirigir después de la actualización
        exit();
    } else {
        $error = "Error al actualizar la propiedad.";
    }
}
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Editar Propiedad</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <div class="container mt-5">
        <h2>Editar Propiedad</h2>
        
        <?php if (isset($error)) { ?>
            <div class="alert alert-danger"><?php echo $error; ?></div>
        <?php } ?>
        
        <form method="POST">
            <div class="form-group">
                <label for="descripcion">Descripción</label>
                <input type="text" class="form-control" id="descripcion" name="descripcion" value="<?php echo htmlspecialchars($propiedad['descripcion']); ?>" required>
            </div>
            <div class="form-group">
                <label for="direccion">Dirección</label>
                <input type="text" class="form-control" id="direccion" name="direccion" value="<?php echo htmlspecialchars($propiedad['direccion']); ?>" required>
            </div>
            <div class="form-group">
                <label for="zona">Zona</label>
                <input type="text" class="form-control" id="zona" name="zona" value="<?php echo htmlspecialchars($propiedad['zona']); ?>" required>
            </div>
            <div class="form-group">
                <label for="distrito">Distrito</label>
                <input type="text" class="form-control" id="distrito" name="distrito" value="<?php echo htmlspecialchars($propiedad['distrito']); ?>" required>
            </div>
            <div class="form-group">
                <label for="x_ini">Coordenada X Inicial</label>
                <input type="text" class="form-control" id="x_ini" name="x_ini" value="<?php echo htmlspecialchars($propiedad['x_ini']); ?>" required>
            </div>
            <div class="form-group">
                <label for="y_ini">Coordenada Y Inicial</label>
                <input type="text" class="form-control" id="y_ini" name="y_ini" value="<?php echo htmlspecialchars($propiedad['y_ini']); ?>" required>
            </div>
            <div class="form-group">
                <label for="x_fin">Coordenada X Final</label>
                <input type="text" class="form-control" id="x_fin" name="x_fin" value="<?php echo htmlspecialchars($propiedad['x_fin']); ?>" required>
            </div>
            <div class="form-group">
                <label for="y_fin">Coordenada Y Final</label>
                <input type="text" class="form-control" id="y_fin" name="y_fin" value="<?php echo htmlspecialchars($propiedad['y_fin']); ?>" required>
            </div>
            <div class="form-group">
                <label for="superficie">Superficie</label>
                <input type="text" class="form-control" id="superficie" name="superficie" value="<?php echo htmlspecialchars($propiedad['superficie']); ?>" required>
            </div>
            <div class="form-group">
                <label for="precio">Precio</label> <!-- Nuevo campo para precio -->
                <input type="text" class="form-control" id="precio" name="precio" value="<?php echo htmlspecialchars($propiedad['precio']); ?>" required>
            </div>

            <button type="submit" class="btn btn-primary">Actualizar</button>
            <a href="dashboard.php" class="btn btn-secondary">Cancelar</a>
        </form>
    </div>

    <!-- Pie de Página -->
    <footer class="bg-dark text-white text-center py-3 mt-4">
        <div class="container">
            <p>&copy; 2024 HAM-LP. Todos los derechos reservados.</p>
            <p>
                <a href="#" class="text-white">Política de Privacidad</a> | 
                <a href="#" class="text-white">Términos de Servicio</a>
            </p>
        </div>
    </footer>
    
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
