<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <div class="container mt-5">
        <h2 class="text-center">Iniciar Sesión</h2>
        <?php
        session_start(); // Iniciar la sesión

        // Incluir la conexión a la base de datos
        include('db_connection.php');

        // Verificar si se envió el formulario
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $username = trim($_POST['username']); // Recoger y eliminar espacios en blanco
            $password = $_POST['password']; // Recoger la contraseña

            // Consulta para obtener el usuario
            $sql = "SELECT * FROM usuarios WHERE username = ?";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param('s', $username);
            $stmt->execute();
            $result = $stmt->get_result();
            
            // Verificar si se encontró el usuario
            if ($result->num_rows == 1) {
                $user = $result->fetch_assoc();
                
                // Verificar la contraseña
                // Utiliza password_verify solo si la contraseña en la base de datos está hasheada
                if (password_verify($password, $user['password']))  {
                    // Iniciar sesión y almacenar la información del usuario
                    $_SESSION['username'] = $user['username'];
                    $_SESSION['rol'] = $user['rol']; // Almacena el rol del usuario
                    $_SESSION['is_root'] = ($user['rol'] === 'root'); // Almacena si es root
                    $_SESSION['ci_persona'] = $user['ci_persona'];

                    $ciUsuario = isset($_SESSION['ci_persona']) ? $_SESSION['ci_persona'] : null;
                    if ($ciUsuario === null) {
                        echo "Error: El CI del usuario no está disponible.";
                        // Puedes redirigir al usuario a la página de inicio de sesión o manejar el error según sea necesario
                    }
                    
                    // Redirigir según el rol del usuario
                    if ($_SESSION['is_root']) {
                        // Si es root, redirigir a dashboard.php
                        header("Location: dashboard.php");
                    }elseif ($user['rol'] === 'funcionario') {
                        // Si es funcionario, redirigir a dashboard_funcionario.php
                        header("Location: dashboard.php");
                    }else {
                        // Si es un usuario normal o funcionario, redirigir a index.php o dashboard_funcionario.php
                        header("Location: index.php");
                    }
                    exit();
                } else {
                    echo "<div class='alert alert-danger'>Contraseña incorrecta.</div>";
                }
            } else {
                echo "<div class='alert alert-danger'>El usuario no existe.</div>";
            }
        }
        ?>
        <form action="login.php" method="POST">
            <div class="form-group">
                <label for="username">Nombre de Usuario:</label>
                <input type="text" class="form-control" id="username" name="username" required>
            </div>
            <div class="form-group">
                <label for="password">Contraseña:</label>
                <input type="password" class="form-control" id="password" name="password" required>
            </div>
            <button type="submit" class="btn btn-primary">Iniciar Sesión</button>
        </form>
        
        <!-- Enlace para registrarse -->
        <div class="text-center mt-3">
            <p>¿No tienes una cuenta? <a href="register.php">Regístrate aquí</a></p>
        </div>
    </div>
</body>
</html>
