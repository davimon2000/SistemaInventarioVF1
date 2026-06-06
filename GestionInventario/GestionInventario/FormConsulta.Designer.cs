using System.Drawing;
using System.Windows.Forms;
namespace GestionInventario
{
    partial class FormConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.activosViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activosViewDS = new GestionInventario.ActivosViewDS();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroConsulta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.activosViewTableAdapter = new GestionInventario.ActivosViewDSTableAdapters.ActivosViewTableAdapter();
            this.tableAdapterManager = new GestionInventario.ActivosViewDSTableAdapters.TableAdapterManager();
            this.mantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaActivosDS = new GestionInventario.ConsultaActivosDS();
            this.registroActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editarTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new GestionInventario.ConsultaActivosDSTableAdapters.TableAdapterManager();
            this.registroActivosTableAdapter = new GestionInventario.ConsultaActivosDSTableAdapters.RegistroActivosTableAdapter();
            this.editarTableTableAdapter = new GestionInventario.ConsultaActivosDSTableAdapters.EditarTableTableAdapter();
            this.mantenimientoTableAdapter = new GestionInventario.ConsultaActivosDSTableAdapters.MantenimientoTableAdapter();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcas1DS = new GestionInventario.Marcas1DS();
            this.registroActivosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registroActivosDS = new GestionInventario.RegistroActivosDS();
            this.marcasTableAdapter = new GestionInventario.Marcas1DSTableAdapters.MarcasTableAdapter();
            this.registroActivosTableAdapter1 = new GestionInventario.RegistroActivosDSTableAdapters.RegistroActivosTableAdapter();
            this.tableAdapterManager3 = new GestionInventario.RegistroActivosDSTableAdapters.TableAdapterManager();
            this.mantenimientoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoDS = new GestionInventario.MantenimientoDS();
            this.mantenimientoTableAdapter1 = new GestionInventario.MantenimientoDSTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager2 = new GestionInventario.MantenimientoDSTableAdapters.TableAdapterManager();
            this.mantenimiento1DS = new GestionInventario.Mantenimiento1DS();
            this.mantenimientoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoTableAdapter2 = new GestionInventario.Mantenimiento1DSTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager4 = new GestionInventario.Mantenimiento1DSTableAdapters.TableAdapterManager();
            this.asignacionDS = new GestionInventario.AsignacionDS();
            this.asignacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionTableAdapter = new GestionInventario.AsignacionDSTableAdapters.AsignacionTableAdapter();
            this.tableAdapterManager5 = new GestionInventario.AsignacionDSTableAdapters.TableAdapterManager();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorRegistro = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItemRegistro = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripButtonRegistro = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMtto = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAsignacion = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.mantenimiento1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimiento1TableAdapter = new GestionInventario.Mantenimiento1DSTableAdapters.Mantenimiento1TableAdapter();
            this.mttoeditDS = new GestionInventario.mttoeditDS();
            this.mantenimientoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mantenimientoTableAdapter3 = new GestionInventario.mttoeditDSTableAdapters.MantenimientoTableAdapter();
            this.tableAdapterManager6 = new GestionInventario.mttoeditDSTableAdapters.TableAdapterManager();
            this.bindingNavigatormttoedit = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.asigEditDS = new GestionInventario.AsigEditDS();
            this.asignacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asignacionTableAdapter1 = new GestionInventario.AsigEditDSTableAdapters.AsignacionTableAdapter();
            this.tableAdapterManager7 = new GestionInventario.AsigEditDSTableAdapters.TableAdapterManager();
            this.bindingNavigatorAsigEdit = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.registroActivosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientoDataGridView = new System.Windows.Forms.DataGridView();
            this.CodInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mantenimientoDataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignacionDataGridViewEdit = new System.Windows.Forms.DataGridView();
            this.asignacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsuariobb = new System.Windows.Forms.TextBox();
            this.UsuarioTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaActivosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editarTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcas1DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimiento1DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorRegistro)).BeginInit();
            this.bindingNavigatorRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMtto)).BeginInit();
            this.bindingNavigatorMtto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAsignacion)).BeginInit();
            this.bindingNavigatorAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimiento1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mttoeditDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatormttoedit)).BeginInit();
            this.bindingNavigatormttoedit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asigEditDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAsigEdit)).BeginInit();
            this.bindingNavigatorAsigEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridViewEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataGridViewEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRegistro.Location = new System.Drawing.Point(472, 50);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(133, 32);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.Text = "CONSULTA";
            // 
            // activosViewBindingSource
            // 
            this.activosViewBindingSource.DataMember = "ActivosView";
            this.activosViewBindingSource.DataSource = this.activosViewDS;
            // 
            // activosViewDS
            // 
            this.activosViewDS.DataSetName = "ActivosViewDS";
            this.activosViewDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(559, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo o serial:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumeroConsulta
            // 
            this.txtNumeroConsulta.Location = new System.Drawing.Point(745, 130);
            this.txtNumeroConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroConsulta.Name = "txtNumeroConsulta";
            this.txtNumeroConsulta.Size = new System.Drawing.Size(261, 22);
            this.txtNumeroConsulta.TabIndex = 30;
            this.txtNumeroConsulta.TextChanged += new System.EventHandler(this.txtNumeroConsulta_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 617);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 41);
            this.button1.TabIndex = 31;
            this.button1.Text = "EXPORTAR EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // activosViewTableAdapter
            // 
            this.activosViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = GestionInventario.ActivosViewDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mantenimientoBindingSource
            // 
            this.mantenimientoBindingSource.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource.DataSource = this.consultaActivosDS;
            // 
            // consultaActivosDS
            // 
            this.consultaActivosDS.DataSetName = "ConsultaActivosDS";
            this.consultaActivosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroActivosBindingSource
            // 
            this.registroActivosBindingSource.DataMember = "RegistroActivos";
            this.registroActivosBindingSource.DataSource = this.consultaActivosDS;
            // 
            // editarTableBindingSource
            // 
            this.editarTableBindingSource.DataMember = "EditarTable";
            this.editarTableBindingSource.DataSource = this.consultaActivosDS;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AsignacionTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.RegistroActivosTableAdapter = null;
            this.tableAdapterManager1.TecnicosTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = GestionInventario.ConsultaActivosDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registroActivosTableAdapter
            // 
            this.registroActivosTableAdapter.ClearBeforeFill = true;
            // 
            // editarTableTableAdapter
            // 
            this.editarTableTableAdapter.ClearBeforeFill = true;
            // 
            // mantenimientoTableAdapter
            // 
            this.mantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.marcas1DS;
            // 
            // marcas1DS
            // 
            this.marcas1DS.DataSetName = "Marcas1DS";
            this.marcas1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroActivosBindingSource1
            // 
            this.registroActivosBindingSource1.DataMember = "RegistroActivos";
            this.registroActivosBindingSource1.DataSource = this.registroActivosDS;
            // 
            // registroActivosDS
            // 
            this.registroActivosDS.DataSetName = "RegistroActivosDS";
            this.registroActivosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // registroActivosTableAdapter1
            // 
            this.registroActivosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.RegistroActivosTableAdapter = this.registroActivosTableAdapter1;
            this.tableAdapterManager3.UpdateOrder = GestionInventario.RegistroActivosDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mantenimientoBindingSource1
            // 
            this.mantenimientoBindingSource1.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource1.DataSource = this.mantenimientoDS;
            // 
            // mantenimientoDS
            // 
            this.mantenimientoDS.DataSetName = "MantenimientoDS";
            this.mantenimientoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoTableAdapter1
            // 
            this.mantenimientoTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.MantenimientoTableAdapter = this.mantenimientoTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = GestionInventario.MantenimientoDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mantenimiento1DS
            // 
            this.mantenimiento1DS.DataSetName = "Mantenimiento1DS";
            this.mantenimiento1DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoBindingSource2
            // 
            this.mantenimientoBindingSource2.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource2.DataSource = this.mantenimiento1DS;
            // 
            // mantenimientoTableAdapter2
            // 
            this.mantenimientoTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.Connection = null;
            this.tableAdapterManager4.Mantenimiento1TableAdapter = null;
            this.tableAdapterManager4.UpdateOrder = GestionInventario.Mantenimiento1DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // asignacionDS
            // 
            this.asignacionDS.DataSetName = "AsignacionDS";
            this.asignacionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignacionBindingSource
            // 
            this.asignacionBindingSource.DataMember = "Asignacion";
            this.asignacionBindingSource.DataSource = this.asignacionDS;
            // 
            // asignacionTableAdapter
            // 
            this.asignacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager5
            // 
            this.tableAdapterManager5.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager5.Connection = null;
            this.tableAdapterManager5.UpdateOrder = GestionInventario.AsignacionDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tabla:";
            // 
            // cmbTabla
            // 
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Registro",
            "Mantenimiento",
            "Asignacion"});
            this.cmbTabla.Location = new System.Drawing.Point(241, 127);
            this.cmbTabla.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(224, 24);
            this.cmbTabla.TabIndex = 36;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // bindingNavigatorRegistro
            // 
            this.bindingNavigatorRegistro.AddNewItem = null;
            this.bindingNavigatorRegistro.BindingSource = this.registroActivosBindingSource1;
            this.bindingNavigatorRegistro.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorRegistro.DeleteItem = this.bindingNavigatorDeleteItemRegistro;
            this.bindingNavigatorRegistro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItemRegistro,
            this.guardarToolStripButtonRegistro,
            this.toolStripSeparator,
            this.copiarToolStripButton,
            this.toolStripSeparator1});
            this.bindingNavigatorRegistro.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorRegistro.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorRegistro.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorRegistro.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorRegistro.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorRegistro.Name = "bindingNavigatorRegistro";
            this.bindingNavigatorRegistro.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorRegistro.Size = new System.Drawing.Size(1268, 27);
            this.bindingNavigatorRegistro.TabIndex = 37;
            this.bindingNavigatorRegistro.Text = "bindingNavigator1";
            this.bindingNavigatorRegistro.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItemRegistro
            // 
            this.bindingNavigatorDeleteItemRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemRegistro.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemRegistro.Image")));
            this.bindingNavigatorDeleteItemRegistro.Name = "bindingNavigatorDeleteItemRegistro";
            this.bindingNavigatorDeleteItemRegistro.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemRegistro.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItemRegistro.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // guardarToolStripButtonRegistro
            // 
            this.guardarToolStripButtonRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButtonRegistro.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButtonRegistro.Image")));
            this.guardarToolStripButtonRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButtonRegistro.Name = "guardarToolStripButtonRegistro";
            this.guardarToolStripButtonRegistro.Size = new System.Drawing.Size(29, 24);
            this.guardarToolStripButtonRegistro.Text = "&Guardar";
            this.guardarToolStripButtonRegistro.Click += new System.EventHandler(this.guardarToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copiarToolStripButton.Text = "&Copiar";
            this.copiarToolStripButton.Click += new System.EventHandler(this.copiarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMtto
            // 
            this.bindingNavigatorMtto.AddNewItem = null;
            this.bindingNavigatorMtto.BindingSource = this.mantenimientoBindingSource2;
            this.bindingNavigatorMtto.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigatorMtto.DeleteItem = null;
            this.bindingNavigatorMtto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorMtto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.copiarToolStripButton1,
            this.toolStripSeparator3});
            this.bindingNavigatorMtto.Location = new System.Drawing.Point(0, 27);
            this.bindingNavigatorMtto.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigatorMtto.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigatorMtto.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigatorMtto.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigatorMtto.Name = "bindingNavigatorMtto";
            this.bindingNavigatorMtto.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigatorMtto.Size = new System.Drawing.Size(1268, 27);
            this.bindingNavigatorMtto.TabIndex = 38;
            this.bindingNavigatorMtto.Text = "bindingNavigator2";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // copiarToolStripButton1
            // 
            this.copiarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton1.Image")));
            this.copiarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton1.Name = "copiarToolStripButton1";
            this.copiarToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.copiarToolStripButton1.Text = "&Copiar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAsignacion
            // 
            this.bindingNavigatorAsignacion.AddNewItem = null;
            this.bindingNavigatorAsignacion.BindingSource = this.asignacionBindingSource;
            this.bindingNavigatorAsignacion.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigatorAsignacion.DeleteItem = null;
            this.bindingNavigatorAsignacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAsignacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.copiarToolStripButton2,
            this.toolStripSeparator5});
            this.bindingNavigatorAsignacion.Location = new System.Drawing.Point(0, 54);
            this.bindingNavigatorAsignacion.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigatorAsignacion.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigatorAsignacion.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigatorAsignacion.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigatorAsignacion.Name = "bindingNavigatorAsignacion";
            this.bindingNavigatorAsignacion.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigatorAsignacion.Size = new System.Drawing.Size(1268, 27);
            this.bindingNavigatorAsignacion.TabIndex = 39;
            this.bindingNavigatorAsignacion.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem2.Text = "de {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem2.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem2.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem2.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem2.Text = "Mover último";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // copiarToolStripButton2
            // 
            this.copiarToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton2.Image")));
            this.copiarToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton2.Name = "copiarToolStripButton2";
            this.copiarToolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.copiarToolStripButton2.Text = "&Copiar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(48, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Modo:";
            // 
            // cmbModo
            // 
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Items.AddRange(new object[] {
            "Vista",
            "Edicion"});
            this.cmbModo.Location = new System.Drawing.Point(241, 178);
            this.cmbModo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(224, 24);
            this.cmbModo.TabIndex = 41;
            this.cmbModo.SelectedIndexChanged += new System.EventHandler(this.cmbModo_SelectedIndexChanged);
            // 
            // mantenimiento1BindingSource
            // 
            this.mantenimiento1BindingSource.DataMember = "Mantenimiento1";
            this.mantenimiento1BindingSource.DataSource = this.mantenimiento1DS;
            // 
            // mantenimiento1TableAdapter
            // 
            this.mantenimiento1TableAdapter.ClearBeforeFill = true;
            // 
            // mttoeditDS
            // 
            this.mttoeditDS.DataSetName = "mttoeditDS";
            this.mttoeditDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mantenimientoBindingSource3
            // 
            this.mantenimientoBindingSource3.DataMember = "Mantenimiento";
            this.mantenimientoBindingSource3.DataSource = this.mttoeditDS;
            // 
            // mantenimientoTableAdapter3
            // 
            this.mantenimientoTableAdapter3.ClearBeforeFill = true;
            // 
            // tableAdapterManager6
            // 
            this.tableAdapterManager6.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager6.MantenimientoTableAdapter = this.mantenimientoTableAdapter3;
            this.tableAdapterManager6.UpdateOrder = GestionInventario.mttoeditDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatormttoedit
            // 
            this.bindingNavigatormttoedit.AddNewItem = null;
            this.bindingNavigatormttoedit.BindingSource = this.mantenimientoBindingSource3;
            this.bindingNavigatormttoedit.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigatormttoedit.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigatormttoedit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatormttoedit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorDeleteItem3,
            this.guardarToolStripButton3,
            this.toolStripSeparator6,
            this.copiarToolStripButton3});
            this.bindingNavigatormttoedit.Location = new System.Drawing.Point(0, 81);
            this.bindingNavigatormttoedit.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigatormttoedit.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigatormttoedit.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigatormttoedit.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigatormttoedit.Name = "bindingNavigatormttoedit";
            this.bindingNavigatormttoedit.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigatormttoedit.Size = new System.Drawing.Size(1268, 27);
            this.bindingNavigatormttoedit.TabIndex = 42;
            this.bindingNavigatormttoedit.Text = "bindingNavigator1";
            this.bindingNavigatormttoedit.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems_1);
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem3.Text = "de {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem3.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem3.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem3.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem3.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem3.Text = "Mover último";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 27);
            // 
            // guardarToolStripButton3
            // 
            this.guardarToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton3.Image")));
            this.guardarToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton3.Name = "guardarToolStripButton3";
            this.guardarToolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.guardarToolStripButton3.Text = "&Guardar";
            this.guardarToolStripButton3.Click += new System.EventHandler(this.guardarToolStripButton3_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // copiarToolStripButton3
            // 
            this.copiarToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton3.Image")));
            this.copiarToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton3.Name = "copiarToolStripButton3";
            this.copiarToolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.copiarToolStripButton3.Text = "&Copiar";
            // 
            // asigEditDS
            // 
            this.asigEditDS.DataSetName = "AsigEditDS";
            this.asigEditDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asignacionBindingSource1
            // 
            this.asignacionBindingSource1.DataMember = "Asignacion";
            this.asignacionBindingSource1.DataSource = this.asigEditDS;
            // 
            // asignacionTableAdapter1
            // 
            this.asignacionTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager7
            // 
            this.tableAdapterManager7.AsignacionTableAdapter = this.asignacionTableAdapter1;
            this.tableAdapterManager7.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager7.UpdateOrder = GestionInventario.AsigEditDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorAsigEdit
            // 
            this.bindingNavigatorAsigEdit.AddNewItem = null;
            this.bindingNavigatorAsigEdit.BindingSource = this.asignacionBindingSource1;
            this.bindingNavigatorAsigEdit.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigatorAsigEdit.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigatorAsigEdit.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorAsigEdit.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorAsigEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorDeleteItem1,
            this.guardarToolStripButton1,
            this.toolStripSeparator2,
            this.copiarToolStripButton4});
            this.bindingNavigatorAsigEdit.Location = new System.Drawing.Point(0, 123);
            this.bindingNavigatorAsigEdit.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigatorAsigEdit.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigatorAsigEdit.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigatorAsigEdit.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigatorAsigEdit.Name = "bindingNavigatorAsigEdit";
            this.bindingNavigatorAsigEdit.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigatorAsigEdit.Size = new System.Drawing.Size(355, 27);
            this.bindingNavigatorAsigEdit.TabIndex = 43;
            this.bindingNavigatorAsigEdit.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem4.Text = "de {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem1.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem4.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem4.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem4.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem4.Text = "Mover último";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 27);
            // 
            // guardarToolStripButton1
            // 
            this.guardarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.guardarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripButton1.Image")));
            this.guardarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripButton1.Name = "guardarToolStripButton1";
            this.guardarToolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.guardarToolStripButton1.Text = "&Guardar";
            this.guardarToolStripButton1.Click += new System.EventHandler(this.guardarToolStripButton1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // copiarToolStripButton4
            // 
            this.copiarToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton4.Image")));
            this.copiarToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton4.Name = "copiarToolStripButton4";
            this.copiarToolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.copiarToolStripButton4.Text = "&Copiar";
            // 
            // registroActivosDataGridView
            // 
            this.registroActivosDataGridView.AutoGenerateColumns = false;
            this.registroActivosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registroActivosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.Usuario,
            this.Id});
            this.registroActivosDataGridView.DataSource = this.registroActivosBindingSource1;
            this.registroActivosDataGridView.Location = new System.Drawing.Point(53, 268);
            this.registroActivosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.registroActivosDataGridView.Name = "registroActivosDataGridView";
            this.registroActivosDataGridView.RowHeadersWidth = 51;
            this.registroActivosDataGridView.Size = new System.Drawing.Size(1029, 221);
            this.registroActivosDataGridView.TabIndex = 34;
            this.registroActivosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registroActivosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CodInterno";
            this.dataGridViewTextBoxColumn8.HeaderText = "CodInterno";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Serial";
            this.dataGridViewTextBoxColumn9.HeaderText = "Serial";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn10.DataSource = this.marcasBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "Marca";
            this.dataGridViewTextBoxColumn10.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "Id";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FechaCompra";
            this.dataGridViewTextBoxColumn11.HeaderText = "FechaCompra";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FechaRegistro";
            this.dataGridViewTextBoxColumn12.HeaderText = "FechaRegistro";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "EstadoRegistro";
            this.dataGridViewTextBoxColumn13.HeaderText = "EstadoRegistro";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // mantenimientoDataGridView
            // 
            this.mantenimientoDataGridView.AutoGenerateColumns = false;
            this.mantenimientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mantenimientoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodInterno,
            this.Serial,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn18});
            this.mantenimientoDataGridView.DataSource = this.mantenimientoBindingSource2;
            this.mantenimientoDataGridView.Location = new System.Drawing.Point(44, 345);
            this.mantenimientoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mantenimientoDataGridView.Name = "mantenimientoDataGridView";
            this.mantenimientoDataGridView.RowHeadersWidth = 51;
            this.mantenimientoDataGridView.Size = new System.Drawing.Size(1030, 206);
            this.mantenimientoDataGridView.TabIndex = 34;
            // 
            // CodInterno
            // 
            this.CodInterno.DataPropertyName = "CodInterno";
            this.CodInterno.HeaderText = "CodInterno";
            this.CodInterno.MinimumWidth = 6;
            this.CodInterno.Name = "CodInterno";
            this.CodInterno.ReadOnly = true;
            this.CodInterno.Width = 125;
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            this.Serial.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaIngresoMtto";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaIngresoMtto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoFalla";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoFalla";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ObsIngreso";
            this.dataGridViewTextBoxColumn5.HeaderText = "ObsIngreso";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaSalidaMtto";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaSalidaMtto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EstadoSalida";
            this.dataGridViewTextBoxColumn7.HeaderText = "EstadoSalida";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ObsSalida";
            this.dataGridViewTextBoxColumn16.HeaderText = "ObsSalida";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "checkMtto";
            this.dataGridViewCheckBoxColumn1.HeaderText = "checkMtto";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "NumIngreso";
            this.dataGridViewTextBoxColumn18.HeaderText = "NumIngreso";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // mantenimientoDataGridViewEdit
            // 
            this.mantenimientoDataGridViewEdit.AutoGenerateColumns = false;
            this.mantenimientoDataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mantenimientoDataGridViewEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn33});
            this.mantenimientoDataGridViewEdit.DataSource = this.mantenimientoBindingSource3;
            this.mantenimientoDataGridViewEdit.Location = new System.Drawing.Point(116, 472);
            this.mantenimientoDataGridViewEdit.Margin = new System.Windows.Forms.Padding(4);
            this.mantenimientoDataGridViewEdit.Name = "mantenimientoDataGridViewEdit";
            this.mantenimientoDataGridViewEdit.RowHeadersWidth = 51;
            this.mantenimientoDataGridViewEdit.Size = new System.Drawing.Size(967, 105);
            this.mantenimientoDataGridViewEdit.TabIndex = 41;
            this.mantenimientoDataGridViewEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mantenimientoDataGridViewEdit_CellContentClick);
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn25.HeaderText = "Id";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "InventarioId";
            this.dataGridViewTextBoxColumn26.HeaderText = "InventarioId";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "FechaIngresoMtto";
            this.dataGridViewTextBoxColumn27.HeaderText = "FechaIngresoMtto";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "TipoFalla";
            this.dataGridViewTextBoxColumn28.HeaderText = "TipoFalla";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "ObsIngreso";
            this.dataGridViewTextBoxColumn29.HeaderText = "ObsIngreso";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 125;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "FechaSalidaMtto";
            this.dataGridViewTextBoxColumn30.HeaderText = "FechaSalidaMtto";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 125;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "EstadoSalida";
            this.dataGridViewTextBoxColumn31.HeaderText = "EstadoSalida";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 125;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "ObsSalida";
            this.dataGridViewTextBoxColumn32.HeaderText = "ObsSalida";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "checkMtto";
            this.dataGridViewCheckBoxColumn2.HeaderText = "checkMtto";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "NumIngreso";
            this.dataGridViewTextBoxColumn33.HeaderText = "NumIngreso";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 125;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "FechaAsignacion";
            this.dataGridViewTextBoxColumn38.HeaderText = "FechaAsignacion";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 125;
            // 
            // asignacionDataGridViewEdit
            // 
            this.asignacionDataGridViewEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.asignacionDataGridViewEdit.AutoGenerateColumns = false;
            this.asignacionDataGridViewEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignacionDataGridViewEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn38});
            this.asignacionDataGridViewEdit.DataSource = this.asignacionBindingSource1;
            this.asignacionDataGridViewEdit.Location = new System.Drawing.Point(139, 559);
            this.asignacionDataGridViewEdit.Margin = new System.Windows.Forms.Padding(4);
            this.asignacionDataGridViewEdit.Name = "asignacionDataGridViewEdit";
            this.asignacionDataGridViewEdit.RowHeadersWidth = 51;
            this.asignacionDataGridViewEdit.Size = new System.Drawing.Size(943, 37);
            this.asignacionDataGridViewEdit.TabIndex = 42;
            this.asignacionDataGridViewEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asignacionDataGridViewEdit_CellContentClick);
            // 
            // asignacionDataGridView
            // 
            this.asignacionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.asignacionDataGridView.AutoGenerateColumns = false;
            this.asignacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asignacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.UsuarioRed,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn23,
            this.CondicionEntrega,
            this.FechaDevolucion,
            this.EstadoDevolucion});
            this.asignacionDataGridView.DataSource = this.asignacionBindingSource;
            this.asignacionDataGridView.Location = new System.Drawing.Point(95, 400);
            this.asignacionDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.asignacionDataGridView.Name = "asignacionDataGridView";
            this.asignacionDataGridView.RowHeadersWidth = 51;
            this.asignacionDataGridView.Size = new System.Drawing.Size(988, 196);
            this.asignacionDataGridView.TabIndex = 34;
            this.asignacionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asignacionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "CodInterno";
            this.dataGridViewTextBoxColumn17.HeaderText = "CodInterno";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // UsuarioRed
            // 
            this.UsuarioRed.DataPropertyName = "UsuarioRed";
            this.UsuarioRed.HeaderText = "UsuarioRed";
            this.UsuarioRed.MinimumWidth = 6;
            this.UsuarioRed.Name = "UsuarioRed";
            this.UsuarioRed.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Serial";
            this.dataGridViewTextBoxColumn21.HeaderText = "Serial";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "FechaAsignacion";
            this.dataGridViewTextBoxColumn23.HeaderText = "FechaAsignacion";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // CondicionEntrega
            // 
            this.CondicionEntrega.DataPropertyName = "CondicionEntrega";
            this.CondicionEntrega.HeaderText = "CondicionEntrega";
            this.CondicionEntrega.MinimumWidth = 6;
            this.CondicionEntrega.Name = "CondicionEntrega";
            this.CondicionEntrega.Width = 125;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.DataPropertyName = "FechaDevolucion";
            this.FechaDevolucion.HeaderText = "FechaDevolucion";
            this.FechaDevolucion.MinimumWidth = 6;
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Width = 125;
            // 
            // EstadoDevolucion
            // 
            this.EstadoDevolucion.DataPropertyName = "EstadoDevolucion";
            this.EstadoDevolucion.HeaderText = "EstadoDevolucion";
            this.EstadoDevolucion.MinimumWidth = 6;
            this.EstadoDevolucion.Name = "EstadoDevolucion";
            this.EstadoDevolucion.Width = 125;
            // 
            // txtUsuariobb
            // 
            this.txtUsuariobb.Location = new System.Drawing.Point(745, 178);
            this.txtUsuariobb.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuariobb.Name = "txtUsuariobb";
            this.txtUsuariobb.Size = new System.Drawing.Size(261, 22);
            this.txtUsuariobb.TabIndex = 45;
            this.txtUsuariobb.TextChanged += new System.EventHandler(this.txtUsuariobb_TextChanged);
            // 
            // UsuarioTxt
            // 
            this.UsuarioTxt.AutoSize = true;
            this.UsuarioTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.UsuarioTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UsuarioTxt.Location = new System.Drawing.Point(559, 175);
            this.UsuarioTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuarioTxt.Name = "UsuarioTxt";
            this.UsuarioTxt.Size = new System.Drawing.Size(86, 28);
            this.UsuarioTxt.TabIndex = 44;
            this.UsuarioTxt.Text = "Usuario:";
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 721);
            this.Controls.Add(this.txtUsuariobb);
            this.Controls.Add(this.UsuarioTxt);
            this.Controls.Add(this.bindingNavigatorAsigEdit);
            this.Controls.Add(this.asignacionDataGridViewEdit);
            this.Controls.Add(this.bindingNavigatormttoedit);
            this.Controls.Add(this.mantenimientoDataGridViewEdit);
            this.Controls.Add(this.cmbModo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bindingNavigatorAsignacion);
            this.Controls.Add(this.bindingNavigatorMtto);
            this.Controls.Add(this.bindingNavigatorRegistro);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.asignacionDataGridView);
            this.Controls.Add(this.mantenimientoDataGridView);
            this.Controls.Add(this.registroActivosDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumeroConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.FormConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosViewDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaActivosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editarTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcas1DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimiento1DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorRegistro)).EndInit();
            this.bindingNavigatorRegistro.ResumeLayout(false);
            this.bindingNavigatorRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorMtto)).EndInit();
            this.bindingNavigatorMtto.ResumeLayout(false);
            this.bindingNavigatorMtto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAsignacion)).EndInit();
            this.bindingNavigatorAsignacion.ResumeLayout(false);
            this.bindingNavigatorAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimiento1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mttoeditDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatormttoedit)).EndInit();
            this.bindingNavigatormttoedit.ResumeLayout(false);
            this.bindingNavigatormttoedit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asigEditDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorAsigEdit)).EndInit();
            this.bindingNavigatorAsigEdit.ResumeLayout(false);
            this.bindingNavigatorAsigEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoDataGridViewEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataGridViewEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignacionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRegistro;
        private ActivosViewDS activosViewDS;
        private BindingSource activosViewBindingSource;
        private ActivosViewDSTableAdapters.ActivosViewTableAdapter activosViewTableAdapter;
        private ActivosViewDSTableAdapters.TableAdapterManager tableAdapterManager;
        private Label label1;
        private TextBox txtNumeroConsulta;
        private Button button1;
        private ConsultaActivosDS consultaActivosDS;
        private BindingSource editarTableBindingSource;
        private ConsultaActivosDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource registroActivosBindingSource;
        private ConsultaActivosDSTableAdapters.RegistroActivosTableAdapter registroActivosTableAdapter;
        private ConsultaActivosDSTableAdapters.EditarTableTableAdapter editarTableTableAdapter;
        private BindingSource mantenimientoBindingSource;
        private ConsultaActivosDSTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter;
        private MantenimientoDS mantenimientoDS;
        private BindingSource mantenimientoBindingSource1;
        private MantenimientoDSTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter1;
        private MantenimientoDSTableAdapters.TableAdapterManager tableAdapterManager2;
        private RegistroActivosDS registroActivosDS;
        private BindingSource registroActivosBindingSource1;
        private RegistroActivosDSTableAdapters.RegistroActivosTableAdapter registroActivosTableAdapter1;
        private RegistroActivosDSTableAdapters.TableAdapterManager tableAdapterManager3;
        private Marcas1DS marcas1DS;
        private BindingSource marcasBindingSource;
        private Marcas1DSTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private Mantenimiento1DS mantenimiento1DS;
        private BindingSource mantenimientoBindingSource2;
        private Mantenimiento1DSTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter2;
        private Mantenimiento1DSTableAdapters.TableAdapterManager tableAdapterManager4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private AsignacionDS asignacionDS;
        private BindingSource asignacionBindingSource;
        private AsignacionDSTableAdapters.AsignacionTableAdapter asignacionTableAdapter;
        private AsignacionDSTableAdapters.TableAdapterManager tableAdapterManager5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private Label label2;
        private ComboBox cmbTabla;
        private BindingNavigator bindingNavigatorRegistro;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItemRegistro;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton guardarToolStripButtonRegistro;
        private ToolStripSeparator toolStripSeparator;
        private BindingNavigator bindingNavigatorMtto;
        private ToolStripLabel bindingNavigatorCountItem1;
        private ToolStripButton bindingNavigatorMoveFirstItem1;
        private ToolStripButton bindingNavigatorMovePreviousItem1;
        private ToolStripSeparator bindingNavigatorSeparator3;
        private ToolStripTextBox bindingNavigatorPositionItem1;
        private ToolStripSeparator bindingNavigatorSeparator4;
        private ToolStripButton bindingNavigatorMoveNextItem1;
        private ToolStripButton bindingNavigatorMoveLastItem1;
        private ToolStripSeparator bindingNavigatorSeparator5;
        private BindingNavigator bindingNavigatorAsignacion;
        private ToolStripLabel bindingNavigatorCountItem2;
        private ToolStripButton bindingNavigatorMoveFirstItem2;
        private ToolStripButton bindingNavigatorMovePreviousItem2;
        private ToolStripSeparator bindingNavigatorSeparator6;
        private ToolStripTextBox bindingNavigatorPositionItem2;
        private ToolStripSeparator bindingNavigatorSeparator7;
        private ToolStripButton bindingNavigatorMoveNextItem2;
        private ToolStripButton bindingNavigatorMoveLastItem2;
        private ToolStripSeparator bindingNavigatorSeparator8;
        private ToolStripSeparator toolStripSeparator5;
        private Label label3;
        private ComboBox cmbModo;
        private BindingSource mantenimiento1BindingSource;
        private Mantenimiento1DSTableAdapters.Mantenimiento1TableAdapter mantenimiento1TableAdapter;
        private ToolStripButton copiarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton copiarToolStripButton1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton copiarToolStripButton2;
        private mttoeditDS mttoeditDS;
        private BindingSource mantenimientoBindingSource3;
        private mttoeditDSTableAdapters.MantenimientoTableAdapter mantenimientoTableAdapter3;
        private mttoeditDSTableAdapters.TableAdapterManager tableAdapterManager6;
        private BindingNavigator bindingNavigatormttoedit;
        private ToolStripLabel bindingNavigatorCountItem3;
        private ToolStripButton bindingNavigatorDeleteItem3;
        private ToolStripButton bindingNavigatorMoveFirstItem3;
        private ToolStripButton bindingNavigatorMovePreviousItem3;
        private ToolStripSeparator bindingNavigatorSeparator9;
        private ToolStripTextBox bindingNavigatorPositionItem3;
        private ToolStripSeparator bindingNavigatorSeparator10;
        private ToolStripButton bindingNavigatorMoveNextItem3;
        private ToolStripButton bindingNavigatorMoveLastItem3;
        private ToolStripSeparator bindingNavigatorSeparator11;
        private ToolStripButton guardarToolStripButton3;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton copiarToolStripButton3;
        private AsigEditDS asigEditDS;
        private BindingSource asignacionBindingSource1;
        private AsigEditDSTableAdapters.AsignacionTableAdapter asignacionTableAdapter1;
        private AsigEditDSTableAdapters.TableAdapterManager tableAdapterManager7;
        private BindingNavigator bindingNavigatorAsigEdit;
        private ToolStripLabel bindingNavigatorCountItem4;
        private ToolStripButton bindingNavigatorDeleteItem1;
        private ToolStripButton bindingNavigatorMoveFirstItem4;
        private ToolStripButton bindingNavigatorMovePreviousItem4;
        private ToolStripSeparator bindingNavigatorSeparator12;
        private ToolStripTextBox bindingNavigatorPositionItem4;
        private ToolStripSeparator bindingNavigatorSeparator13;
        private ToolStripButton bindingNavigatorMoveNextItem4;
        private ToolStripButton bindingNavigatorMoveLastItem4;
        private ToolStripSeparator bindingNavigatorSeparator14;
        private ToolStripButton guardarToolStripButton1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton copiarToolStripButton4;
        private DataGridView registroActivosDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Id;
        private DataGridView mantenimientoDataGridView;
        private DataGridView mantenimientoDataGridViewEdit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridView asignacionDataGridViewEdit;
        private DataGridView asignacionDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn UsuarioRed;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn CondicionEntrega;
        private DataGridViewTextBoxColumn FechaDevolucion;
        private DataGridViewTextBoxColumn EstadoDevolucion;
        private TextBox txtUsuariobb;
        private Label UsuarioTxt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn CodInterno;
        private DataGridViewTextBoxColumn Serial;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}