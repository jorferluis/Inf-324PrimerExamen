<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro de Usuario</title>
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
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
            $nombre = trim($_POST['nombre']); // Nombre de la persona
            $paterno = trim($_POST['paterno']); // Apellido paterno de la persona
            $distrito = trim($_POST['distrito']); // Distrito de la persona
            $zona = trim($_POST['zona']); // Zona de la persona
            $rol = 'normal'; // Establecer el rol directamente como 'normal'

            // Verificar si las contraseñas coinciden
            if ($password != $confirm_password) {
                echo "<div class='alert alert-danger'>Las contraseñas no coinciden.</div>";
            } else {
                // Hashear la contraseña antes de guardarla por seguridad
                $hashed_password = password_hash($password, PASSWORD_DEFAULT);

                // Iniciar una transacción para garantizar que ambos registros (usuario y persona) se hagan o ninguno
                $conn->begin_transaction();

                try {
                    // Insertar primero en la tabla Persona
                    $sql_persona = "INSERT INTO Persona (ci, nombre, paterno, distrito, zona) VALUES (?, ?, ?, ?, ?)";
                    $stmt_persona = $conn->prepare($sql_persona);
                    $stmt_persona->bind_param('issss', $ci, $nombre, $paterno, $distrito, $zona);
                    $stmt_persona->execute();

                    // Comprobar si se insertó correctamente en Persona
                    if ($stmt_persona->affected_rows === 0) {
                        throw new Exception("Error al insertar en Persona: " . $stmt_persona->error);
                    }

                    // Insertar en la tabla usuarios
                    $sql_usuario = "INSERT INTO usuarios (username, password, rol, ci_persona) VALUES (?, ?, ?, ?)";
                    $stmt_usuario = $conn->prepare($sql_usuario);
                    $stmt_usuario->bind_param('ssss', $username, $hashed_password, $rol, $ci);
                    $stmt_usuario->execute();

                    // Comprobar si se insertó correctamente en usuarios
                    if ($stmt_usuario->affected_rows === 0) {
                        throw new Exception("Error al insertar en usuarios: " . $stmt_usuario->error);
                    }

                    // Confirmar la transacción
                    $conn->commit();
                    
                    // Mensaje de éxito y redirección a login.php
                    echo "<div class='alert alert-success'>Usuario y Persona registrados con éxito. Redirigiendo...</div>";
                    header("refresh:3; url=login.php"); // Redirigir después de 3 segundos
                    exit();
                } catch (Exception $e) {
                    // En caso de error, revertir la transacción
                    $conn->rollback();
                    echo "<div class='alert alert-danger'>Error al registrar: " . $e->getMessage() . "</div>";
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

            <!-- Combo para seleccionar la Zona -->
            <div class="form-group">
                <label for="zona">Zona:</label>
                <select class="form-control" id="zona" name="zona" required>
                    <option value="">Selecciona una zona</option>
                    <option value="Centro">Centro</option>
                    <option value="Sur">Sur</option>
                    <option value="Periférica">Periférica</option>
                    <option value="Max Paredes">Max Paredes</option>
                    <option value="San Antonio">San Antonio</option>
                </select>
            </div>

            <!-- Combo para seleccionar el Distrito -->
            <div class="form-group">
                <label for="distrito">Distrito:</label>
                <select class="form-control" id="distrito" name="distrito" required>
                    <option value="">Selecciona un distrito</option>
                    <!-- Los distritos se agregarán aquí dinámicamente mediante AJAX -->
                </select>
            </div>

            <button type="submit" class="btn btn-primary">Registrar</button>
        </form>
    </div>

    <script>
        // Actualizar los distritos cuando se seleccione una zona
        $('#zona').on('change', function() {
            const zonaSeleccionada = $(this).val();

            // Realizar la solicitud AJAX para obtener los distritos
            $.ajax({
                url: 'get_distritos.php', // Ruta del archivo PHP que maneja la lógica
                type: 'GET',
                data: { zona: zonaSeleccionada },
                success: function(distritos) {
                    // Limpiar el menú desplegable de distritos
                    const $distritoSelect = $('#distrito');
                    $distritoSelect.empty();

                    // Agregar opción predeterminada
                    $distritoSelect.append('<option value="">Selecciona un distrito</option>');

                    // Agregar los distritos correspondientes
                    distritos.forEach(function(distrito) {
                        $distritoSelect.append('<option value="' + distrito + '">' + distrito + '</option>');
                    });
                },
                error: function(xhr, status, error) {
                    console.error("Error en la solicitud AJAX:", error);
                    alert('No se pudieron cargar los distritos. Intenta nuevamente.');
                }
            });
        });
    </script>
</body>
</html>
