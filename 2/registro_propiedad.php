<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro de Propiedad</title>
    <!-- Bootstrap -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <!-- jQuery para el manejo de zonas y distritos -->
    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
</head>
<body>
    <div class="container mt-5">
        <h2 class="text-center">Registro de Propiedad</h2>
        <?php
        // Incluir la conexión a la base de datos
        include('db_connection.php');

        // Verificar si se envió el formulario
        if ($_SERVER['REQUEST_METHOD'] == 'POST') {
            $descripcion = trim($_POST['descripcion']);
            $direccion = trim($_POST['direccion']);
            $zona = trim($_POST['zona']);
            $distrito = trim($_POST['distrito']);
            $x_ini = trim($_POST['x_ini']);
            $y_ini = trim($_POST['y_ini']);
            $x_fin = trim($_POST['x_fin']);
            $y_fin = trim($_POST['y_fin']);
            $superficie = trim($_POST['superficie']);
            $precio = trim($_POST['precio']);
            $ci = trim($_POST['ci']);

            // Generar automáticamente el id en el rango permitido
            $sql = "SELECT MAX(id) AS max_id FROM propiedades";
            $result = $conn->query($sql);
            $row = $result->fetch_assoc();

            // Si hay propiedades registradas, se incrementa el último ID
            $new_id = $row['max_id'] ? $row['max_id'] + 1 : 100000;

            // Verificar que el nuevo ID no exceda el rango
            if ($new_id > 400000) {
                die("No es posible registrar más propiedades. Se ha alcanzado el límite.");
            }

            // Después, se puede usar $new_id para la nueva propiedad
            // Insertar los datos en la tabla propiedades, sin el campo precio
            $sql = "INSERT INTO propiedades (id, descripcion, direccion, zona, distrito, x_ini, y_ini, x_fin, y_fin, superficie, precio, ci) 
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            $stmt = $conn->prepare($sql);
            $stmt->bind_param('issssdddddi', $new_id, $descripcion, $direccion, $zona, $distrito, $x_ini, $y_ini, $x_fin, $y_fin, $superficie, $precio, $ci);

            if ($stmt->execute()) {
                echo "<div class='alert alert-success'>Propiedad registrada con éxito. ID de la propiedad: $new_id</div>";
                header("Location: dashboard.php"); 
            } else {
                echo "<div class='alert alert-danger'>Error al registrar la propiedad: " . $conn->error . "</div>";
            }
        }
        ?>

        <form action="registro_propiedad.php" method="POST">
            <!-- Datos de la Propiedad -->
            <div class="form-group">
                <label for="descripcion">Descripción de la Propiedad:</label>
                <input type="text" class="form-control" id="descripcion" name="descripcion" required>
            </div>
            <div class="form-group">
                <label for="direccion">Dirección:</label>
                <input type="text" class="form-control" id="direccion" name="direccion">
            </div>

            <!-- Selección de Zona y Distrito -->
            <div class="form-group">
                <label for="zona">Zona:</label>
                <select class="form-control" id="zona" name="zona" required>
                    <option value="">Selecciona una zona</option>
                    <option value="Centro">Centro</option>
                    <option value="Sur">Sur</option>
                    <option value="Periférica">Periférica</option>
                    <option value="Max Paredes">Max Paredes</option>
                    <option value="San Antonio">San Antonio</option>
                    <!-- Agrega otras zonas según lo necesario -->
                </select>
            </div>

            <div class="form-group">
                <label for="distrito">Distrito:</label>
                <select class="form-control" id="distrito" name="distrito" required>
                    <option value="">Selecciona un distrito</option>
                    <!-- Los distritos se actualizarán dinámicamente en base a la zona seleccionada -->
                </select>
            </div>

            <!-- Coordenadas y Superficie -->
            <div class="form-group">
                <label for="x_ini">Coordenada X Inicial:</label>
                <input type="number" step="0.000001" class="form-control" id="x_ini" name="x_ini" required>
            </div>
            <div class="form-group">
                <label for="y_ini">Coordenada Y Inicial:</label>
                <input type="number" step="0.000001" class="form-control" id="y_ini" name="y_ini" required>
            </div>
            <div class="form-group">
                <label for="x_fin">Coordenada X Final:</label>
                <input type="number" step="0.000001" class="form-control" id="x_fin" name="x_fin" required>
            </div>
            <div class="form-group">
                <label for="y_fin">Coordenada Y Final:</label>
                <input type="number" step="0.000001" class="form-control" id="y_fin" name="y_fin" required>
            </div>
            <div class="form-group">
                <label for="superficie">Superficie (en m²):</label>
                <input type="number" step="0.01" class="form-control" id="superficie" name="superficie" required>
            </div>
            <div class="form-group">
                <label for="precio">Precio:</label>
                <input type="text" name="precio" id="precio" class="form-control" required>
            </div>
            <!-- Cédula de Identidad del Propietario -->
            <div class="form-group">
                <label for="ci">Cédula de Identidad del Propietario:</label>
                <input type="number" class="form-control" id="ci" name="ci" required>
            </div>

            <button type="submit" class="btn btn-primary">Registrar Propiedad</button>
        </form>
    </div>

    <script>
        // Mapeo de zonas y distritos
        const distritosPorZona = {
            'Centro': ['Distrito 1', 'Distrito 2', 'Distrito 3'],
            'Sur': ['Distrito 4', 'Distrito 5', 'Distrito 6'],
            'Periférica': ['Distrito 7', 'Distrito 8', 'Distrito 9'],
            'Max Paredes': ['Distrito 10', 'Distrito 11'],
            'San Antonio': ['Distrito 12', 'Distrito 13', 'Distrito 14']
            // Agrega más zonas y distritos según sea necesario
        };

        // Actualizar los distritos cuando se seleccione una zona
        $('#zona').on('change', function() {
            const zonaSeleccionada = $(this).val();
            const distritos = distritosPorZona[zonaSeleccionada] || [];

            // Limpiar el menú desplegable de distritos
            const $distritoSelect = $('#distrito');
            $distritoSelect.empty();

            // Agregar opción predeterminada
            $distritoSelect.append('<option value="">Selecciona un distrito</option>');

            // Agregar los distritos correspondientes
            distritos.forEach(function(distrito) {
                $distritoSelect.append('<option value="' + distrito + '">' + distrito + '</option>');
            });
        });
    </script>
</body>
</html>
