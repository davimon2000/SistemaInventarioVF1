using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace GestionInventario
{
    public partial class FormMDI : MaterialForm
    {
        public const int WM_NCLBUTTONDOWN = 0xA1; //Mensaje que se envía cuando se hace clic en una parte no cliente de la ventana
        public const int HTCAPTION = 0x2;         //El área que se está clicando es la barra de título

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();//Libera el "capturado" actual del mouse

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);  //Se envía un mensaje para que actúe como si el usuario hubiera hecho clic en la barra de título de la ventana.

        public FormMDI()
        {
            InitializeComponent();


            //Configuración de material Skin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            FormEstado frm = FormEstado.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            FormRegistro frm = FormRegistro.ventana_unica();
            frm.MdiParent = this;
            frm.BringToFront();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        { 
            this.WindowState = FormWindowState.Minimized;
        
    }

        private void FormMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

    }

        private bool UsuarioTienePermisoMtto(string usuario)
        {
           // string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
           String connectionString = Conexion.cadena;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT PermisosMtto
                FROM Usuarios
                WHERE Usuario = @Usuario";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);

                        object result = cmd.ExecuteScalar();

                        if (result == null)
                            return false;

                        return Convert.ToBoolean(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al validar permisos de mantenimiento:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        private void btnIngresomtto_Click_1(object sender, EventArgs e)
        {
            if (!UsuarioTienePermisoMtto(Form3Login.UsuarioActual) )
            {
                MessageBox.Show("No tienes permiso para acceder a Mantenimiento.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                FormIngresomtto frm = FormIngresomtto.ventana_unica();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
    }

        private void btnSalida_Click_1(object sender, EventArgs e)
        {
            FormSalida frm = FormSalida.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
    
    }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            FormConsulta frm = FormConsulta.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
    }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            FormAnalisis frm = FormAnalisis.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            FormEnvio frm = FormEnvio.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMiusuario frm = FormMiusuario.ventana_unica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void pnlMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreacionUsuarios_Click(object sender, EventArgs e)
        {
            if (Form3Login.UsuarioActual == "Administrador")
            {
                FormCreacionUsuario frm = FormCreacionUsuario.ventana_unica();
                frm.MdiParent = this;
                frm.Show();
                frm.BringToFront();
            }
            else
            {
                MessageBox.Show("No tienes permiso para acceder a Creacion Usuarios.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CerrarImg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
