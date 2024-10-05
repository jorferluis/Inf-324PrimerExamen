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
    public partial class PropiedadesUsuarioForm : Form
    {
        private string _username;
        public PropiedadesUsuarioForm(string username)
        {
            InitializeComponent();
            _username = username;
            CargarPropiedadesUsuario();
        }
        private void CargarPropiedadesUsuario()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Server=(local);Database=BDJorge;Integrated Security=True;"))
                {
                    conn.Open();

                    // Consulta para obtener el CI de la Persona a partir del username del usuario
                    string queryPersona = @"SELECT u.ci 
                                    FROM usuarios u
                                    WHERE u.username = @username";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn);
                    cmdPersona.Parameters.AddWithValue("@username", _username);

                    object ciResult = cmdPersona.ExecuteScalar();

                    // Verificamos si el resultado es nulo
                    if (ciResult != DBNull.Value && ciResult != null)
                    {
                        int ci = Convert.ToInt32(ciResult);

                        // Ahora usa el CI para obtener las propiedades asociadas a esa persona
                        string queryPropiedades = @"SELECT * FROM propiedades WHERE ci = @ci";
                        SqlCommand cmdPropiedades = new SqlCommand(queryPropiedades, conn);
                        cmdPropiedades.Parameters.AddWithValue("@ci", ci);

                        SqlDataAdapter da = new SqlDataAdapter(cmdPropiedades);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridViewPropiedades.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("El usuario no tiene propiedades asociadas.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una persona asociada al usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
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
    }
}
