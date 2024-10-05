<?php
session_start();

// Verificar si el usuario ha iniciado sesión
if (!isset($_SESSION['username'])) {
    // Si no está autenticado, redirigir a login.php
    header("Location: login.php");
    exit();
}

?>

<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Consulta de Trámites</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <!-- Encabezado -->
    <header class="bg-primary text-white text-center py-5 mb-4">
        <div class="container mt-5">
            <div class="header">
                <h1>Consulta de Trámites</h1>
                <img src="assets/images/logo.jpeg" alt="Logo" class="logo mb-3">
                <p>Bienvenido, <?php echo htmlspecialchars($_SESSION['username']); ?> (<?php echo htmlspecialchars($_SESSION['rol']); ?>)</p>
            </div>
        </div>
    </header>

    <!-- Contenido -->
    <div class="container">
        <h3>Información sobre el Registro de Propiedades y Trámites</h3>
        <div class="alert alert-info">
            <h4>Registro de Propiedades</h4>
            <p>Para registrar una nueva propiedad en el sistema, es importante seguir los siguientes pasos:</p>
            <ol>
                <li>Acceder al panel de administración con su cuenta de usuario.</li>
                <li>Seleccionar la opción <strong>"Registrar Propiedad"</strong>.</li>
                <li>Completar los siguientes campos del formulario de registro:
                    <ul>
                        <li><strong>ID de la Propiedad</strong>: Este campo debe contener un número único entre 100,000 y 400,000.</li>
                        <li><strong>Descripción</strong>: Breve descripción de la propiedad, como su tipo (casa, apartamento, terreno, etc.).</li>
                        <li><strong>Dirección</strong>: Dirección física de la propiedad.</li>
                        <li><strong>Zona</strong>: Zona o barrio donde se ubica la propiedad.</li>
                        <li><strong>Distrito</strong>: Distrito en el que se encuentra la propiedad.</li>
                        <li><strong>Coordenadas</strong>: Deben ingresarse las coordenadas X e Y (inicial y final) que delimitan la ubicación exacta.</li>
                        <li><strong>Superficie</strong>: Área total de la propiedad en metros cuadrados.</li>
                        <li><strong>Precio</strong>: Precio de venta o alquiler de la propiedad.</li>
                        <li><strong>Cédula de Identidad (CI)</strong>: Número de CI de la persona propietaria de la propiedad.</li>
                    </ul>
                </li>
                <li>Una vez completado el formulario, hacer clic en el botón <strong>"Registrar"</strong> para guardar la nueva propiedad.</li>
            </ol>
        </div>

        <div class="alert alert-info mt-4">
            <h4>Gestión de Trámites</h4>
            <p>En la plataforma también puede realizar y consultar el estado de los trámites relacionados con las propiedades. Algunos de los trámites comunes incluyen:</p>
            <ul>
                <li><strong>Solicitud de Registro</strong>: Se puede solicitar el registro de una nueva propiedad o el cambio de titularidad.</li>
                <li><strong>Actualización de Información</strong>: Para actualizar detalles como la dirección, superficie o precio de una propiedad existente.</li>
                <li><strong>Solicitud de Certificados</strong>: Solicitud de documentos como certificados de propiedad, avalúos, entre otros.</li>
                <li><strong>Verificación de Propiedad</strong>: Trámite para verificar la autenticidad o estatus legal de una propiedad.</li>
            </ul>
            <p>El proceso general para cualquier trámite es el siguiente:</p>
            <ol>
                <li>Seleccionar la opción <strong>"Registrar Trámite"</strong>.</li>
                <li>Completar los datos requeridos en el formulario, como el tipo de trámite, la propiedad asociada, y detalles específicos del trámite.</li>
                <li>Enviar la solicitud y hacer seguimiento del estado del trámite en la sección de <strong>"Trámites en Proceso"</strong>.</li>
            </ol>
            <p>El sistema notificará el estado del trámite, que puede estar en uno de los siguientes estados:</p>
            <ul>
                <li><strong>En Proceso</strong>: El trámite ha sido recibido y está en revisión.</li>
                <li><strong>Completado</strong>: El trámite ha sido finalizado satisfactoriamente.</li>
                <li><strong>Rechazado</strong>: El trámite no ha sido aprobado por alguna razón. Puede consultar el motivo en la sección de detalles.</li>
            </ul>
        </div>

        <div class="text-center mt-4">
            <a href="logout.php" class="btn btn-danger">Cerrar Sesión</a>
            <a class="btn btn-success" href="index.php">Página Principal</a>
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
