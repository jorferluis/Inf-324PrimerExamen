import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

@WebServlet(urlPatterns = {"/NewServlet"})
public class NewServlet extends HttpServlet {
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            // Obtener el ID de la propiedad
            String idPropiedad = request.getParameter("id_propiedad");

            // Determinar el tipo de impuesto basado en el primer dígito
            String tipoImpuesto = "Tipo de impuesto desconocido";
            if (idPropiedad != null && !idPropiedad.isEmpty()) {
                // Obtener el primer dígito del ID
                char primerDigito = idPropiedad.charAt(0);
                
                if (primerDigito == '1') {
                    tipoImpuesto = "Impuesto Alto";
                } else if (primerDigito == '2') {
                    tipoImpuesto = "Impuesto Medio";
                } else if (primerDigito == '3') {
                    tipoImpuesto = "Impuesto Bajo";
                }
            }

            // Generar la respuesta HTML
            out.println("<!DOCTYPE html>");
            out.println("<html lang='es'>");
            out.println("<head>");
            out.println("<meta charset='UTF-8'>");
            out.println("<meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>");
            out.println("<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css'>");
            out.println("<title>Tipo de Impuesto</title>");
            out.println("</head>");
            out.println("<body>");

            // Cabecera
            out.println("<nav class='navbar navbar-expand-lg navbar-light bg-light'>");
            out.println("    <a class='navbar-brand' href='#'><img src='images/logo.jpeg' width='30' height='30' alt='Logo'> Información General de la HAM-LP</a>");
            out.println("    <button class='navbar-toggler' type='button' data-toggle='collapse' data-target='#navbarNav' aria-controls='navbarNav' aria-expanded='false' aria-label='Toggle navigation'>");
            out.println("        <span class='navbar-toggler-icon'></span>");
            out.println("    </button>");
            out.println("</nav>");


            // Contenido Principal
            out.println("<div class='container mt-5'>");
            out.println("<h1 class='text-center'>Tipo de Impuesto para la Propiedad ID: " + idPropiedad + "</h1>");
            out.println("<p class='lead text-center'>" + tipoImpuesto + "</p>");
            out.println("<div class='text-center'>");
            out.println("    <a href='http://localhost:81/pexa/dashboard.php' class='btn btn-primary'>Volver al Panel de Administración</a>");
            out.println("</div>");
            out.println("</div>");

           
        }
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    public String getServletInfo() {
        return "Servlet para procesar el tipo de impuesto de la propiedad";
    }
}
