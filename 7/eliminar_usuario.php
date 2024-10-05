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

    if (isset($_GET['id'])) {
        $id = intval($_GET['id']); // Asegúrate de que $id sea un número entero
    
        // Obtener el CI de la persona asociada al usuario que quieres eliminar
        $sql_ci = "SELECT ci_persona FROM usuarios WHERE id = ?";
        if ($stmt_ci = $conn->prepare($sql_ci)) {
            $stmt_ci->bind_param("i", $id);
            $stmt_ci->execute();
            $stmt_ci->bind_result($ciUsuario);
            $stmt_ci->fetch();
            $stmt_ci->close();
        }
    
        // Verificar que se haya encontrado el CI
        if (!empty($ciUsuario)) {
            // Eliminar el usuario de la base de datos
            $sql = "DELETE FROM usuarios WHERE id = ?";
            $sql1 = "DELETE FROM persona WHERE ci = ?";
    
            // Preparar y ejecutar la consulta para eliminar el usuario
            if ($stmt = $conn->prepare($sql)) {
                $stmt->bind_param("i", $id);
                $stmt->execute();
                $stmt->close();
            }
    
            // Preparar y ejecutar la consulta para eliminar la persona
            if ($stmt1 = $conn->prepare($sql1)) {
                $stmt1->bind_param("i", $ciUsuario);
                $stmt1->execute();
                $stmt1->close();
            }
            
            // Redireccionar al dashboard
            header("Location: dashboard.php");
            exit(); // Asegúrate de salir después de redirigir
        } else {
            echo "<div class='alert alert-danger'>No se encontró el usuario.</div>";
        }
    }
    
    
?>
