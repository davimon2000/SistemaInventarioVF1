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

namespace GestionInventario
{
    public partial class FormMiusuario : Form
    {
        //string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        string connectionString = Conexion.cadena;
        string nombre;
        int SedeId;
        public bool ModoForzado = false;

        private static FormMiusuario instancia = null;
        public static FormMiusuario ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormMiusuario();
                return instancia;
            }
            return instancia;
        }


        public FormMiusuario()
        {
            InitializeComponent();
        }

        private void FormMiusuario_Load(object sender, EventArgs e)
        {
            if (ModoForzado)
            {
                this.ControlBox = false; // ❌ no puede cerrar
                this.Text = "Cambio obligatorio de contraseña";
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();

                string queryId = "SELECT NombreCompleto, SedeId FROM Usuarios WHERE Usuario = @usuario";
                using (SqlCommand cmd = new SqlCommand(queryId, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", Form3Login.UsuarioActual);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            //int SedeId = reader.GetInt32(1);

                            lblNombre.Text = nombre;
                        }
                    }

                        //object result = cmd.ExecuteScalar();

                        string queryIdNombreSede = "SELECT NombreSede FROM Sedes WHERE Id = @SedeId";
                        using (SqlCommand cmdSede = new SqlCommand(queryIdNombreSede, conn))
                        {
                            cmdSede.Parameters.AddWithValue("@SedeId", Form3Login.SedeIdUsuarioSistema);

                            object result = cmdSede.ExecuteScalar();
                            String sedeNombre = (string)result;

                            conn.Close();

                            //lblNombre.Text = nombre;
                            lblSede.Text = sedeNombre;
                            lblUsuarioRed.Text = Form3Login.UsuarioActual;

                        }
                    }

                
                }

            }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            if (txtNuevaPass.Text != txtConfirmarPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            if (txtNuevaPass.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres");
                return;
            }

            string hash = Seguridad.ObtenerSHA256(txtNuevaPass.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Usuarios
                             SET PasswordHash = @PasswordHash,
                                 PrimerIngreso = 0
                             WHERE Usuario = @Usuario";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PasswordHash", hash);
                    cmd.Parameters.AddWithValue("@Usuario", Form3Login.UsuarioActual); // variable que ya tienes

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contraseña actualizada correctamente");
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
