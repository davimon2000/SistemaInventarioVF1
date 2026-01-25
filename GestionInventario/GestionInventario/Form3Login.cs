using DocumentFormat.OpenXml.Spreadsheet;
using GestionInventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GestionInventario
{
    public partial class Form3Login : Form
    {
        public static string UsuarioActual = "";
        public static int SedeIdUsuarioSistema = 0;
        public static string RolUsuarioSistema = "";
        public Form3Login()
        {
            InitializeComponent();
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            int sedeId = 0;
            String rolUsuario ="";

            //SqlDataReader dr;
            //rolUsuario = dr["NombreRol"].ToString();
            



            if (usuario == "" || contrasena == "")
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña");
                return;
            }
            string conexion = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@usuario AND Contrasena=@contrasena";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                int existe = (int)cmd.ExecuteScalar();
                if (existe > 0)
                {
                    UsuarioActual = usuario; 
                    this.Hide(); // Cierra el login
                    FormMDI frm = new FormMDI();


                    //int sedeId;

                    //using (SqlConnection conn = new SqlConnection(connectionString))
                    //{
                    //conn.Open();


                    if (usuario != "Administrador")
                    {
                        try
                        {
                            string querySede = @"
        SELECT SedeId, Rol
        FROM Usuarios
        WHERE Usuario = @Usuario";

                            using (SqlCommand cmdSede = new SqlCommand(querySede, cn))
                            {
                                cmdSede.Parameters.AddWithValue("@Usuario", usuario);

                                object result = cmdSede.ExecuteScalar();

                                if (result == null)
                                {
                                    MessageBox.Show("No se encontró la sede del usuario.");
                                    return;
                                }

                                sedeId = Convert.ToInt32(result);
                                SedeIdUsuarioSistema = sedeId;
                                RolUsuarioSistema = "";
                                //rolUsuario = "Usuario Sede";
                            }

                            //MessageBox.Show("El Id de sede es: " + sedeId);
                        }
                        catch(Exception ex)
                         {
                            MessageBox.Show("No fue posible validar sede de usuario");
                        }

                    }

                    //Sesion.Usuario = usuario;
                    //Sesion.SedeId = sedeId;
                    //Sesion.Rol = rol;
                    else
                    {
                        rolUsuario= "Administrador";
                        RolUsuarioSistema = rolUsuario;
                    }



                        frm.Show();


                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            
            //using (SqlConnection cn = new SqlConnection(conexion))
            ////using (SqlCommand cmd = new SqlCommand(sql, cn))
            //{
            //    cn.Open();
            //    string sql = @"
            //    SELECT Rol
            //    FROM Usuarios
            //    WHERE Usuario = @Usuario";

            //    using (SqlCommand cmd = new SqlCommand(sql, cn))
            //    using (SqlDataReader dr = cmd.ExecuteReader())
            //    {
            //        if (dr.Read())
            //        {
            //            string rol = dr["Rol"].ToString();
            //        }
            //    }
            //    cn.Close();
            //}

        }


        



        private void Form3Login_Load(object sender, EventArgs e)
        {

        }
    }
    //public static class Sesion
    //{
    //    public static string Usuario { get; set; }
    //    public static int SedeId { get; set; }
    //    public static string Rol { get; set; }

    //    public static bool EsAdministrador
    //    {
    //        get { return Rol == "Administrador"; }
    //    }
    //}
}
