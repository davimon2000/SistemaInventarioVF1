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
using MaterialSkin;
using MaterialSkin.Controls;


namespace GestionInventario
{
    public partial class FormIngresomtto : Form

    {
        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormIngresomtto instancia = null;
        public static FormIngresomtto ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormIngresomtto();
                return instancia;
            }
            return instancia;
        }
        public FormIngresomtto()
        {
            InitializeComponent();
        }

        private void lblFechaRegistro_Click(object sender, EventArgs e)
        {

        }

        private void FormIngresomtto_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbConcepto.SelectedItem?.ToString();

            if (seleccion == "INGRESO")
            {
                cmbTipoFalla.Visible = true;
                cmbTipoFalla.Enabled = true;
                lblTipoFallaMtto.Visible = true;
                btnIngresoMtto.Enabled = true;
                btnIngresoMtto.Visible = true;
                txtObservacion.Visible = true;
                txtObservacion.Enabled = true;

                cmbEstadoMtto.Visible = false;
                cmbEstadoMtto.Enabled = false;
                lblEstadoMtto.Visible = false;
               // lblTecnico.Visible = false;
                //cmbTecnico.Visible = false;
                //cmbTecnico.Enabled = false;
                btnSalidaMtto.Enabled = false;
                btnSalidaMtto.Visible = false;
                txtObservacionSalida.Visible = false;
                txtObservacionSalida.Enabled = false;
                lblSedemtto.Visible = false;
                cmbSedemtto .Visible = false;
                //btnTecnicos.Visible = false;

            }
            else if (seleccion == "SALIDA")
            {
                cmbTipoFalla.Visible = false;
                cmbTipoFalla.Enabled = false;
                lblTipoFallaMtto.Visible= false;
                btnIngresoMtto.Enabled = false;
                btnIngresoMtto.Visible = false;
                txtObservacion.Visible = false;
                txtObservacion.Enabled = false;

                cmbEstadoMtto.Visible = true;
                cmbEstadoMtto.Enabled = true;
                lblEstadoMtto.Visible = true;
                //lblTecnico.Visible = false;
                //cmbTecnico.Enabled = true;
                //cmbTecnico.Visible = false;
                lblSedemtto.Visible = true;
                cmbSedemtto.Visible = true;

                btnSalidaMtto.Enabled = true;
                btnSalidaMtto.Visible = true;
                txtObservacionSalida.Visible = true;
                txtObservacionSalida.Enabled = true;
                //btnTecnicos.Visible = false;
            }
            
        }

        private void FormIngresomtto_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sedesDS.Sedes' Puede moverla o quitarla según sea necesario.
            this.sedesTableAdapter.Fill(this.sedesDS.Sedes);
            // TODO: esta línea de código carga datos en la tabla 'tecnicosDS.Tecnicos' Puede moverla o quitarla según sea necesario.
            //this.tecnicosTableAdapter.Fill(this.tecnicosDS.Tecnicos);

            cmbTipoFalla.Visible = true;
            cmbTipoFalla.Enabled = true;
            lblTipoFallaMtto.Visible = true;
            btnIngresoMtto.Enabled = true;
            btnIngresoMtto.Visible = true;

            cmbEstadoMtto.Visible = false;
            cmbEstadoMtto.Enabled = false;
            lblEstadoMtto.Visible = false;
            //lblTecnico.Visible = false;
            //cmbTecnico.Enabled = false;
            //cmbTecnico.Visible = false;
            btnSalidaMtto.Enabled = false;
            btnSalidaMtto.Visible = false;
            //btnTecnicos.Visible = false;

            lblSedemtto.Visible = false;
            cmbSedemtto.Visible = false;

            cmbConcepto.SelectedIndex = 0;
            
        }

        private void lblTipoFallaMtto_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresoMtto_Click(object sender, EventArgs e)
        {
            try
            {
                // Valores del formulario
                string numeroActivo = txtNumMtto.Text;
                String concepto = cmbConcepto.SelectedItem.ToString();
                DateTime fechaIngresoMtto = dtpFechaMtto.Value;
                String TipoFalla = cmbTipoFalla.SelectedItem.ToString();
                String ObsIngreso = txtObservacion.Text;
                int InventarioId = 0;
                int numeroIngreso = 1;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();

                    string queryId = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                    using (SqlCommand cmd = new SqlCommand(queryId, conn))
                    {
                        cmd.Parameters.AddWithValue("@Numero", numeroActivo);
                        object result = cmd.ExecuteScalar();
                        
                        conn.Close();

                        if (result != null)
                        {
                            InventarioId = Convert.ToInt32(result);

                            string queryCheckAsign = @"SELECT TOP 1 EstadoDevolucion
                            FROM Asignacion
                            WHERE IdActivo = @IdActivo
                            ORDER BY Id DESC";

                            using (SqlCommand cmdCheckAsign = new SqlCommand(queryCheckAsign, conn))
                            {
                                conn.Open();
                                cmdCheckAsign.Parameters.AddWithValue("@IdActivo", InventarioId);
                                object checkResultAsign = cmdCheckAsign.ExecuteScalar();

                                //conn.Close();


                                //if (checkResultAsign != null && checkResultAsign != DBNull.Value )
                                if(checkResultAsign == null)
                                {

                                    //VALIDAR QUE NO ESTÉ EN TRANSITO


                                    string queryValidarEnvio = @"
                                            SELECT 1
                                            FROM Envio
                                            WHERE IdActivo = @IdActivo
                                            AND FechaRecepcion IS NULL";

                                    using (SqlCommand cmdValidarEnvio = new SqlCommand(queryValidarEnvio, conn))
                                    {
                                        cmdValidarEnvio.Parameters.AddWithValue("@IdActivo", InventarioId);

                                        object enTransito = cmdValidarEnvio.ExecuteScalar();

                                        if (enTransito != null)
                                        {
                                            MessageBox.Show("El activo está en tránsito y no puede ingresar a mantenimiento",
                                                            "Validación",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Warning);
                                            return; // 🚨 SE DETIENE TODO AQUÍ
                                        }
                                    }


                                    conn.Close();



                                    string queryCheck = @"
                        SELECT TOP 1 checkMtto
                        FROM Mantenimiento
                        WHERE InventarioId = @InventarioId
                        ORDER BY Id DESC";  // O por Id DESC si Id es autoincremental

                                using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                                {
                                    conn.Open();
                                    cmdCheck.Parameters.AddWithValue("@InventarioId", InventarioId);
                                    object checkResult = cmdCheck.ExecuteScalar();

                                    string queryExistencia = "SELECT COUNT(*) FROM Mantenimiento WHERE InventarioId = @InventarioId";

                                    using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                                    {
                                        cmdExist.Parameters.AddWithValue("@InventarioId", InventarioId);
                                        int count = (int)cmdExist.ExecuteScalar();
                                        numeroIngreso = (int)cmdExist.ExecuteScalar() + 1;

                                        conn.Close();
                                        if (count > 0)   //Si ya hay registros anteriores en mtto con este activo
                                        {



                                            if (checkResult == null || checkResult == DBNull.Value || Convert.ToInt32(checkResult) != 1)
                                            {
                                                // Ya hay un mantenimiento en curso (checkMtto NULL o 0)
                                                MessageBox.Show("Ya hay un activo ingresado a mantenimiento con ese número.");
                                                return;
                                            }
                                            else
                                            {


                                                using (SqlConnection conexion = new SqlConnection(connectionString))
                                                {
                                                    string query = @"INSERT INTO Mantenimiento (InventarioId, FechaIngresoMtto, TipoFalla, ObsIngreso, NumIngreso, UsuarioIngreso, EstadoSalida)
                             VALUES (@InventarioId, @FechaIngresoMtto, @TipoFalla, @ObsIngreso, @NumIngreso, @UsuarioIngreso, @EstadoSalida)";

                                                    using (SqlCommand cmdIngreso = new SqlCommand(query, conexion))
                                                    {
                                                        cmdIngreso.Parameters.AddWithValue("@InventarioId", InventarioId);
                                                        cmdIngreso.Parameters.AddWithValue("@FechaIngresoMtto", fechaIngresoMtto);
                                                        cmdIngreso.Parameters.AddWithValue("@TipoFalla", TipoFalla);
                                                        cmdIngreso.Parameters.AddWithValue("@ObsIngreso", ObsIngreso);
                                                        cmdIngreso.Parameters.AddWithValue("@NumIngreso", numeroIngreso);
                                                        cmdIngreso.Parameters.AddWithValue("@UsuarioIngreso", Form3Login.UsuarioActual);
                                                        cmdIngreso.Parameters.AddWithValue("@EstadoSalida", "EnMtto");

                                                        try
                                                        {
                                                            conexion.Open();
                                                            cmdIngreso.ExecuteNonQuery();
                                                            MessageBox.Show($"Activo ingresado correctamente.\nNúmero de ingreso a mantenimiento: {numeroIngreso}");
                                                            txtNumMtto.Text = "";
                                                            txtObservacion.Text = "";

                                                            conexion.Close();


                                                            //using(SqlConnection connnnn = new SqlConnection(connectionString))
                                                            // {
                                                            ////&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                                                            //string query_Sede = "UPDATE Asignacion SET Sede = NULL WHERE IdActivo = @IdActivo";

                                                            //using (SqlCommand cmd_Sede = new SqlCommand(query_Sede, conn))
                                                            //{
                                                            //    cmd_Sede.Parameters.AddWithValue("@IdActivo", InventarioId);

                                                            //    conn.Open();
                                                            //    cmd_Sede.ExecuteNonQuery();
                                                            //    conn.Close();
                                                            //}
                                                            ////&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
                                                            //}

                                                        }
                                                        catch (Exception ex)
                                                        {
                                                            MessageBox.Show("Error al registrar: " + ex.Message);
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                        else
                                        {
                                            // No existen mttos anteriores

                                            using (SqlConnection conexion = new SqlConnection(connectionString))
                                            {
                                                string query = @"INSERT INTO Mantenimiento (InventarioId, FechaIngresoMtto, TipoFalla, ObsIngreso, NumIngreso, UsuarioIngreso, EstadoSalida)
                             VALUES (@InventarioId, @FechaIngresoMtto, @TipoFalla, @ObsIngreso, @NumIngreso, @UsuarioIngres, @EstadoSalida)";

                                                using (SqlCommand cmdIngreso = new SqlCommand(query, conexion))
                                                {
                                                    cmdIngreso.Parameters.AddWithValue("@InventarioId", InventarioId);
                                                    cmdIngreso.Parameters.AddWithValue("@FechaIngresoMtto", fechaIngresoMtto);
                                                    cmdIngreso.Parameters.AddWithValue("@TipoFalla", TipoFalla);
                                                    cmdIngreso.Parameters.AddWithValue("@ObsIngreso", ObsIngreso);
                                                    cmdIngreso.Parameters.AddWithValue("@NumIngreso", numeroIngreso);
                                                    cmdIngreso.Parameters.AddWithValue("@UsuarioIngres", Form3Login.UsuarioActual);
                                                    cmdIngreso.Parameters.AddWithValue("@EstadoSalida", "EnMtto");
                                                    try
                                                    {
                                                        conexion.Open();
                                                        cmdIngreso.ExecuteNonQuery();
                                                        MessageBox.Show($"Activo ingresado correctamente.\nNúmero de ingreso a mantenimiento: {numeroIngreso}");
                                                        txtNumMtto.Text = "";
                                                        txtObservacion.Text = "";
                                                        conexion.Close();
                                                        //using (SqlConnection connnn = new SqlConnection(connectionString))
                                                        //{
                                                        //string query_Sede = "UPDATE Asignacion SET Sede = NULL WHERE IdActivo = @IdActivo";

                                                        //using (SqlCommand cmd_Sede = new SqlCommand(query_Sede, conn))
                                                        //{
                                                        //    cmd_Sede.Parameters.AddWithValue("@IdActivo", InventarioId);

                                                        //    conn.Open();
                                                        //    cmd_Sede.ExecuteNonQuery();
                                                        //    conn.Close();
                                                        //}
                                                        //}


                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show("Error al registrar: " + ex.Message);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            } //Cierre if de si esta asignado el activo
                                else
                                {
                                    MessageBox.Show("El activo está asignado a un usuario y no ha sido devuelto. No puede ingresar a mantenimiento.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El activo no se encuentra registrado");

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: Verificar los campos");
                MessageBox.Show("Error: " + ex.Message);    
            }
                }


        private void lblMantenimiento_Click(object sender, EventArgs e)
        {

        }


        bool PuedeIngresarMtto(int idActivo, SqlConnection cn)
        {
            string query = @"
    SELECT TOP 1 UsuarioId, FechaDevolucion
    FROM Asignacion
    WHERE IdActivo = @IdActivo
    ORDER BY Id DESC";

            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@IdActivo", idActivo);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read())
                    {
                        // Nunca ha sido asignado
                        return true;
                    }

                    // Si tiene fecha de devolución, está libre
                    if (dr["FechaDevolucion"] != DBNull.Value)
                        return true;

                    // Tiene usuario y no ha sido devuelto
                    return false;
                }
            }
        }
        private void cmbEstadoMtto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalidaMtto_Click(object sender, EventArgs e)
        {
            try
            {
            // Valores del formulario
            string numeroActivo = txtNumMtto.Text;
            DateTime fechaSalidaMtto = dtpFechaMtto.Value;
            String Estado = cmbEstadoMtto.SelectedItem.ToString();
            String ObsSalida = txtObservacionSalida.Text;
            //string tecnicoid = cmbTecnico.SelectedIndex.ToString();
            //string tecnicoSelected = cmbTecnico.ValueMember.ToString();
            //int tecnicoid = Convert.ToInt32(cmbTecnico.SelectedValue);

            //int tecnicoid = 1;
            int InventarioId = 0;
            int checkTrue = 1;
                //int count = 0;
                int SedeIdmtto = Convert.ToInt32(cmbSedemtto.SelectedValue);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string queryid = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                using (SqlCommand cmd = new SqlCommand(queryid, conn))
                {
                    cmd.Parameters.AddWithValue("@Numero", numeroActivo);
                    object result = cmd.ExecuteScalar();
                    conn.Close();
                        if (result != null)
                        {
                            InventarioId = Convert.ToInt32(result);


                            string queryexistencia = "SELECT COUNT(*) FROM Mantenimiento WHERE InventarioId = @InventarioId";
                            using (SqlCommand cmdexist = new SqlCommand(queryexistencia, conn))
                            {
                                conn.Open();
                                cmdexist.Parameters.AddWithValue("@InventarioId", InventarioId);

                                //int count = (int)cmdexist.ExecuteScalar();
                                int count = Convert.ToInt32(cmdexist.ExecuteScalar());
                                conn.Close();
                            //}

                            //    if (count > 0)
                            //    {

                            string queryExistencia = @"
                    SELECT TOP 1 checkMtto
                    FROM Mantenimiento
                    WHERE InventarioId = @InventarioId
                    ORDER BY Id DESC"; // o por FechaIngresoMtto DESC


                                

                            using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                            {
                                conn.Open();
                                cmdExist.Parameters.AddWithValue("@InventarioId", InventarioId);
                                object resultCheck = cmdExist.ExecuteScalar();
                                conn.Close();
                                    
                                    if (resultCheck == null || resultCheck == DBNull.Value )
                                { //ABRE ABC

                                        //    string updatequery = @"
                                        //UPDATE Mantenimiento
                                        //SET fechasalidamtto = @fechasalidamtto,
                                        //    estadosalida = @estadosalida,
                                        //    ObsSalida = @ObsSalida,
                                        //    tecnicoid = @tecnicoid,
                                        //    UsuarioSalida = @UsuarioSalida,
                                        //    checkMtto = @checkMtto

                                        //WHERE Id = (
                                        //        SELECT TOP 1 Id
                                        //        FROM Mantenimiento
                                        //        WHERE InventarioId = @InventarioId
                                        //        ORDER BY Id DESC
                                        //    )";
                                        
                                        if (count > 0)
                                        {
                                            
                                            string updatequery = @"
                            UPDATE Mantenimiento
                            SET fechasalidamtto = @fechasalidamtto,
                                estadosalida = @estadosalida,
                                ObsSalida = @ObsSalida,
                                UsuarioSalida = @UsuarioSalida,
                                checkMtto = @checkMtto,
                                SedeSalidaID = @sedesalidamtto

                            WHERE Id = (
                                    SELECT TOP 1 Id
                                    FROM Mantenimiento
                                    WHERE InventarioId = @InventarioId
                                    ORDER BY Id DESC
                                )";


                                            using (SqlCommand cmdupdate = new SqlCommand(updatequery, conn))
                                            {
                                                cmdupdate.Parameters.AddWithValue("@inventarioid", InventarioId);
                                                cmdupdate.Parameters.AddWithValue("@fechasalidamtto", fechaSalidaMtto);
                                                cmdupdate.Parameters.AddWithValue("@estadosalida", Estado);
                                                cmdupdate.Parameters.AddWithValue("@ObsSalida", ObsSalida);
                                                //cmdupdate.Parameters.AddWithValue("@tecnicoid", tecnicoid);
                                                cmdupdate.Parameters.AddWithValue("@checkMtto", checkTrue);
                                                cmdupdate.Parameters.AddWithValue("@UsuarioSalida", Form3Login.UsuarioActual);
                                                cmdupdate.Parameters.AddWithValue("@sedesalidamtto", SedeIdmtto);
                                                
                                                // manejo de parámetro nulo
                                                try
                                                {
                                                    conn.Open();
                                                    
                                                    cmdupdate.ExecuteNonQuery();
                                                    
                                                    MessageBox.Show("Registro actualizado correctamente.");
                                                    txtNumMtto.Text = "";
                                                    txtObservacionSalida.Text = "";
                                                    conn.Close();



                                                    //using (SqlConnection connn = new SqlConnection(connectionString))
                                                    //{
                                                    //    string query_Sede = "UPDATE Asignacion SET Sede = NULL WHERE IdActivo = @IdActivo";

                                                    //    using (SqlCommand cmd_Sede = new SqlCommand(query_Sede, connn))
                                                    //    {
                                                    //        cmd_Sede.Parameters.AddWithValue("@IdActivo", InventarioId);

                                                    //        connn.Open();
                                                    //        cmd_Sede.ExecuteNonQuery();
                                                    //        connn.Close();
                                                    //    }
                                                    //}

                                                }
                                                catch (Exception ex)
                                                {

                                                    MessageBox.Show("Error al registrar: " + ex.Message);

                                                }



                                            }


                                        }
                                        else
                                        {
                                            MessageBox.Show("El activo no ha ingresado a mantenimiento");
                                        }
                                }//CIERRA ABC

                                else
                                {
                                    MessageBox.Show("El activo no ha ingresado a mantenimiento");

                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El activo no se encuentra registrado");
                    }
                }
            }
            }
            catch
            {
                MessageBox.Show("Verificar los campos");
            }
        }

        private void txtObservacionSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            FormTecnicos frm = FormTecnicos.ventana_unica(this);

            // Usamos el mismo MDI parent del formulario actual
            frm.MdiParent = this.MdiParent;

            frm.BringToFront();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void cmbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void RecargarDatos()
        {
           // this.tecnicosTableAdapter.Fill(this.tecnicosDS.Tecnicos);
        }

        private void cmbTipoFalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
