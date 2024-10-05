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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // btnLogin_Click
        {
            string connectionString = "Server=(local);Database=BDJorge;Integrated Security=True;"; // Actualiza con tu cadena de conexión
            string username = txtUsername.Text;
            string password = txtPassword.Text;  // Contraseña ingresada (sin hash)

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT password, rol FROM usuarios WHERE username=@username"; // Consulta la contraseña y rol
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader["password"].ToString(); // Contraseña guardada en la BD
                        string rol = reader["rol"].ToString();

                        // Verificamos si la contraseña ingresada coincide con la almacenada
                        if (password == storedPassword)
                        {
                            lblMessage.Text = "Inicio de sesión exitoso.";
                            this.Hide(); // Oculta el formulario de login

                            // Redirigir a la pantalla según el rol
                            if (rol == "root")
                            {
                                DashboardRootForm dashboardForm = new DashboardRootForm();
                                dashboardForm.Show();
                            }
                            else if (rol == "funcionario")
                            {
                                PropiedadesFuncionarioForm propiedadesFuncionarioForm = new PropiedadesFuncionarioForm();
                                propiedadesFuncionarioForm.Show();
                            }
                            else if (rol == "normal")
                            {
                                PropiedadesUsuarioForm propiedadesUsuarioForm = new PropiedadesUsuarioForm(username);
                                propiedadesUsuarioForm.Show();
                            }
                        }
                        else
                        {
                            lblMessage.Text = "Contraseña incorrecta.";
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Nombre de usuario no encontrado.";
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(); // Abre el formulario de registro
        }
    }
}
