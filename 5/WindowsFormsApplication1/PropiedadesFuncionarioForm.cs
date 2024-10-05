using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PropiedadesFuncionarioForm : Form
    {
        public PropiedadesFuncionarioForm()
        {
            InitializeComponent();
            CargarPropiedades();
            dataGridViewPropiedades.SelectionChanged += dataGridViewPropiedades_SelectionChanged;
        }

        private void CargarPropiedades()
         {
             string connectionString = "Server=(local);Database=BDJorge;Integrated Security=True;";

             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 connection.Open();
                 string query = "SELECT id, descripcion, direccion, zona, distrito, x_ini, y_ini, x_fin, y_fin, superficie, precio, ci FROM propiedades";
                 SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                 DataTable dt = new DataTable();
                 adapter.Fill(dt);

                 // Asignar los datos al DataGridView u otro control en tu interfaz
                 dataGridViewPropiedades.DataSource = dt;
             }
        }

       

        private void dataGridViewPropiedades_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (dataGridViewPropiedades.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow selectedRow = dataGridViewPropiedades.SelectedRows[0];

                // Rellena los TextBox con los valores de la fila seleccionada
                // txtNombrePropiedad.Text = selectedRow.Cells["nombre"].Value.ToString();
                txtDescripcion.Text = selectedRow.Cells["descripcion"].Value.ToString();
                txtDireccion.Text = selectedRow.Cells["direccion"].Value.ToString();
                txtZona.Text = selectedRow.Cells["zona"].Value.ToString();
                txtDistrito.Text = selectedRow.Cells["distrito"].Value.ToString();
                txtCI.Text = selectedRow.Cells["ci"].Value.ToString();

                // Convierte y rellena los valores de las coordenadas y superficie
                txtXIni.Text = selectedRow.Cells["x_ini"].Value.ToString();
                txtYIni.Text = selectedRow.Cells["y_ini"].Value.ToString();
                txtXFin.Text = selectedRow.Cells["x_fin"].Value.ToString();
                txtYFin.Text = selectedRow.Cells["y_fin"].Value.ToString();
                txtSuperficie.Text = selectedRow.Cells["superficie"].Value.ToString();
                txtPrecioPropiedad.Text = selectedRow.Cells["precio"].Value.ToString();
            }
        }


        private void btnEliminarPropiedad_Click_1(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada en el DataGridView de propiedades
            if (dataGridViewPropiedades.SelectedRows.Count > 0)
            {
                // Obtiene el ID de la propiedad desde la fila seleccionada en el DataGridView
                int selectedPropertyId = Convert.ToInt32(dataGridViewPropiedades.SelectedRows[0].Cells["id"].Value);

                // Cadena de conexión a la base de datos
                string connectionString = "Server=(local);Database=BDJorge;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para eliminar la propiedad
                    string query = "DELETE FROM propiedades WHERE id=@propertyId";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Agregar el parámetro
                    command.Parameters.AddWithValue("@propertyId", selectedPropertyId);

                    // Ejecuta la consulta de eliminación
                    int result = command.ExecuteNonQuery();

                    // Verifica si la eliminación fue exitosa
                    if (result > 0)
                    {
                        MessageBox.Show("Propiedad eliminada exitosamente.");
                        // Lógica para refrescar la lista de propiedades
                        CargarPropiedades(); // Asegúrate de que este método esté implementado
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la propiedad.");
                    }
                }
            }
            else
            {
                // Mensaje si no se selecciona una fila
                MessageBox.Show("Por favor, selecciona una propiedad para eliminar.");
            }
        }

        private void btnEditarPropiedad_Click_1(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada en el DataGridView de propiedades
            if (dataGridViewPropiedades.SelectedRows.Count > 0)
            {
                // Obtiene el ID de la propiedad desde la fila seleccionada en el DataGridView
                int selectedPropertyId = Convert.ToInt32(dataGridViewPropiedades.SelectedRows[0].Cells["id"].Value);

                // Obtiene los nuevos valores de los TextBox
                string newPropertyName = txtDescripcion.Text.Trim();
                string newDescription = txtDescripcion.Text.Trim(); // TextBox para descripción
                string newAddress = txtDireccion.Text.Trim(); // TextBox para dirección
                string newZone = txtZona.Text.Trim(); // TextBox para zona
                string newDistrict = txtDistrito.Text.Trim(); // TextBox para distrito
                string newCi = txtCI.Text.Trim(); // TextBox para CI (nueva línea para el campo CI)
                decimal newXIni, newYIni, newXFin, newYFin, newSurface, newPrice;


                // Asegúrate de manejar el caso donde el precio no sea válido
                if (!decimal.TryParse(txtPrecioPropiedad.Text, out newPrice))
                {
                    MessageBox.Show("Por favor, ingresa un precio válido.");
                    return;
                }

                // Asegúrate de que las coordenadas y la superficie sean válidas
                if (!decimal.TryParse(txtXIni.Text, out newXIni) ||
                    !decimal.TryParse(txtYIni.Text, out newYIni) ||
                    !decimal.TryParse(txtXFin.Text, out newXFin) ||
                    !decimal.TryParse(txtYFin.Text, out newYFin) ||
                    !decimal.TryParse(txtSuperficie.Text, out newSurface))
                {
                    MessageBox.Show("Por favor, ingresa valores válidos para las coordenadas y la superficie.");
                    return;
                }

                // Cadena de conexión a la base de datos
                string connectionString = "Server=(local);Database=BDJorge;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para actualizar la propiedad
                    string query = @"UPDATE propiedades 
                             SET nombre=@newName, 
                                 descripcion=@newDescription, 
                                 direccion=@newAddress, 
                                 zona=@newZone, 
                                 distrito=@newDistrict, 
                                 x_ini=@newXIni, 
                                 y_ini=@newYIni, 
                                 x_fin=@newXFin, 
                                 y_fin=@newYFin, 
                                 superficie=@newSurface, 
                                 precio=@newPrice,
                                 ci=@newCi
                             WHERE id=@propertyId";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Agregar parámetros
                    command.Parameters.AddWithValue("@propertyId", selectedPropertyId);
                    command.Parameters.AddWithValue("@newName", newPropertyName);
                    command.Parameters.AddWithValue("@newDescription", newDescription);
                    command.Parameters.AddWithValue("@newAddress", newAddress);
                    command.Parameters.AddWithValue("@newZone", newZone);
                    command.Parameters.AddWithValue("@newDistrict", newDistrict);
                    command.Parameters.AddWithValue("@newXIni", newXIni);
                    command.Parameters.AddWithValue("@newYIni", newYIni);
                    command.Parameters.AddWithValue("@newXFin", newXFin);
                    command.Parameters.AddWithValue("@newYFin", newYFin);
                    command.Parameters.AddWithValue("@newSurface", newSurface);
                    command.Parameters.AddWithValue("@newPrice", newPrice);

                    // Ejecuta la consulta de actualización
                    int result = command.ExecuteNonQuery();

                    // Verifica si la actualización fue exitosa
                    if (result > 0)
                    {
                        MessageBox.Show("Propiedad editada exitosamente.");
                        // Lógica para refrescar la lista de propiedades
                        CargarPropiedades(); // Asegúrate de que este método esté implementado
                    }
                    else
                    {
                        MessageBox.Show("Error al editar la propiedad.");
                    }
                }
            }
            else
            {
                // Mensaje si no se selecciona una fila
                MessageBox.Show("Por favor, selecciona una propiedad para editar.");
            }
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            // Cerrar la forma actual
            this.Close();

            // Abrir Form1
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            // Cerrar la forma actual
            this.Close();

            // Abrir Register_Usuario
            Register_PropiedadR registerpropiedad = new Register_PropiedadR();
            registerpropiedad.Show();
        }
   }
}
    