<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro de Usuario</title>
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <div class="container mt-5">
        <h2 class="text-center">Registro de Usuario</h2>
        <?php
        // Incluir la conexión a la base de datos
        include('db_connection.php');

        // Verificar si se envió el formulario
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $username = trim($_POST['username']);
            $password = $_POST['password'];
            $confirm_password = $_POST['confirm_password'];
            $ci = trim($_POST['ci']); // CI del usuario
            $ci_persona = trim($_POST['ci']);
            $nombre = trim($_POST['nombre']); // Nombre de la persona
            $paterno = trim($_POST['paterno']); // Apellido paterno de la persona
            $rol = 'normal'; // Establecer el rol directamente como 'normal'

            // Verificar si las contraseñas coinciden
            if ($password != $confirm_password) {
                echo "<div class='alert alert-danger'>Las contraseñas no coinciden.</div>";
            } else {
                // Verificar si ya existe el CI en la tabla Persona para evitar duplicados
                $check_ci = $conn->prepare("SELECT ci FROM Persona WHERE ci = ?");
                $check_ci->bind_param('i', $ci);
                $check_ci->execute();
                $result_ci = $check_ci->get_result();

                if ($result_ci->num_rows > 0) {
                    echo "<div class='alert alert-danger'>El CI ya está registrado.</div>";
                } else {
                    // Hashear la contraseña antes de guardarla por seguridad
                    $hashed_password = password_hash($password, PASSWORD_DEFAULT);

                    // Iniciar una transacción para garantizar que ambos registros (usuario y persona) se hagan o ninguno
                    $conn->begin_transaction();

                    try {
                        // Insertar en la tabla usuarios
                        $sql_usuario = "INSERT INTO usuarios (username, password, rol,ci_persona) VALUES (?, ?, ?,?)";
                        $stmt_usuario = $conn->prepare($sql_usuario);
                        $stmt_usuario->bind_param('sss', $username, $hashed_password, $rol,$ci_persona);
                        $stmt_usuario->execute();

                        // Insertar en la tabla Persona
                        $sql_persona = "INSERT INTO Persona (ci, nombre, paterno) VALUES (?, ?, ?)";
                        $stmt_persona = $conn->prepare($sql_persona);
                        $stmt_persona->bind_param('iss', $ci, $nombre, $paterno);
                        $stmt_persona->execute();

                        // Confirmar la transacción
                        $conn->commit();
                        
                        // Mensaje de éxito y redirección a login.php
                        echo "<div class='alert alert-success'>Usuario y Persona registrados con éxito. Redirigiendo...</div>";
                        header("refresh:3; url=login.php"); // Redirigir después de 3 segundos
                        exit();
                    } catch (Exception $e) {
                        // En caso de error, revertir la transacción
                        $conn->rollback();
                        echo "<div class='alert alert-danger'>Error al registrar: " . $conn->error . "</div>";
                    }
                }
            }
        }
        ?>
        <form action="register.php" method="POST">
            <!-- Datos del Usuario -->
            <div class="form-group">
                <label for="username">Nombre de Usuario:</label>
                <input type="text" class="form-control" id="username" name="username" required>
            </div>
            <div class="form-group">
                <label for="password">Contraseña:</label>
                <input type="password" class="form-control" id="password" name="password" required>
            </div>
            <div class="form-group">
                <label for="confirm_password">Confirmar Contraseña:</label>
                <input type="password" class="form-control" id="confirm_password" name="confirm_password" required>
            </div>

            <!-- Datos de la Persona -->
            <div class="form-group">
                <label for="ci">Cédula de Identidad (CI):</label>
                <input type="number" class="form-control" id="ci" name="ci" required>
            </div>
            <div class="form-group">
                <label for="nombre">Nombre:</label>
                <input type="text" class="form-control" id="nombre" name="nombre" required>
            </div>
            <div class="form-group">
                <label for="paterno">Apellido Paterno:</label>
                <input type="text" class="form-control" id="paterno" name="paterno" required>
            </div>

            <button type="submit" class="btn btn-primary">Registrar</button>
        </form>
    </div>
</body>
</html>
