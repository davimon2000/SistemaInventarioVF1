using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using ClosedXML.Excel;

namespace GestionInventario
{
    public partial class FormConsulta : Form
    {

        //string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        string connectionString = Conexion.cadena;
        private static FormConsulta instancia = null;
        public static FormConsulta ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormConsulta();
                return instancia;
            }
            return instancia;
        }
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void txtNumConsulta_TextChanged(object sender, EventArgs e)
        {
            //this.activosViewTableAdapter.FillByMarca(this.activosViewDS.ActivosView, "%" + txtNumConsulta.Text + "%", "%" + txtNumConsulta.Text + "%");
        }

        private void FormConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'asigEditDS.Asignacion' Puede moverla o quitarla según sea necesario.
            this.asignacionTableAdapter1.Fill(this.asigEditDS.Asignacion);
            // TODO: esta línea de código carga datos en la tabla 'mttoeditDS.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter3.Fill(this.mttoeditDS.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'mantenimiento1DS.Mantenimiento1' Puede moverla o quitarla según sea necesario.
            this.mantenimiento1TableAdapter.Fill(this.mantenimiento1DS.Mantenimiento1);
            // TODO: esta línea de código carga datos en la tabla 'asignacionDS.Asignacion' Puede moverla o quitarla según sea necesario.
            this.asignacionTableAdapter.Fill(this.asignacionDS.Asignacion);
            // TODO: esta línea de código carga datos en la tabla 'mantenimiento1DS.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter2.Fill(this.mantenimiento1DS.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'marcas1DS.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.marcas1DS.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'registroActivosDS.RegistroActivos' Puede moverla o quitarla según sea necesario.
            this.registroActivosTableAdapter1.Fill(this.registroActivosDS.RegistroActivos);
            // TODO: esta línea de código carga datos en la tabla 'mantenimientoDS.Mantenimiento' Puede moverla o quitarla según sea necesario.
            //this.mantenimientoTableAdapter1.Fill(this.mantenimientoDS.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.Mantenimiento' Puede moverla o quitarla según sea necesario.
            //this.mantenimientoTableAdapter.Fill(this.consultaActivosDS.Mantenimiento);
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.RegistroActivos' Puede moverla o quitarla según sea necesario.
            this.registroActivosTableAdapter.Fill(this.consultaActivosDS.RegistroActivos);
            // TODO: esta línea de código carga datos en la tabla 'consultaActivosDS.EditarTable' Puede moverla o quitarla según sea necesario.
            //this.editarTableTableAdapter.Fill(this.consultaActivosDS.EditarTable);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet3.RegistroActivos' Puede moverla o quitarla según sea necesario.
            // this.registroActivosTableAdapter.Fill(this.inventarioActivosDataSet3.RegistroActivos);
            // TODO: esta línea de código carga datos en la tabla 'activosViewDS.ActivosView' Puede moverla o quitarla según sea necesario.
            this.activosViewTableAdapter.Fill(this.activosViewDS.ActivosView);


            //String seleccion = cmbTabla.Text;
            //String modo = cmbModo.Text;




            //registroActivosDataGridView.Visible = true;
            //mantenimientoDataGridView.Visible = false;
            //asignacionDataGridView.Visible = false;

            //if (modo == "Vista")
            //{
            //    if (seleccion == "Registro")
            //    {
            //        registroActivosDataGridView.Visible = true;
            //        mantenimientoDataGridView.Visible = false;
            //        asignacionDataGridView.Visible = false;

            //    }
            //    if (seleccion == "Mantenimiento")
            //    {
            //        registroActivosDataGridView.Visible = false;
            //        mantenimientoDataGridView.Visible = true;
            //        asignacionDataGridView.Visible = false;

            //    }
            //    if (seleccion == "Asignacion")
            //    {
            //        registroActivosDataGridView.Visible = false;
            //        mantenimientoDataGridView.Visible = false;
            //        asignacionDataGridView.Visible = true;

            //    }
            //}else if (modo == "Edicion")
            //{
            //    registroActivosDataGridView.Visible = false;
            //    mantenimientoDataGridView.Visible = false;
            //    asignacionDataGridView.Visible = false;
            //}



            String seleccion = cmbTabla.Text;
            String modo = cmbModo.Text;
            //modo = "Vista";



            registroActivosDataGridView.Visible = true;
            bindingNavigatorDeleteItemRegistro.Visible = false;
            guardarToolStripButtonRegistro.Visible = false;
            mantenimientoDataGridView.Visible = false;
            asignacionDataGridView.Visible = false;
            mantenimientoDataGridViewEdit.Visible = false;
            asignacionDataGridViewEdit.Visible = false;
            bindingNavigatorRegistro.Visible = true;
            bindingNavigatorMtto.Visible = false;
            bindingNavigatormttoedit.Visible = false;
            bindingNavigatorAsignacion.Visible = false;
            bindingNavigatorAsigEdit.Visible = false;

            if (modo == "Vista")
            {
                if (seleccion == "Registro")
                {
                    registroActivosDataGridView.Visible = true;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = false;
                    asignacionDataGridView.Visible = false;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = true;
                    bindingNavigatorMtto.Visible = false;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = false;
                    bindingNavigatorAsigEdit.Visible = false;

                }
                if (seleccion == "Mantenimiento")
                {
                    registroActivosDataGridView.Visible = false;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = true;
                    asignacionDataGridView.Visible = false;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = false;
                    bindingNavigatorMtto.Visible = true;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = false;
                    bindingNavigatorAsigEdit.Visible = false;

                }
                if (seleccion == "Asignacion")
                {
                    registroActivosDataGridView.Visible = false;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = false;
                    asignacionDataGridView.Visible = true;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = false;
                    bindingNavigatorMtto.Visible = false;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = true;
                    bindingNavigatorAsigEdit.Visible = false;

                }
            }
            else if (modo == "Edicion")
            {
                string usuarioConsulta = Form3Login.UsuarioActual;
                string rolActual = this.ObtenerRolUsuario(usuarioConsulta);

                if (rolActual == "Administrador")
                {

                    if (seleccion == "Registro")
                    {
                        registroActivosDataGridView.Visible = true;
                        bindingNavigatorDeleteItemRegistro.Visible = true;
                        guardarToolStripButtonRegistro.Visible = true;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = false;
                        asignacionDataGridViewEdit.Visible = false;
                        bindingNavigatorRegistro.Visible = true;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = false;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = false;

                    }
                    if (seleccion == "Mantenimiento")
                    {
                        registroActivosDataGridView.Visible = false;
                        bindingNavigatorDeleteItemRegistro.Visible = false;
                        guardarToolStripButtonRegistro.Visible = false;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = true;
                        asignacionDataGridViewEdit.Visible = false;
                        bindingNavigatorRegistro.Visible = false;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = true;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = false;

                    }
                    if (seleccion == "Asignacion")
                    {
                        registroActivosDataGridView.Visible = false;
                        bindingNavigatorDeleteItemRegistro.Visible = false;
                        guardarToolStripButtonRegistro.Visible = false;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = false;
                        asignacionDataGridViewEdit.Visible = true;
                        bindingNavigatorRegistro.Visible = false;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = false;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = true;

                    }


                }
                else
                {
                    MessageBox.Show("Es necesario ingresar como Administrador", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //cmbModo.SelectedIndex = 1;
                    cmbModo.SelectedIndexChanged -= cmbModo_SelectedIndexChanged;
                    cmbModo.SelectedIndex = 0;
                    cmbModo.SelectedIndexChanged += cmbModo_SelectedIndexChanged;
                    return;
                }


            }











        }

        private void lblNumeroConsulta_Click(object sender, EventArgs e)
        {

        }

        private void activosViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroConsulta_TextChanged(object sender, EventArgs e)
        {
            //this.activosViewTableAdapter.FillByNumero(this.activosViewDS.ActivosView, "%" + txtNumeroConsulta.Text + "%");

            //this.registroActivosDataGridView.FillByNumero(this.consultaActivosDS.RegistroActivos, "%" + txtNumeroConsulta.Text + "%");
            //this.registroActivosTableAdapter.FillByNumero(this.consultaActivosDS.RegistroActivos, "%" + txtNumeroConsulta.Text + "%");

            this.registroActivosTableAdapter1.FillByNumero(registroActivosDS.RegistroActivos,
        "%" + txtNumeroConsulta.Text + "%");

            this.mantenimientoTableAdapter2.FillByNumero(
        mantenimiento1DS.Mantenimiento,
        "%" + txtNumeroConsulta.Text + "%"
    );

            asignacionTableAdapter.FillByNumero(
        asignacionDS.Asignacion,
        "%" + txtNumeroConsulta.Text + "%"
    );
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarTablaAExcel();
        }
        private void ExportarTablaAExcel()
        {
            //string query = "SELECT * FROM VistaActivos";  // Puedes cambiarlo por otra tabla o vista
            //string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //using (SqlCommand cmd = new SqlCommand(query, conn))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            //{
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);

            //    using (XLWorkbook wb = new XLWorkbook())
            //    {
            //        wb.Worksheets.Add(dt, "Activos");

            //        SaveFileDialog saveFile = new SaveFileDialog();
            //        saveFile.Filter = "Excel Workbook|*.xlsx";
            //        saveFile.Title = "Guardar archivo Excel";
            //        saveFile.FileName = "ReporteActivos.xlsx";

            //        if (saveFile.ShowDialog() == DialogResult.OK)
            //        {   
            //            wb.SaveAs(saveFile.FileName);
            //            MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel (*.xlsx)|*.xlsx";
            sfd.FileName = "Inventario.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    // Hoja 1 - Registro
                    wb.Worksheets.Add( 
                        registroActivosDS.RegistroActivos.Copy(),
                        "RegistroActivos"
                    );

                    // Hoja 2 - Mantenimiento
                    wb.Worksheets.Add(
                        mantenimiento1DS.Mantenimiento.Copy(),
                        "Mantenimiento"
                    );

                    // Hoja 3 - Asignación
                    wb.Worksheets.Add(
                        asignacionDS.Asignacion.Copy(),
                        "Asignacion"
                    );

                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show(
                    "Exportación realizada correctamente",
                    "Excel",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }





        }

        private void ExportarTablaAExcelMtto()
        {
            //string query = "SELECT * FROM VistaMtto";  // Puedes cambiarlo por otra tabla o vista
            //string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //using (SqlCommand cmd = new SqlCommand(query, conn))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            //{
            //    DataTable dt = new DataTable();
            //    adapter.Fill(dt);

            //    using (XLWorkbook wb = new XLWorkbook())
            //    {
            //        wb.Worksheets.Add(dt, "Activos");

            //        SaveFileDialog saveFile = new SaveFileDialog();
            //        saveFile.Filter = "Excel Workbook|*.xlsx";
            //        saveFile.Title = "Guardar archivo Excel";
            //        saveFile.FileName = "ReporteMtto.xlsx";

            //        if (saveFile.ShowDialog() == DialogResult.OK)
            //        {
            //            wb.SaveAs(saveFile.FileName);
            //            MessageBox.Show("Exportación exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //}
        }

        private void mantenimientoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void activosViewBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportarTablaAExcelMtto();
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String seleccion = cmbTabla.Text;
            //if (seleccion == "Registro")
            //{
            //    registroActivosDataGridView.Visible = true;
            //    mantenimientoDataGridView.Visible = false;
            //    asignacionDataGridView.Visible = false;

            //}
            //if (seleccion == "Mantenimiento")
            //{
            //    registroActivosDataGridView.Visible = false;
            //    mantenimientoDataGridView.Visible = true;
            //    asignacionDataGridView.Visible = false;

            //}
            //if (seleccion == "Asignacion")
            //{
            //    registroActivosDataGridView.Visible = false;
            //    mantenimientoDataGridView.Visible = false;
            //    asignacionDataGridView.Visible = true;

            //}

            String seleccion = cmbTabla.Text;
            String modo = cmbModo.Text;




            registroActivosDataGridView.Visible = true;
            bindingNavigatorDeleteItemRegistro.Visible = false;
            guardarToolStripButtonRegistro.Visible = false;
            mantenimientoDataGridView.Visible = false;
            asignacionDataGridView.Visible = false;
            mantenimientoDataGridViewEdit.Visible = false;
            asignacionDataGridViewEdit.Visible = false;
            bindingNavigatorRegistro.Visible = true;
            bindingNavigatorMtto.Visible = false;
            bindingNavigatormttoedit.Visible = false;
            bindingNavigatorAsignacion.Visible = false;
            bindingNavigatorAsigEdit.Visible = false;

            if (modo == "Vista")
            {
                if (seleccion == "Registro")
                {
                    registroActivosDataGridView.Visible = true;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = false;
                    asignacionDataGridView.Visible = false;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = true;
                    bindingNavigatorMtto.Visible = false;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = false;
                    bindingNavigatorAsigEdit.Visible = false;

                }
                if (seleccion == "Mantenimiento")
                {
                    registroActivosDataGridView.Visible = false;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = true;
                    asignacionDataGridView.Visible = false;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = false;
                    bindingNavigatorMtto.Visible = true;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = false;
                    bindingNavigatorAsigEdit.Visible = false;

                }
                if (seleccion == "Asignacion")
                {
                    registroActivosDataGridView.Visible = false;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = false;
                    asignacionDataGridView.Visible = true;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = false;
                    bindingNavigatorMtto.Visible = false;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = true;
                    bindingNavigatorAsigEdit.Visible = false;

                }
            }
            else if (modo == "Edicion")
            {
                string usuarioConsulta = Form3Login.UsuarioActual;
                string rolActual = this.ObtenerRolUsuario(usuarioConsulta);

                if (rolActual == "Administrador")
                {

                    if (seleccion == "Registro")
                    {
                        registroActivosDataGridView.Visible = true;
                        bindingNavigatorDeleteItemRegistro.Visible = true;
                        guardarToolStripButtonRegistro.Visible = true;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = false;
                        asignacionDataGridViewEdit.Visible = false;
                        bindingNavigatorRegistro.Visible = true;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = false;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = false;

                    }
                    if (seleccion == "Mantenimiento")
                    {
                        registroActivosDataGridView.Visible = false;
                        bindingNavigatorDeleteItemRegistro.Visible = false;
                        guardarToolStripButtonRegistro.Visible = false;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = true;
                        asignacionDataGridViewEdit.Visible = false;
                        bindingNavigatorRegistro.Visible = false;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = true;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = false;

                    }
                    if (seleccion == "Asignacion")
                    {
                        registroActivosDataGridView.Visible = false;
                        bindingNavigatorDeleteItemRegistro.Visible = false;
                        guardarToolStripButtonRegistro.Visible = false;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = false;
                        asignacionDataGridViewEdit.Visible = true;
                        bindingNavigatorRegistro.Visible = false;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = false;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = true;

                    }


                }
                else
                {
                    MessageBox.Show("Es necesario ingresar como Administrador", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


            }
        }

        private void activosViewBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void registroActivosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void copiarToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void guardarToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                //registroActivosBindingSource.EndEdit();
                //registroActivosTableAdapter.Update(mantenimiento1DS.Mantenimiento);

                //mantenimiento1BindingSource.EndEdit();
                //mantenimientoTableAdapter.Update(Mantenimiento1DS.Mantenimiento);
                //mantenimiento1TableAdapter.Update(Mantenimiento1DS.Mantenimiento1);

                mantenimientoBindingSource3.EndEdit();
                mantenimientoTableAdapter3.Update(mttoeditDS.Mantenimiento);


                MessageBox.Show(
                    "Cambios guardados correctamente en Mantenimiento",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void guardarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                registroActivosBindingSource1.EndEdit();
                //registroActivosTableAdapter.Update(registroActivosDS.RegistroActivos);
                registroActivosTableAdapter1.Update(registroActivosDS.RegistroActivos);


                MessageBox.Show(
                    "Cambios guardados correctamente en RegistroActivos",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String seleccion = cmbTabla.Text;
            String modo = cmbModo.Text;




            registroActivosDataGridView.Visible = true;
            bindingNavigatorDeleteItemRegistro.Visible = false;
            guardarToolStripButtonRegistro.Visible = false;
            mantenimientoDataGridView.Visible = false;
            asignacionDataGridView.Visible = false;
            mantenimientoDataGridViewEdit.Visible = false;
            asignacionDataGridViewEdit.Visible = false;
            bindingNavigatorRegistro.Visible = true;
            bindingNavigatorMtto.Visible = false;
            bindingNavigatormttoedit.Visible = false;
            bindingNavigatorAsignacion.Visible = false;
            bindingNavigatorAsigEdit.Visible = false;

            if (modo == "Vista")
            {
                if (seleccion == "Registro")
                {
                    registroActivosDataGridView.Visible = true;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = false;
                    asignacionDataGridView.Visible = false;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = true;
                    bindingNavigatorMtto.Visible = false;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = false;
                    bindingNavigatorAsigEdit.Visible = false;

                }
                if (seleccion == "Mantenimiento")
                {
                    registroActivosDataGridView.Visible = false;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = true;
                    asignacionDataGridView.Visible = false;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = false;
                    bindingNavigatorMtto.Visible = true;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = false;
                    bindingNavigatorAsigEdit.Visible = false;

                }
                if (seleccion == "Asignacion")
                {
                    registroActivosDataGridView.Visible = false;
                    bindingNavigatorDeleteItemRegistro.Visible = false;
                    guardarToolStripButtonRegistro.Visible = false;
                    mantenimientoDataGridView.Visible = false;
                    asignacionDataGridView.Visible = true;
                    mantenimientoDataGridViewEdit.Visible = false;
                    asignacionDataGridViewEdit.Visible = false;
                    bindingNavigatorRegistro.Visible = false;
                    bindingNavigatorMtto.Visible = false;
                    bindingNavigatormttoedit.Visible = false;
                    bindingNavigatorAsignacion.Visible = true;
                    bindingNavigatorAsigEdit.Visible = false;

                }
            }
            else if (modo == "Edicion")
            {
                string usuarioConsulta = Form3Login.UsuarioActual;
                string rolActual = this.ObtenerRolUsuario(usuarioConsulta);

                if (rolActual == "Administrador")
                {

                    if (seleccion == "Registro")
                    {
                        registroActivosDataGridView.Visible = true;
                        bindingNavigatorDeleteItemRegistro.Visible = true;
                        guardarToolStripButtonRegistro.Visible = true;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = false;
                        asignacionDataGridViewEdit.Visible = false;
                        bindingNavigatorRegistro.Visible = true;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = false;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = false;

                    }
                    if (seleccion == "Mantenimiento")
                    {
                        registroActivosDataGridView.Visible = false;
                        bindingNavigatorDeleteItemRegistro.Visible = false;
                        guardarToolStripButtonRegistro.Visible = false;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = true;
                        asignacionDataGridViewEdit.Visible = false;
                        bindingNavigatorRegistro.Visible = false;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = true;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = false;

                    }
                    if (seleccion == "Asignacion")
                    {
                        registroActivosDataGridView.Visible = false;
                        bindingNavigatorDeleteItemRegistro.Visible = false;
                        guardarToolStripButtonRegistro.Visible = false;
                        mantenimientoDataGridView.Visible = false;
                        asignacionDataGridView.Visible = false;
                        mantenimientoDataGridViewEdit.Visible = false;
                        asignacionDataGridViewEdit.Visible = true;
                        bindingNavigatorRegistro.Visible = false;
                        bindingNavigatorMtto.Visible = false;
                        bindingNavigatormttoedit.Visible = false;
                        bindingNavigatorAsignacion.Visible = false;
                        bindingNavigatorAsigEdit.Visible = true;

                    }


                }
                else
                {
                    MessageBox.Show("Es necesario ingresar como Administrador", "Informacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }

                
            }
        }
        private String ObtenerRolUsuario(string usuario)
        {
            string rolUsuarioActual = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT Rol
            FROM Usuarios
            WHERE Usuario = @Usuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        rolUsuarioActual = result.ToString();
                    else
                        rolUsuarioActual = "SinRol";
                }
                return rolUsuarioActual;
            }
        }

        
        private void mantenimientoDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void guardarToolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                //registroActivosBindingSource.EndEdit();
                //registroActivosTableAdapter.Update(registroActivosDS.RegistroActivos);
                //registroActivosTableAdapter1.Update(registroActivosDS.RegistroActivos);

                mantenimientoBindingSource3.EndEdit();
                mantenimientoTableAdapter3.Update(mttoeditDS.Mantenimiento);


                MessageBox.Show(
                    "Cambios guardados correctamente en Mantenimiento",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void guardarToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

                this.Validate();

                //mantenimientoBindingSource3.EndEdit();
                //mantenimientoTableAdapter3.Update(mttoeditDS.Mantenimiento);

                asignacionBindingSource1.EndEdit();
                asignacionTableAdapter1.Update(asigEditDS.Asignacion);

                MessageBox.Show(
                    "Cambios guardados correctamente en Mantenimiento",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );



            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void asignacionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void asignacionDataGridViewEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtUsuariobb_TextChanged(object sender, EventArgs e)
        {
            asignacionTableAdapter.FillByUsuariobb(
        asignacionDS.Asignacion,
        "%" + txtUsuariobb.Text + "%"
    );
        }

        private void mantenimientoDataGridViewEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
