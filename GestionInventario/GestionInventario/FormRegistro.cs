using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GestionInventario;


namespace GestionInventario
{
    public partial class FormRegistro : Form
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["GestionInventario.Properties.Settings.InventarioActivosConnectionString"].ConnectionString;
        //string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        string connectionString = Conexion.cadena;
        private static FormRegistro instancia = null;

        public static FormRegistro ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormRegistro();
                return instancia;
            }
            return instancia;
        }
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumeroRegistro_Click(object sender, EventArgs e)
        {

        }

        Point posicionNormalBtn;
        Point posicionConFallaBtn;

        //private void picEliminarMarca_Click(object sender, EventArgs e)
        //{
        //    string marcaAEliminar = cmbMarcaRegistro.Text.Trim();

        //    if (cmbMarcaRegistro.Items.Contains(marcaAEliminar))
        //    {
        //        DialogResult result = MessageBox.Show(
        //            $"¿Seguro que deseas eliminar la marca '{marcaAEliminar}'?",
        //            "Confirmar eliminación",
        //            MessageBoxButtons.YesNo,
        //            MessageBoxIcon.Question
        //            );

        //        if (result == DialogResult.Yes)
        //        {
        //            using (SqlConnection conn = new SqlConnection(connectionString))
        //            {
        //                conn.Open();

        //                // Primero eliminamos de RegistroActivos (dependiente)
        //                string deleteActivos = @"
        //    DELETE FROM RegistroActivos
        //    WHERE IdMarca IN (
        //        SELECT IdMarca FROM Marcas WHERE Nombre = @NombreMarca
        //    );";

        //                using (SqlCommand cmdActivos = new SqlCommand(deleteActivos, conn))
        //                {
        //                    cmdActivos.Parameters.AddWithValue("@NombreMarca", marcaAEliminar);
        //                    cmdActivos.ExecuteNonQuery();
        //                }

        //                // Luego eliminamos de Marcas (maestra)
        //                string deleteMarca = "DELETE FROM Marcas WHERE Nombre = @NombreMarca";

        //                using (SqlCommand cmdMarca = new SqlCommand(deleteMarca, conn))
        //                {
        //                    cmdMarca.Parameters.AddWithValue("@NombreMarca", marcaAEliminar);
        //                    cmdMarca.ExecuteNonQuery();
        //                }
        //            }


        //            //cmbMarcaRegistro.Items.Remove(marcaAEliminar);
        //            cmbMarcaRegistro.Text = "";
        //            MessageBox.Show("Marca eliminada correctamente.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show($"La marca '{marcaAEliminar}' no existe en la lista. ");
        //    }
        //}


        //private void FormRegistro_Load(object sender, EventArgs e)
        //{

        //}

        private void FormRegistro_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sedesDS.Sedes' Puede moverla o quitarla según sea necesario.
            this.sedesTableAdapter.Fill(this.sedesDS.Sedes);
            // TODO: esta línea de código carga datos en la tabla 'marcasDS.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter2.Fill(this.marcasDS.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'activosDS.Activos' Puede moverla o quitarla según sea necesario.
            this.activosTableAdapter.Fill(this.activosDS.Activos);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet1.Marcas' Puede moverla o quitarla según sea necesario.
            //this.marcasTableAdapter1.Fill(this.inventarioActivosDataSet1.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet.Marcas' Puede moverla o quitarla según sea necesario.
            //this.marcasTableAdapter.Fill(this.inventarioActivosDataSet.Marcas);

            posicionNormalBtn = btnRegistrar.Location;

    //        posicionConFallaBtn = new Point(
    //        btnRegistrar.Location.X,
    //        btnRegistrar.Location.Y + 80

    //);


        }

        private void picAgregar_Click_1(object sender, EventArgs e)
        {
            FormMarcas frm = FormMarcas.ventana_unica(this);

            // Usamos el mismo MDI parent del formulario actual
            frm.MdiParent = this.MdiParent;

            frm.BringToFront();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }


        public void RecargarDatos()
        {
            this.marcasTableAdapter2.Fill(this.marcasDS.Marcas);
            this.activosTableAdapter.Fill(this.activosDS.Activos);
        }




        //private void picAgregar_Click_1(object sender, EventArgs e)
        //{
        //    String Nuevamarca = cmbMarcaRegistro.Text;

        //    if (MarcaExiste(Nuevamarca))
        //    {
        //        MessageBox.Show("La marca ya existe.");
        //    }
        //    else
        //    {

        //        string query = "INSERT INTO Marcas (Marca) VALUES (@Marca)";

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {


        //                //Añadir los parámetros a la consulta
        //                command.Parameters.AddWithValue("@Marca", Nuevamarca);

        //                try
        //                {
        //                    connection.Open(); // Abrir la conexión
        //                    int rowsAffected = command.ExecuteNonQuery(); // Ejecutar la consulta

        //                    if (rowsAffected > 0)
        //                    {
        //                        MessageBox.Show("Marca añadida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        // Opcional: Limpiar los campos después de insertar
        //                        cmbMarcaRegistro.SelectedItem = -1;

        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No se pudo añadir el dato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //            }

        //        }
        //    }
        //}
        //private bool MarcaExiste(string nombreMarca)
        //{
        //    String Nuevamarca = cmbMarcaRegistro.Text.Trim();
        //    string query = "SELECT COUNT(*) FROM Marcas WHERE Marca = @Marca";

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    using (SqlCommand command = new SqlCommand(query, connection))
        //    {
        //        command.Parameters.AddWithValue("@Marca", Nuevamarca);
        //        connection.Open();

        //        int count = (int)command.ExecuteScalar();
        //        return count > 0;
        //    }
        //}

        //private void EliminarDeBaseDeDatos(string EliminarMarca)
        //{
        //    using (SqlConnection conexion = new SqlConnection(connectionString))
        //    {
        //        string consulta = "DELETE FROM Marcas WHERE Marca = @Marca";

        //        using (SqlCommand comando = new SqlCommand(consulta, conexion))
        //        {
        //            comando.Parameters.AddWithValue("@Marca", EliminarMarca);

        //            try
        //            {
        //                conexion.Open();
        //                int filasAfectadas = comando.ExecuteNonQuery();

        //                if (filasAfectadas == 0)
        //                {
        //                    MessageBox.Show("No se encontró el elemento en la base de datos.");
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error al eliminar de la base de datos: " + ex.Message);
        //            }
        //        }
        //    }
        //}

        private void picEliminarMarca_Click_1(object sender, EventArgs e)
        {

        }
        //string marcaAEliminar = cmbMarcaRegistro.Text.Trim();

        //    DialogResult result = MessageBox.Show(
        //        $"¿Seguro que deseas eliminar la marca '{marcaAEliminar}'?",
        //        "Confirmar eliminación",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //        );

        //    if (result == DialogResult.Yes)
        //    {

        //        EliminarDeBaseDeDatos(marcaAEliminar);

        //        // Eliminar del ComboBox
        //        cmbMarcaRegistro.Items.Remove(marcaAEliminar);
        //        cmbMarcaRegistro.Items.Remove(marcaAEliminar);
        //        cmbMarcaRegistro.Text = "";
        //        MessageBox.Show("Marca eliminada correctamente.");
        //    }

        //}

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //-------------SI EL ESTADO ES DIFERENTE A CON FALLA-----------------------------------------
            string seleccionEstado = cmbEstadoRegistro.SelectedItem?.ToString();


            // Valores del formulario
            string codInterno = txtNumReg.Text;
            string serial = txtSerialRegistro.Text;
            string marca1 = cmbMarcaRegistro.SelectedItem?.ToString();
            string marca = cmbMarcaRegistro.ValueMember;
            //string sederegistro = cmbSedeReg.SelectedItem?.ToString();
            int sedeId = Convert.ToInt32(cmbSedeReg.SelectedValue);

            string EstadoActual = cmbEstadoRegistro.SelectedItem?.ToString();
            int idMarca = Convert.ToInt32(cmbMarcaRegistro.SelectedValue);
            int idActivo = Convert.ToInt32(cmbActivo.SelectedValue);
            DateTime fechaReg = dtpFechaReg.Value;
            DateTime? fechaCompra = checkBoxFechaCompra.Checked ? dtpFechaCompra.Value : (DateTime?)null;
            //String TipoFalla = cmbTipoFalla.SelectedItem?.ToString();
            //String obs = txtObservacion.Text;
            int InventarioId = 0;
            int NumeroIngreso = 1;

            //if (seleccionEstado != "Con Falla")
            //{

            if (sedeId == Form3Login.SedeIdUsuarioSistema || Form3Login.RolUsuarioSistema == "Administrador")
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //conn.Open();
                    string queryExistencia = "SELECT COUNT(*) FROM RegistroActivos WHERE codInterno = @codInterno";
                    using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                    {
                        cmdExist.Parameters.AddWithValue("@codInterno", codInterno);
                        conn.Open();
                        int count = (int)cmdExist.ExecuteScalar();
                        conn.Close();
                        if (count > 0)
                        {
                            MessageBox.Show("Ya existe un activo registrado con ese número");

                            //    // Paso 2: Preguntar si desea actualizar
                            //    DialogResult resultado = MessageBox.Show(
                            //        "Ya existe un activo con ese número. ¿Desea actualizar los datos?",
                            //        "Confirmar actualización",
                            //        MessageBoxButtons.YesNo,
                            //        MessageBoxIcon.Question
                            //    );

                            //    if (resultado == DialogResult.Yes)
                            //    {
                            //        // Paso 3: Actualizar

                            //        string queryValidar = "SELECT COUNT(*) FROM RegistroActivos WHERE Serial = @Serial";

                            //        using (SqlCommand cmdValidar = new SqlCommand(queryValidar, conn))
                            //        {
                            //            cmdValidar.Parameters.AddWithValue("@Serial", serial);

                            //            conn.Open();
                            //            int existe = (int)cmdValidar.ExecuteScalar();
                            //            conn.Close();

                            //            if (existe > 0)
                            //            {

                            //                MessageBox.Show("Ya existe un activo registrado con ese serial.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //                return; //Detiene la ejecución para que no inserte el registro
                            //            }
                            //        }


                            //        string updateQuery = @"
                            //UPDATE RegistroActivos
                            //SET Serial = @serial,
                            //    Marca = @marca,
                            //    FechaCompra = @fechaCompra,
                            //    FechaRegistro = @fechaRegistro,
                            //    EstadoRegistro = @estadoActual,
                            //    Usuario = @usuario

                            //WHERE CodInterno = @codInterno";

                            //        using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            //        {
                            //            cmdUpdate.Parameters.AddWithValue("@codInterno", codInterno);
                            //            cmdUpdate.Parameters.AddWithValue("@serial", serial);
                            //            cmdUpdate.Parameters.AddWithValue("@marca", idMarca);
                            //            cmdUpdate.Parameters.AddWithValue("@fechaRegistro", fechaReg);
                            //            cmdUpdate.Parameters.AddWithValue("@estadoActual", EstadoActual);
                            //            cmdUpdate.Parameters.AddWithValue("@usuario", Form3Login.UsuarioActual);
                            //            // Manejo de parámetro nulo
                            //            if (fechaCompra.HasValue)
                            //                cmdUpdate.Parameters.AddWithValue("@fechaCompra", fechaCompra.Value);
                            //            else
                            //                cmdUpdate.Parameters.AddWithValue("@fechaCompra", DBNull.Value);
                            //            conn.Open();
                            //            cmdUpdate.ExecuteNonQuery();
                            //            conn.Close();
                            //            MessageBox.Show("Registro actualizado correctamente.");
                            //            txtNumReg.Text = "";
                            //            txtSerialRegistro.Text = "";
                            //            checkBoxFechaCompra.Checked = false;
                            //        }
                            //    }
                            //    else
                            //    {
                            //        MessageBox.Show("Operación cancelada.");
                            //    }
                        }
                        else
                        {

                            // 3. Insertar en la base de datos
                            using (SqlConnection conexion = new SqlConnection(connectionString))
                            {
                                if (txtSerialRegistro.Text != "")
                                {
                                    string queryValidar = "SELECT COUNT(*) FROM RegistroActivos WHERE Serial = @Serial";

                                    using (SqlCommand cmdValidar = new SqlCommand(queryValidar, conexion))
                                    {
                                        cmdValidar.Parameters.AddWithValue("@Serial", serial);

                                        conexion.Open();
                                        int existe = (int)cmdValidar.ExecuteScalar();
                                        conexion.Close();

                                        if (existe > 0)
                                        {
                                            MessageBox.Show("Ya existe un activo registrado con ese serial.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return; //Detiene la ejecución para que no inserte el registro
                                        }

                                        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                                        else
                                        {
                                            string query = @"INSERT INTO RegistroActivos (IdActivo, CodInterno, Serial, Marca, FechaCompra, FechaRegistro, SedeRegistroId, EstadoRegistro, UsuarioSistemaId)
                         VALUES (@IdActivo, @CodInterno, @Serial, @IdMarca, @FechaCompra, @FechaRegistro, @SedeRegistroId, @EstadoActual, @UsuarioSistemaId)";

                                            using (SqlCommand cmd = new SqlCommand(query, conexion))
                                            {
                                                cmd.Parameters.AddWithValue("@IdActivo", idActivo);
                                                cmd.Parameters.AddWithValue("@CodInterno", codInterno);
                                                cmd.Parameters.AddWithValue("@Serial", serial);
                                                cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                                                cmd.Parameters.AddWithValue("@FechaRegistro", fechaReg);
                                                cmd.Parameters.AddWithValue("@SedeRegistroId", sedeId);
                                                cmd.Parameters.AddWithValue("@EstadoActual", EstadoActual);
                                                cmd.Parameters.AddWithValue("@UsuarioSistemaId", Form3Login.IdUsuarioSistema);
                                                // Manejo de parámetro nulo
                                                if (fechaCompra.HasValue)
                                                    cmd.Parameters.AddWithValue("@FechaCompra", fechaCompra.Value);
                                                else
                                                    cmd.Parameters.AddWithValue("@FechaCompra", DBNull.Value);

                                                try
                                                {
                                                    conexion.Open();
                                                    cmd.ExecuteNonQuery();
                                                    conexion.Close();
                                                    MessageBox.Show("Registro guardado con éxito.");
                                                    txtNumReg.Text = "";
                                                    txtSerialRegistro.Text = "";
                                                    checkBoxFechaCompra.Checked = false;
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Error al registrar: " + ex.Message);
                                                }
                                            }
                                        }
                                        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%55555



                                    }
                                }// cierra serial null
                                else
                                {


                                    string query = @"INSERT INTO RegistroActivos (IdActivo, CodInterno, Serial, Marca, FechaCompra, FechaRegistro, SedeRegistroId, EstadoRegistro, UsuarioSistemaId)
                         VALUES (@IdActivo, @CodInterno, @Serial, @IdMarca, @FechaCompra, @FechaRegistro, @SedeRegistroId, @EstadoActual, @UsuarioSistemaId)";

                                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                                    {
                                        cmd.Parameters.AddWithValue("@IdActivo", idActivo);
                                        cmd.Parameters.AddWithValue("@CodInterno", codInterno);
                                        cmd.Parameters.AddWithValue("@Serial", serial);
                                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                                        cmd.Parameters.AddWithValue("@FechaRegistro", fechaReg);
                                        cmd.Parameters.AddWithValue("@SedeRegistroId", sedeId);
                                        cmd.Parameters.AddWithValue("@EstadoActual", EstadoActual);
                                        cmd.Parameters.AddWithValue("@UsuarioSistemaId", Form3Login.IdUsuarioSistema);
                                        // Manejo de parámetro nulo
                                        if (fechaCompra.HasValue)
                                            cmd.Parameters.AddWithValue("@FechaCompra", fechaCompra.Value);
                                        else
                                            cmd.Parameters.AddWithValue("@FechaCompra", DBNull.Value);

                                        try
                                        {
                                            conexion.Open();
                                            cmd.ExecuteNonQuery();
                                            conexion.Close();
                                            MessageBox.Show("Registro guardado con éxito.");
                                            txtNumReg.Text = "";
                                            txtSerialRegistro.Text = "";
                                            checkBoxFechaCompra.Checked = false;
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error al registrar: " + ex.Message);
                                        }
                                    }
                                } // else de serial null
                            }
                        }
                    }




                }




                //********/////////////////SI ES CON FALLA QUE INGRESE A MTTO////////////*****************
                //}else
                //if (seleccionEstado == "Con Falla")
                //{

                //    /////////////////////////------------SI EL ESTADO ES CON FALLA--------------------------------///////////////
                //    ///---------------------------------Significa que ingresa a mantenimiento


                //    using (SqlConnection conn = new SqlConnection(connectionString))
                //    {
                //        //conn.Open();
                //        string queryExistencia = "SELECT COUNT(*) FROM RegistroActivos WHERE codInterno = @codInterno";
                //        using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                //        {
                //            cmdExist.Parameters.AddWithValue("@codInterno", codInterno);
                //            conn.Open();
                //            int count = (int)cmdExist.ExecuteScalar();
                //            conn.Close();
                //            if (count > 0)
                //            {
                //                MessageBox.Show("Activo ya registrado. Para fallas use la ventana de Mantenimiento.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //                return; //Detiene la ejecución para que no inserte el registro
                //            }
                //            else
                //            {

                //                // 3. Insertar en la base de datos
                //                using (SqlConnection conexion = new SqlConnection(connectionString))
                //                {
                //                    if (txtSerialRegistro.Text != "")
                //                    {
                //                        string queryValidar = "SELECT COUNT(*) FROM RegistroActivos WHERE Serial = @Serial";

                //                        using (SqlCommand cmdValidar = new SqlCommand(queryValidar, conexion))
                //                        {
                //                            cmdValidar.Parameters.AddWithValue("@Serial", serial);

                //                            conexion.Open();
                //                            int existe = (int)cmdValidar.ExecuteScalar();
                //                            conexion.Close();

                //                            if (existe > 0)
                //                            {
                //                                MessageBox.Show("Ya existe un activo registrado con ese serial.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //                                return; //Detiene la ejecución para que no inserte el registro
                //                            }
                //                        }

                //                    }//cierre if serial null
                //                    else { 

                //                        string query = @"INSERT INTO RegistroActivos (IdActivo, CodInterno, Serial, Marca, FechaCompra, FechaRegistro, SedeRegistro, EstadoRegistro, Usuario)
                //             VALUES (@IdActivo, @CodInterno, @Serial, @IdMarca, @FechaCompra, @FechaRegistro,@SedeRegistro, @EstadoActual, @usuario)";

                //                    string querymtto = @"INSERT INTO Mantenimiento (InventarioId, FechaIngresoMtto, TipoFalla, ObsIngreso, NumIngreso, UsuarioIngreso, EstadoSalida)
                //                 VALUES (@InventarioId, @FechaIngresoMtto, @TipoFalla, @ObsIngreso, @NumIngreso, @UsuarioIngres, @EstadoSalida)";

                //                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                //                    {
                //                        cmd.Parameters.AddWithValue("@IdActivo", idActivo);
                //                        cmd.Parameters.AddWithValue("@CodInterno", codInterno);
                //                        cmd.Parameters.AddWithValue("@Serial", serial);
                //                        cmd.Parameters.AddWithValue("@IdMarca", idMarca);
                //                        cmd.Parameters.AddWithValue("@FechaRegistro", fechaReg);
                //                            cmd.Parameters.AddWithValue("@SedeRegistro", sederegistro);
                //                        cmd.Parameters.AddWithValue("@EstadoActual", EstadoActual);
                //                        cmd.Parameters.AddWithValue("@usuario", Form3Login.UsuarioActual);
                //                        // Manejo de parámetro nulo
                //                        if (fechaCompra.HasValue)
                //                            cmd.Parameters.AddWithValue("@FechaCompra", fechaCompra.Value);
                //                        else
                //                            cmd.Parameters.AddWithValue("@FechaCompra", DBNull.Value);


                //                        try
                //                        {
                //                            conexion.Open();
                //                            cmd.ExecuteNonQuery();
                //                            conexion.Close();
                //                            //MessageBox.Show("Registro guardado con éxito. Ingresado a mtto");
                //                            txtNumReg.Text = "";
                //                            txtSerialRegistro.Text = "";
                //                            checkBoxFechaCompra.Checked = false;
                //                        }
                //                        catch (Exception ex)
                //                        {
                //                            MessageBox.Show("Error al registrar: " + ex.Message);
                //                        }
                //                    }

                //                    //using (SqlConnection conexion = new SqlConnection(connectionString))
                //                    //{

                //                    //MessageBox.Show("Es" + InventarioId);
                //                    conn.Open();

                //                    string queryid = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                //                    using (SqlCommand cmd = new SqlCommand(queryid, conn))
                //                    {
                //                        cmd.Parameters.AddWithValue("@Numero", codInterno);
                //                        object result = cmd.ExecuteScalar();
                //                        conn.Close();


                //                        InventarioId = Convert.ToInt32(result);
                //                       // MessageBox.Show("Es" + InventarioId);
                //                        using (SqlCommand cmdIngreso = new SqlCommand(querymtto, conexion))
                //                        {
                //                            cmdIngreso.Parameters.AddWithValue("@InventarioId", InventarioId);
                //                            cmdIngreso.Parameters.AddWithValue("@FechaIngresoMtto", fechaReg);
                //                            cmdIngreso.Parameters.AddWithValue("@TipoFalla", TipoFalla);
                //                            cmdIngreso.Parameters.AddWithValue("@ObsIngreso", obs);
                //                            cmdIngreso.Parameters.AddWithValue("@NumIngreso", NumeroIngreso);
                //                            cmdIngreso.Parameters.AddWithValue("@UsuarioIngres", Form3Login.UsuarioActual);
                //                            cmdIngreso.Parameters.AddWithValue("@EstadoSalida", "EnMtto");
                //                            try
                //                            {
                //                                conexion.Open();
                //                                cmdIngreso.ExecuteNonQuery();
                //                                MessageBox.Show($"Activo ingresado correctamente.\nNúmero de ingreso a mantenimiento: {NumeroIngreso}");
                //                                //txtNumMtto.Text = "";
                //                                txtObservacion.Text = "";
                //                                conexion.Close();
                //                                //using (SqlConnection connnn = new SqlConnection(connectionString))
                //                                //{
                //                                string query_Sede = "UPDATE Asignacion SET Sede = NULL WHERE IdActivo = @IdActivo";

                //                                using (SqlCommand cmd_Sede = new SqlCommand(query_Sede, conn))
                //                                {
                //                                    cmd_Sede.Parameters.AddWithValue("@IdActivo", idActivo);

                //                                    conn.Open();
                //                                    cmd_Sede.ExecuteNonQuery();
                //                                    conn.Close();
                //                                }
                //                                //}


                //                            }
                //                            catch (Exception ex)
                //                            {
                //                                MessageBox.Show("Error al registrar: " + ex.Message);
                //                            }
                //                        }
                //                    }
                //                }//cierre else de null serial
                //                }
                //            }
                //        }




                //    }





                //} // Cierre de ingreso a mantenimiento






            }
            else
            {
                MessageBox.Show("No puede registrar activos para otra sede diferente a la suya.", "Error de sede", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void checkBoxFechaCompra_CheckedChanged_1(object sender, EventArgs e)
        {
            dtpFechaCompra.Enabled = checkBoxFechaCompra.Checked;
        }

        private void dtpFechaCompra_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbMarcaRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormActivos frm = FormActivos.ventana_unica(this);

            // Usamos el mismo MDI parent del formulario actual
            frm.MdiParent = this.MdiParent;

            frm.BringToFront();
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void cmbEstadoRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string seleccionEstado =  cmbEstadoRegistro.SelectedItem?.ToString();
            //lblTipoFallaMtto.Visible = false;
            //cmbTipoFalla.Visible = false;
            //lblObservacion.Visible = false;
            //txtObservacion.Visible = false;
            //if (seleccionEstado == "Con Falla")
            //{
            //    lblTipoFallaMtto.Visible = true;
            //    cmbTipoFalla.Visible = true;
            //    lblObservacion.Visible = true;
            //    txtObservacion.Visible = true;
            //    btnRegistrar.Location = new Point(179, 527);
            //}
            //else
            //{
            //    lblTipoFallaMtto.Visible = false;
            //    cmbTipoFalla.Visible = false;
            //    lblObservacion.Visible = false;
            //    txtObservacion.Visible = false;
            //    btnRegistrar.Location = posicionNormalBtn;
            //}

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbSedeAsig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}