<?php
session_start();

// Verificar si el usuario ha iniciado sesión
if (!isset($_SESSION['username'])) {
    // Si no está autenticado, redirigir a login.php
    header("Location: login.php");
    exit();
}

// Incluir la conexión a la base de datos
include('db_connection.php');

// Determinar si el usuario es root o funcionario
$isRoot = $_SESSION['is_root'];
$isFuncionario = ($_SESSION['rol'] === 'funcionario');
$ciUsuario = $_SESSION['ci_persona']; // Suponiendo que tienes almacenado el CI del usuario en la sesión

// Si es un funcionario o root, ver todas las propiedades, de lo contrario, solo las propiedades asociadas con su CI
if ($isRoot || $isFuncionario) {
    $propiedades = $conn->query("SELECT * FROM propiedades");
} else {
    // Usuario normal, ver solo sus propiedades
    $propiedades = $conn->prepare("SELECT * FROM propiedades WHERE ci = ?");
    $propiedades->bind_param('i', $ciUsuario);
    $propiedades->execute();
    $propiedades = $propiedades->get_result(); // Obtener el resultado de la consulta
}

// Consultar todos los usuarios si es root
if ($isRoot) {
    // Ordenar los usuarios primero por rol 'root', luego 'funcionario', y finalmente los usuarios normales
    $usuarios = $conn->query("
        SELECT * FROM usuarios
        ORDER BY 
            CASE 
                WHEN rol = 'root' THEN 1
                WHEN rol = 'funcionario' THEN 2
                ELSE 3
            END, username ASC
    ");
}
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Panel de Administración</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <header class="bg-primary text-white text-center py-5 mb-4">
        <div class="container mt-5">
            <div class="header">
                <h1>Panel de Administración</h1>
                <img src="assets/images/logo.jpeg" alt="Logo" class="logo mb-3">
                <p>Bienvenido, <?php echo htmlspecialchars($_SESSION['username']); ?> (<?php echo htmlspecialchars($_SESSION['rol']); ?>)</p>
            </div> 
        </header>

        <?php if ($isRoot) { ?>
            <h3>Usuarios Registrados</h3>
            <table class="table table-bordered table-striped">
                <thead class="thead-light">
                    <tr>
                        <th>Nombre de Usuario</th>
                        <th>Rol</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody id="user-table-body">
                    <?php while ($row = $usuarios->fetch_assoc()) { ?>
                        <tr data-id="<?php echo $row['id']; ?>">
                            <td><?php echo htmlspecialchars($row['username']); ?></td>
                            <td><?php echo htmlspecialchars($row['rol']); ?></td>
                            <td>
                                <a href="editar_usuario.php?id=<?php echo $row['id']; ?>" class="btn btn-warning btn-sm">Editar</a>
                                <a href="eliminar_usuario.php?id=<?php echo $row['id']; ?>" class="btn btn-danger btn-sm delete-user" data-id="<?php echo $row['id']; ?>">Eliminar</a>
                            </td>
                        </tr>
                    <?php } ?>
                </tbody>
            </table>
        <?php } ?>

        <h3>Registros de Propiedades</h3>
        <table class="table table-bordered table-striped">
            <thead class="thead-light">
                <tr>
                    <th>ID Propiedad</th>
                    <th>Descripción</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <?php while ($row = $propiedades->fetch_assoc()) { ?>
                    <tr>
                        <td><?php echo htmlspecialchars($row['id']); ?></td>
                        <td><?php echo htmlspecialchars($row['descripcion']); ?></td>
                        <td>
                        <a href="visualizar_propiedad.php?id=<?php echo $row['id']; ?>" class="btn btn-info btn-sm">Visualizar</a>
                        <!-- Botón Pago Impuesto -->
                        <form action="http://localhost:8080/WebApplication3/NewServlet" method="post" style="display:inline;">
                            <input type="hidden" name="id_propiedad" value="<?php echo htmlspecialchars($row['id']); ?>">
                            <button type="submit" class="btn btn-primary btn-sm">Pago Impuesto</button>
                        </form>

                        <?php if ($_SESSION['rol'] === 'root' || $_SESSION['rol'] === 'funcionario'): ?>
                            <a href="editar_propiedad.php?id=<?php echo $row['id']; ?>" class="btn btn-warning btn-sm">Editar</a>
                            <a href="eliminar_propiedad.php?id=<?php echo $row['id']; ?>" class="btn btn-danger btn-sm" onclick="return confirm('¿Estás seguro de que deseas eliminar esta propiedad?');">Eliminar</a>
                        </td>
                        <?php endif; ?>
                    </tr>
                <?php } ?>
            </tbody>
        </table>

        <div class="text-center">
            <?php if ($_SESSION['rol'] === 'root' || $_SESSION['rol'] === 'funcionario'): ?>
                <a class="btn btn-warning" href="consulta.php">Lista por Tipo de Impuesto</a>
            <?php endif; ?>
            <a class="btn btn-success" href="index.php">Página Principal</a>
            <a href="logout.php" class="btn btn-danger">Cerrar Sesión</a>
        </div>

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
