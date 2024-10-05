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
    public partial class Register_PropiedadR : Form
    {
        public Register_PropiedadR()
        {
            InitializeComponent();
        }

        private void btnAgregarPropiedad_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string id = textId.Text;
            string descripcion = txtDescripcion.Text;
            string direccion = txtDireccion.Text;
            string zona = txtZona.Text;
            string distrito = txtDistrito.Text;
            decimal x_ini, y_ini, x_fin, y_fin, superficie, precio;
            int ci;

            // Validar los campos numéricos
            if (!decimal.TryParse(txtXIni.Text, out x_ini) ||
                !decimal.TryParse(txtYIni.Text, out y_ini) ||
                !decimal.TryParse(txtXFin.Text, out x_fin) ||
                !decimal.TryParse(txtYFin.Text, out y_fin) ||
                !decimal.TryParse(txtSuperficie.Text, out superficie) ||
                !decimal.TryParse(txtPrecio.Text, out precio) ||
                !int.TryParse(txtCi.Text, out ci))
            {
                MessageBox.Show("Por favor, verifica los valores ingresados.");
                return;
            }

        

            // Llamar al método para agregar la propiedad a la base de datos
            AgregarPropiedad(id, descripcion, direccion, zona, distrito, x_ini, y_ini, x_fin, y_fin, superficie, precio, ci);
        }

        // Método para agregar propiedad en la base de datos
        private void AgregarPropiedad(string id, string descripcion, string direccion, string zona, string distrito, decimal x_ini, decimal y_ini, decimal x_fin, decimal y_fin, decimal superficie, decimal precio, int ci)
        {
            // Conexión a la base de datos
            using (SqlConnection conn = new SqlConnection("Server=(local);Database=BDJorge;Integrated Security=True;"))
            {
                conn.Open();
                string query = @"INSERT INTO propiedades (id, descripcion, direccion, zona, distrito, x_ini, y_ini, x_fin, y_fin, superficie, precio, ci)
                                 VALUES (@id, @descripcion, @direccion, @zona, @distrito, @x_ini, @y_ini, @x_fin, @y_fin, @superficie, @precio, @ci)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@zona", zona);
                    cmd.Parameters.AddWithValue("@distrito", distrito);
                    cmd.Parameters.AddWithValue("@x_ini", x_ini);
                    cmd.Parameters.AddWithValue("@y_ini", y_ini);
                    cmd.Parameters.AddWithValue("@x_fin", x_fin);
                    cmd.Parameters.AddWithValue("@y_fin", y_fin);
                    cmd.Parameters.AddWithValue("@superficie", superficie);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@ci", ci);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Propiedad agregada exitosamente.");
                    
                }
                this.Close(); // Cierra el formulario de registro
                // Abrir DashboardRootForm
                DashboardRootForm DashboardRootForm = new DashboardRootForm();
                DashboardRootForm.Show();
               
            }
        }
    }
}
