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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=(local);Database=BDJorge;Integrated Security=True";
            string username = txtUsername.Text;
            string password = txtPassword.Text; // Debes cifrar la contraseña antes de guardarla
            string ci = txtCi.Text;
            string nombre = txtNombre.Text;
            string paterno = txtPaterno.Text;
            string distrito = txtDistrito.Text;
            string zona = txtZona.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Primero insertamos en la tabla persona
                string queryPerson = "INSERT INTO persona (ci, nombre, paterno, distrito, zona) VALUES (@ci, @nombre, @paterno, @distrito, @zona)";
                SqlCommand commandPerson = new SqlCommand(queryPerson, connection);
                commandPerson.Parameters.AddWithValue("@ci", ci);
                commandPerson.Parameters.AddWithValue("@nombre", nombre);
                commandPerson.Parameters.AddWithValue("@paterno", paterno);
                commandPerson.Parameters.AddWithValue("@distrito", distrito);
                commandPerson.Parameters.AddWithValue("@zona", zona);

                commandPerson.ExecuteNonQuery();

                // Después insertamos en la tabla usuarios
                string queryUser = "INSERT INTO usuarios (username, password, rol, ci) VALUES (@username, @password, 'normal', @ci)";
                SqlCommand commandUser = new SqlCommand(queryUser, connection);
                commandUser.Parameters.AddWithValue("@username", username);
                commandUser.Parameters.AddWithValue("@password", password);
                commandUser.Parameters.AddWithValue("@ci", ci);

                commandUser.ExecuteNonQuery();

                MessageBox.Show("Usuario registrado exitosamente.");
                this.Close(); // Cierra el formulario de registro
            }
        }
    }
}
