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
    public partial class FormEnvio : Form
    {
        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormEnvio instancia = null;
        public static FormEnvio ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormEnvio();
                return instancia;
            }
            return instancia;
        }

        public FormEnvio()
        {
            InitializeComponent();
        }

        private void lblNumeroMtto_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaMtto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaMtto_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipooperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipooperacion = cmbTipooperacion.SelectedItem.ToString();
            if (tipooperacion == "Envío")
            {
                btnEnvio.Visible = true;
                btnConfirmarrecepcion.Visible = false;
            }
            else
            if (tipooperacion == "Recepción")
            {
                btnEnvio.Visible = false;
                btnConfirmarrecepcion.Visible = true;
            }
        }

        private void FormEnvio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sedesDS.Sedes' Puede moverla o quitarla según sea necesario.
            this.sedesTableAdapter.Fill(this.sedesDS.Sedes);
            cmbTipooperacion.SelectedItem = "Recepción"; // Establecer el valor predeterminado del ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            //String idActivo = txtCodEnvio;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string queryId = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                    using (SqlCommand cmdd = new SqlCommand(queryId, conn))
                    {
                        cmdd.Parameters.AddWithValue("@Numero", txtCodEnvio.Text);
                        object result = cmdd.ExecuteScalar();

                         //conn.Close();
                        //conn.Open();
                        if (result == null)
                        {
                            MessageBox.Show("El activo no se encuentra registrado.");
                            return;
                        }
                        //else
                        //{//ABRE ABC

                        int idActivo = Convert.ToInt32(result);






                        string query = @"INSERT INTO Envio (IdActivo, SedeDestinoId, FechaEnvio)
                             VALUES (@IdActivo, @SedeDestinoId, @FechaEnvio)";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@IdActivo", idActivo); // este ya lo debes tener
                        cmd.Parameters.AddWithValue("@SedeDestinoId", cmbSedeEnvio.SelectedValue);
                        cmd.Parameters.AddWithValue("@FechaEnvio", dtpFechaEnvio.Value);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Envío registrado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
