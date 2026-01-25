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
    public partial class FormSalida : Form
    {
        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormSalida instancia = null;
        public static FormSalida ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormSalida();
                return instancia;
            }
            return instancia;
        }
        public FormSalida()
        {
            InitializeComponent();
        }

        private void cmbAreaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresoMtto_Click(object sender, EventArgs e)
        {
            try
            {
                // Valores del formulario
                string numeroActivo = txtNumAsig.Text;
                DateTime fechaAsign = dtpFechaAsig.Value;
                //String Sede = cmbSedeAsig.SelectedItem.ToString();
                int Sede = Convert.ToInt32(cmbSedeAsig.SelectedValue);
                //String Area = cmbAreaAsig.SelectedItem.ToString();
                int InventarioId = 0;
                bool Disponible = true;
                 string observacion = txtObservacion.Text;
                string usuarioAsig = txtUsuarioAsig.Text;
                string CondicionEntrega = cmbCondicionEntrega.SelectedItem.ToString();


                if (Sede == Form3Login.SedeIdUsuarioSistema || Form3Login.RolUsuarioSistema == "Administrador")
                {


                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string queryId = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Numero";
                        using (SqlCommand cmd = new SqlCommand(queryId, conn))
                        {
                            cmd.Parameters.AddWithValue("@Numero", numeroActivo);
                            object result = cmd.ExecuteScalar();
                            //InventarioId = Convert.ToInt32(result);

                            if (result == null)
                            {
                                MessageBox.Show("El activo no se encuentra registrado.");
                                return;
                            }
                            //else
                            //{//ABRE ABC

                            InventarioId = Convert.ToInt32(result);
                        }


                        string queryExistenciaMtto = @"
                            SELECT TOP 1 EstadoSalida
                            FROM Mantenimiento
                            WHERE InventarioId = @InventarioId
                            ORDER BY Id DESC"; // o por FechaIngresoMtto DESC

                        using (SqlCommand cmdExistMtto = new SqlCommand(queryExistenciaMtto, conn))
                        {
                            //conn.Open();
                            cmdExistMtto.Parameters.AddWithValue("@InventarioId", InventarioId);
                            object resultEstado = cmdExistMtto.ExecuteScalar();
                            string estadoMtto = resultEstado?.ToString();
                            //conn.Close();


                            //    string queryEstadoRegistro = @"
                            //SELECT EstadoRegistro
                            //FROM RegistroActivos
                            //WHERE Id = @InventarioId";

                            //    using (SqlCommand cmdEstadoRegistro = new SqlCommand(queryEstadoRegistro, conn))
                            //    {
                            //        //conn.Open();
                            //        cmdEstadoRegistro.Parameters.AddWithValue("@InventarioId", InventarioId);
                            //        object resultEstadoRegistro = cmdEstadoRegistro.ExecuteScalar();
                            //        string estadoRegistro = resultEstadoRegistro?.ToString();
                            //        //conn.Close();


                            //        //MessageBox.Show("estadoMtto" + estadoMtto);
                            //        //MessageBox.Show("estadoRegistro" + estadoRegistro);

                            //        if (estadoMtto == "EnMtto" || estadoMtto == "Baja")
                            //        {
                            //            Disponible = false;
                            //        }
                            //        else if(estadoMtto == "Disponible")
                            //        {
                            //            Disponible=true;
                            //        }
                            //        else if (estadoRegistro == "Baja" || estadoRegistro == "Con Falla")
                            //        {
                            //            Disponible = false;
                            //        }




                            //        if (Disponible == true)
                            //        {





                            //            //InventarioId = Convert.ToInt32(result);
                            //            string queryExistencia = "SELECT COUNT(*) FROM Asignacion WHERE IdActivo = @IdActivo";
                            //            using (SqlCommand cmdExist = new SqlCommand(queryExistencia, conn))
                            //            {
                            //                cmdExist.Parameters.AddWithValue("@IdActivo", InventarioId);
                            //                int count = (int)cmdExist.ExecuteScalar();

                            //                if (count > 0)
                            //                {
                            //                    // Si ya existe, actualizar
                            //                    string updateQuery = @"UPDATE Asignacion 
                            //                   SET Sede = @Sede, FechaAsignacion = @Fecha
                            //                   WHERE IdActivo = @IdActivo";

                            //                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                            //                    {
                            //                        cmdUpdate.Parameters.AddWithValue("@Sede", Sede);
                            //                        //cmdUpdate.Parameters.AddWithValue("@Area", Area);
                            //                        cmdUpdate.Parameters.AddWithValue("@Fecha", fechaAsign);
                            //                        cmdUpdate.Parameters.AddWithValue("@IdActivo", InventarioId);

                            //                        cmdUpdate.ExecuteNonQuery();
                            //                        MessageBox.Show("Asignación actualizada correctamente.");
                            //                    }
                            //                }
                            //                else
                            //                {
                            //                    // Si no existe, insertar
                            //                    string insertQuery = @"INSERT INTO Asignacion (Sede, FechaAsignacion, IdActivo) 
                            //                   VALUES (@Sede, @Fecha, @idActivo)";

                            //                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                            //                    {
                            //                        cmdInsert.Parameters.AddWithValue("@Sede", Sede);
                            //                        // cmdInsert.Parameters.AddWithValue("@Area", Area);
                            //                        cmdInsert.Parameters.AddWithValue("@Fecha", fechaAsign);
                            //                        cmdInsert.Parameters.AddWithValue("@idActivo", InventarioId);
                            //                        try
                            //                        {
                            //                            cmdInsert.ExecuteNonQuery();
                            //                            MessageBox.Show("Asignación registrada correctamente.");
                            //                        }
                            //                        catch (Exception ex)
                            //                        {
                            //                            MessageBox.Show("Error: " + ex.Message);
                            //                        }
                            //                    }
                            //                }
                            //            }

                            //        }
                            //        else
                            //        {
                            //            MessageBox.Show("El activo no se encuentra disponible para asignación.");
                            //        }


                            //    }

                            if (resultEstado != null && estadoMtto == "EnMtto")
                            {
                                MessageBox.Show("El activo se encuentra actualmente en mantenimiento.");
                                return;
                            }


                            //}


                            //} //CIERRE ABC
                            //else
                            //{
                            //    MessageBox.Show("El activo no se encuentra registrado.");
                            //}
                        }



                        int usuarioId;








                        bool estaAsignado = false;

                        // Consulta último estado de asignación
                        string queryAsignacion = @"
                    SELECT TOP 1 UsuarioId, FechaDevolucion
                    FROM Asignacion
                    WHERE IdActivo = @InventarioId
                    ORDER BY Id DESC";

                        using (SqlCommand cmdAsign = new SqlCommand(queryAsignacion, conn))
                        {
                            cmdAsign.Parameters.AddWithValue("@InventarioId", InventarioId);

                            using (SqlDataReader dr = cmdAsign.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    if (dr["FechaDevolucion"] == DBNull.Value &&
                                        dr["UsuarioId"] != DBNull.Value)
                                    {
                                        estaAsignado = true;
                                    }
                                }
                            }
                        }

                        // 👉 DECISIÓN SEGÚN MOVIMIENTO
                        if (cmbConceptoAsig.SelectedItem.ToString() == "Asignacion")
                        {
                            if (estaAsignado)
                            {
                                MessageBox.Show("El activo ya se encuentra asignado.");
                                return;
                            }


                            string queryUsuario = @"
                    SELECT Id
                    FROM UsuariosAD
                    WHERE UsuarioRed = @UsuarioRed
                      AND Estado = 1";

                            using (SqlCommand cmdUser = new SqlCommand(queryUsuario, conn))
                            {
                                cmdUser.Parameters.AddWithValue("@UsuarioRed", txtUsuarioAsig.Text.Trim());
                                object resultUser = cmdUser.ExecuteScalar();

                                if (resultUser == null)
                                {
                                    MessageBox.Show("El usuario no existe o está inactivo.");
                                    return;
                                }

                                usuarioId = Convert.ToInt32(resultUser);
                            }





                            // INSERT ASIGNACIÓN
                            string insertAsignar = @"
                        INSERT INTO Asignacion
                        (IdActivo, UsuarioId, SedeId, FechaAsignacion, Observacion, UsuarioSistema, CondicionEntrega)
                        VALUES
                        (@InventarioId, @UsuarioId, @SedeId, GETDATE(), @Obs, @UsuarioSistema, @CondicionEntrega)";

                            using (SqlCommand cmdInsert = new SqlCommand(insertAsignar, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@InventarioId", InventarioId);
                                cmdInsert.Parameters.AddWithValue("@UsuarioId", usuarioId);
                                cmdInsert.Parameters.AddWithValue("@SedeId", Sede);
                                cmdInsert.Parameters.AddWithValue("@Obs", txtObservacion.Text);
                                cmdInsert.Parameters.AddWithValue("@UsuarioSistema", Form3Login.UsuarioActual);
                                cmdInsert.Parameters.AddWithValue("@CondicionEntrega", CondicionEntrega);   

                                cmdInsert.ExecuteNonQuery();
                            }
                            MessageBox.Show("Activo asignado correctamente");


                        }
                        else // DEVOLVER
                        {
                            if (!estaAsignado)
                            {
                                MessageBox.Show("El activo no se encuentra asignado.");
                                return;
                            }

                            // INSERT DEVOLUCIÓN
                            string insertDevolver = @"
                        INSERT INTO Asignacion
                        (IdActivo, UsuarioId, SedeId, FechaDevolucion, Observacion, UsuarioSistema, EstadoDevolucion)
                        VALUES
                        (@InventarioId, NULL, @SedeId, GETDATE(), @Obs, @UsuarioSistema, @EstadoDevolucion)";

                            using (SqlCommand cmdInsert = new SqlCommand(insertDevolver, conn))
                            {
                                cmdInsert.Parameters.AddWithValue("@InventarioId", InventarioId);
                                cmdInsert.Parameters.AddWithValue("@SedeId", Sede);
                                cmdInsert.Parameters.AddWithValue("@Obs", txtObservacion.Text);
                                cmdInsert.Parameters.AddWithValue("@UsuarioSistema", Form3Login.UsuarioActual);
                                cmdInsert.Parameters.AddWithValue("@EstadoDevolucion", cmbEstadoDevolucion.SelectedItem.ToString());

                                cmdInsert.ExecuteNonQuery();
                            }



                        }



                    }
                }
                else
                {
                    MessageBox.Show("No tiene permiso para asignar activos en esta sede.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            }

        private void FormSalida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sedesDS.Sedes' Puede moverla o quitarla según sea necesario.
            this.sedesTableAdapter.Fill(this.sedesDS.Sedes);

            lblNumeroAsig.Visible = true;
            lblFechaAsig.Visible = true;    
            dtpFechaAsig.Visible = true;    
            lblSede.Visible = true;
            cmbSedeAsig.Visible = true;
            lblObservacion.Visible = true;
            txtObservacion.Visible = true;
            btnAsign.Visible = true;
            lblusuarioAsig.Visible = true;
            txtUsuarioAsig.Visible = true;
            lblCondicionEntrega.Visible = true;
            cmbCondicionEntrega.Visible = true;

            lblFechaDev.Visible = false;
            dtpFechaDev.Visible = false;
            btnDevolver.Visible = false;
            lblEstadoDevolucion.Visible = false;
            cmbEstadoDevolucion.Visible = false;



        }

        private void cmbConceptoAsig_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbConceptoAsig.SelectedItem.ToString();
            if(seleccion == "Asignacion")
            {
                lblNumeroAsig.Visible = true;
                lblFechaAsig.Visible = true;
                dtpFechaAsig.Visible = true;
                lblSede.Visible = true;
                cmbSedeAsig.Visible = true;
                lblObservacion.Visible = true;
                txtObservacion.Visible = true;
                btnAsign.Visible = true;
                lblusuarioAsig.Visible = true;
                txtUsuarioAsig.Visible = true;
                lblCondicionEntrega.Visible = true;
                cmbCondicionEntrega.Visible = true;

                lblFechaDev.Visible = false;
                dtpFechaDev.Visible = false;
                btnDevolver.Visible = false;
                lblEstadoDevolucion.Visible = false;
                cmbEstadoDevolucion.Visible = false;
            }
            else
            {
                lblNumeroAsig.Visible = true;
                lblFechaAsig.Visible = false;
                dtpFechaAsig.Visible = false;
                lblSede.Visible = true;
                cmbSedeAsig.Visible = true;
                lblObservacion.Visible = true;
                txtObservacion.Visible = true;
                btnAsign.Visible = false;
                lblusuarioAsig.Visible = false;
                txtUsuarioAsig.Visible = false;
                lblCondicionEntrega.Visible = false;
                cmbCondicionEntrega.Visible = false;

                lblFechaDev.Visible = true;
                dtpFechaDev.Visible = true;
                btnDevolver.Visible = true;
                lblEstadoDevolucion.Visible = true;
                cmbEstadoDevolucion.Visible = true;

            }
        }

        private void lblAsignacion_Click(object sender, EventArgs e)
        {

        }


        private int ObtenerInventarioId(SqlConnection conn, string codInterno)
        {
            string query = "SELECT Id FROM RegistroActivos WHERE CodInterno = @Cod";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Cod", codInterno);
                object result = cmd.ExecuteScalar();

                if (result == null)
                    throw new Exception("El activo no existe.");

                return Convert.ToInt32(result);
            }
        }

        private void ValidarNoEnMtto(SqlConnection conn, int inventarioId)
        {
            string query = @"
        SELECT TOP 1 EstadoSalida
        FROM Mantenimiento
        WHERE InventarioId = @Id
        ORDER BY Id DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", inventarioId);
                object estado = cmd.ExecuteScalar();

                if (estado != null && estado.ToString() == "EnMtto")
                    throw new Exception("El activo está en mantenimiento.");
            }
        }

        private bool EstaAsignado(SqlConnection conn, int inventarioId)
        {
            string query = @"
        SELECT TOP 1 UsuarioId, FechaDevolucion
        FROM Asignacion
        WHERE IdActivo = @Id
        ORDER BY Id DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", inventarioId);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        return dr["UsuarioId"] != DBNull.Value &&
                               dr["FechaDevolucion"] == DBNull.Value;
                    }
                }
            }

            return false;
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {


            string numeroActivo = txtNumAsig.Text;
            DateTime fechaAsign = dtpFechaAsig.Value;
            //String Sede = cmbSedeAsig.SelectedItem.ToString();
            int Sede = Convert.ToInt32(cmbSedeAsig.SelectedValue);
            //String Area = cmbAreaAsig.SelectedItem.ToString();
            int InventarioId = 0;
            bool Disponible = true;
            string observacion = txtObservacion.Text;
            string usuarioAsig = txtUsuarioAsig.Text;
            
            String EstadoDevolucion = cmbEstadoDevolucion.SelectedItem.ToString();


            try
            {
                if (Sede == Form3Login.SedeIdUsuarioSistema)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        int inventarioId = ObtenerInventarioId(conn, txtNumAsig.Text.Trim());
                        ValidarNoEnMtto(conn, inventarioId);

                        if (!EstaAsignado(conn, inventarioId))
                        {
                            MessageBox.Show("El activo no está asignado.");
                            return;
                        }

                        string insert = @"
                INSERT INTO Asignacion
                (IdActivo, UsuarioId, SedeId, FechaDevolucion, Observacion, UsuarioSistema)
                VALUES
                (@Inv, NULL, @Sede, GETDATE(), @Obs, @UsuarioSistema)";

                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@Inv", inventarioId);
                            cmd.Parameters.AddWithValue("@Sede", Sede);
                            cmd.Parameters.AddWithValue("@Obs", txtObservacion.Text);
                            cmd.Parameters.AddWithValue("@UsuarioSistema", Form3Login.UsuarioActual);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Activo devuelto correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("No tiene permiso para modificar activos en esta sede.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
