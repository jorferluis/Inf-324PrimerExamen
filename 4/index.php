<?php
    session_start(); // Iniciar la sesión al principio del archivo
    // Verificar si el usuario ha iniciado sesión
    if (!isset($_SESSION['username'])) {
        // Si no hay sesión, redirigir a login.php
        header("Location: login.php");
        exit();
    }

    // Asumiendo que el rol se almacena en la variable de sesión 'rol'
    // Ejemplo: $_SESSION['rol'] puede ser 'admin', 'normal', etc.
?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>HAM-LP - Información General</title>
    <!-- Incluir Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <!-- Incluir el CSS personalizado -->
    <link rel="stylesheet" href="assets/css/styles.css">
</head>
<body>

    <!-- Cabecera -->
    <header class="bg-primary text-white text-center py-5 mb-4">
        <div class="container">
            <img src="assets/images/logo.jpeg" alt="Logo" class="logo mb-3">
            <h1 class="display-4">Información General de la HAM-LP</h1>
            <p class="lead">Tu entidad de confianza para la gestión catastral</p>
        </div>
    </header>

    <!-- Barra de Navegación con Submenús -->
    <nav class="navbar navbar-expand-lg navbar-light bg-light shadow-sm">
        <div class="container">
            <a class="navbar-brand" href="#">HAM-LP</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav">
                    <!-- Pestaña Inicio con Submenú -->
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="inicioDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Inicio
                        </a>
                        <div class="dropdown-menu" aria-labelledby="inicioDropdown">
                            <a class="dropdown-item" href="#">Información General</a>
                            <a class="dropdown-item" href="#">Noticias</a>
                            <a class="dropdown-item" href="#">Eventos</a>
                        </div>
                    </li>
                    <!-- Pestaña Trámites y Servicios -->
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="tramitesDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            Trámites y Servicios
                        </a>
                        <div class="dropdown-menu" aria-labelledby="tramitesDropdown">
                            <!-- Verificar si el usuario tiene rol admin para mostrar el enlace de registro de propiedad -->
                            <?php if ($_SESSION['rol'] === 'admin'): ?>
                                <a class="dropdown-item" href="registro_propiedad.php">Registro de Propiedad</a>
                            <?php else: ?>
                                <span class="dropdown-item">Registro de Propiedad (no disponible)</span>
                            <?php endif; ?>
                            <a class="dropdown-item" href="dashboard.php">Consulta de Propiedad</a>
                            <a class="dropdown-item" href="dashboard.php">Actualización de Datos</a>
                            <a class="dropdown-item" href="consulta_tramites.php">Consulta de Trámites</a>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Gobierno Abierto</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Normativa</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Contáctanos</a>
                    </li>
                </ul>

                <!-- Botón de Inicio/Cierre de Sesión -->
                <ul class="navbar-nav ml-auto">
                    <?php if (isset($_SESSION['username'])): ?>
                        <li class="nav-item">
                            <span class="nav-link">Bienvenido, <?php echo $_SESSION['username']; ?></span>
                        </li>
                        <li class="nav-item">
                            <a class="btn btn-success" href="dashboard.php">Propiedades</a>
                        </li>
                        <li class="nav-item">
                            <a class="btn btn-danger" href="logout.php">Cerrar Sesión</a>
                        </li>
                    <?php else: ?>
                        <li class="nav-item">
                            <a class="btn btn-primary" href="login.html">Iniciar Sesión</a>
                        </li>
                    <?php endif; ?>
                </ul>
            </div>
        </div>
    </nav>

    <!-- Contenedor Principal -->
    <div class="container mt-5">
        <h2 class="text-primary">Sobre la HAM-LP</h2>
        <p>
            La HAM-LP es una entidad dedicada a la gestión y administración de catastro y propiedad, 
            garantizando el desarrollo ordenado y sostenible de la región. Proporciona servicios 
            relacionados con el registro de propiedades, control de pagos de impuestos y asistencia a 
            los ciudadanos en temas catastrales.
        </p>

        <h3 class="text-secondary">Tipos de Trámites</h3>
        <table class="table table-bordered table-striped">
            <thead class="thead-light">
                <tr>
                    <th>ID</th>
                    <th>Tipo de Trámite</th>
                    <th>Descripción</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>
                        <!-- Mostrar el texto si el usuario no es admin -->
                        <?php if ($_SESSION['rol'] === 'root' or $_SESSION['rol'] === 'funcionario'): ?>
                            <a href="registro_propiedad.php">Registro de Propiedad</a>
                        <?php else: ?>
                            Registro de Propiedad 
                        <?php endif; ?>
                    </td>
                    <td>Proceso para registrar una nueva propiedad en el catastro.</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td><a href="dashboard.php">Consulta de Propiedad</a></td>
                    <td>Consulta de información relacionada a una propiedad registrada.</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td><a href="dashboard.php">Pago de Impuesto</a></td>
                    <td>Proceso para realizar el pago del impuesto sobre propiedades.</td>
                </tr>
                <tr>
                    <td>4</td>
                    <td><a href="dashboard.php">Actualización de Datos</a></td>
                    <td>Actualización de la información catastral de una propiedad.</td>
                </tr>
                <tr>
                    <td>5</td>
                    <td><a href="consulta_tramites.php">Consulta de Trámites</a></td>
                    <td>Consulta sobre el estado de los trámites realizados.</td>
                </tr>
            </tbody>
        </table>

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

    <!-- Incluir jQuery y Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.3/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <!-- Incluir el JavaScript personalizado -->
    <script src="assets/js/scripts.js"></script>
</body>
</html>
