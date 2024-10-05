// Este archivo está reservado para el JavaScript adicional que puedas necesitar más adelante
console.log("JavaScript cargado correctamente.");
// Añadir funcionalidad adicional si es necesario
$(document).ready(function() {
    // Ejemplo de mostrar alerta en un evento
    $('.dropdown-item').click(function() {
        alert('Opción seleccionada: ' + $(this).text());
    });
});
