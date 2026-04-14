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
    public partial class FormCreacionUsuario : Form
    {
        //string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        //String conexion = Form3Login.ObtenerConexion();
        String conexion = Conexion.cadena;

        private static FormCreacionUsuario instancia = null;
        public static FormCreacionUsuario ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormCreacionUsuario();
                return instancia;
            }
            return instancia;
        }

        public FormCreacionUsuario()
        {
            InitializeComponent();
        }

        private void FormCreacionUsuario_Load(object sender, EventArgs e)
        {
            CargarSedes();
        }
        private void CargarSedes()
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = "SELECT Id, NombreSede FROM Sedes";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSede.DataSource = dt;
                cmbSede.DisplayMember = "NombreSede";
                cmbSede.ValueMember = "Id";
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) ||
        string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Complete los campos obligatorios");
                return;
            }

            string hash = Seguridad.ObtenerSHA256(txtContraseña.Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.cadena))
                {
                    conn.Open();

                    string query = @"INSERT INTO Usuarios 
                            (Usuario, NombreCompleto, Rol, SedeId, PasswordHash, PermisosMtto, PrimerIngreso)
                            VALUES
                            (@Usuario, @Nombre, @Rol, @SedeId, @PasswordHash, @EsAdmin, 1)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Rol", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@SedeId", cmbSede.SelectedValue);
                    cmd.Parameters.AddWithValue("@PasswordHash", hash);
                    cmd.Parameters.AddWithValue("@EsAdmin", checkMtto.Checked);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario creado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
