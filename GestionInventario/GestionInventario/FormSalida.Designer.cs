namespace GestionInventario
{
    partial class FormSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            this.lblAsignacion = new System.Windows.Forms.Label();
            this.txtNumAsig = new System.Windows.Forms.TextBox();
            this.lblNumeroAsig = new System.Windows.Forms.Label();
            this.dtpFechaAsig = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAsig = new System.Windows.Forms.Label();
            this.cmbSedeAsig = new System.Windows.Forms.ComboBox();
            this.sedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedesDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sedesDS = new GestionInventario.SedesDS();
            this.lblSede = new System.Windows.Forms.Label();
            this.btnAsign = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.cmbConceptoAsig = new System.Windows.Forms.ComboBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.dtpFechaDev = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.sedesTableAdapter = new GestionInventario.SedesDSTableAdapters.SedesTableAdapter();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtUsuarioAsig = new System.Windows.Forms.TextBox();
            this.lblusuarioAsig = new System.Windows.Forms.Label();
            this.cmbCondicionEntrega = new System.Windows.Forms.ComboBox();
            this.lblCondicionEntrega = new System.Windows.Forms.Label();
            this.lblEstadoDevolucion = new System.Windows.Forms.Label();
            this.cmbEstadoDevolucion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedesDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedesDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAsignacion
            // 
            this.lblAsignacion.AutoSize = true;
            this.lblAsignacion.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacion.Location = new System.Drawing.Point(163, 34);
            this.lblAsignacion.Name = "lblAsignacion";
            this.lblAsignacion.Size = new System.Drawing.Size(129, 25);
            this.lblAsignacion.TabIndex = 5;
            this.lblAsignacion.Text = "ASIGNACIÓN";
            this.lblAsignacion.Click += new System.EventHandler(this.lblAsignacion_Click);
            // 
            // txtNumAsig
            // 
            this.txtNumAsig.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumAsig.Location = new System.Drawing.Point(198, 124);
            this.txtNumAsig.Name = "txtNumAsig";
            this.txtNumAsig.Size = new System.Drawing.Size(195, 29);
            this.txtNumAsig.TabIndex = 8;
            // 
            // lblNumeroAsig
            // 
            this.lblNumeroAsig.AutoSize = true;
            this.lblNumeroAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroAsig.Location = new System.Drawing.Point(50, 132);
            this.lblNumeroAsig.Name = "lblNumeroAsig";
            this.lblNumeroAsig.Size = new System.Drawing.Size(74, 21);
            this.lblNumeroAsig.TabIndex = 7;
            this.lblNumeroAsig.Text = "Número:";
            // 
            // dtpFechaAsig
            // 
            this.dtpFechaAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAsig.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAsig.Location = new System.Drawing.Point(196, 175);
            this.dtpFechaAsig.Name = "dtpFechaAsig";
            this.dtpFechaAsig.Size = new System.Drawing.Size(195, 25);
            this.dtpFechaAsig.TabIndex = 18;
            // 
            // lblFechaAsig
            // 
            this.lblFechaAsig.AutoSize = true;
            this.lblFechaAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAsig.Location = new System.Drawing.Point(50, 175);
            this.lblFechaAsig.Name = "lblFechaAsig";
            this.lblFechaAsig.Size = new System.Drawing.Size(140, 21);
            this.lblFechaAsig.TabIndex = 17;
            this.lblFechaAsig.Text = "Fecha Asignación:";
            // 
            // cmbSedeAsig
            // 
            this.cmbSedeAsig.DataSource = this.sedesBindingSource;
            this.cmbSedeAsig.DisplayMember = "NombreSede";
            this.cmbSedeAsig.FormattingEnabled = true;
            this.cmbSedeAsig.Location = new System.Drawing.Point(196, 220);
            this.cmbSedeAsig.Name = "cmbSedeAsig";
            this.cmbSedeAsig.Size = new System.Drawing.Size(195, 21);
            this.cmbSedeAsig.TabIndex = 20;
            this.cmbSedeAsig.ValueMember = "Id";
            // 
            // sedesBindingSource
            // 
            this.sedesBindingSource.DataMember = "Sedes";
            this.sedesBindingSource.DataSource = this.sedesDSBindingSource;
            // 
            // sedesDSBindingSource
            // 
            this.sedesDSBindingSource.DataSource = this.sedesDS;
            this.sedesDSBindingSource.Position = 0;
            // 
            // sedesDS
            // 
            this.sedesDS.DataSetName = "SedesDS";
            this.sedesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(50, 217);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(51, 21);
            this.lblSede.TabIndex = 19;
            this.lblSede.Text = "Sede:";
            // 
            // btnAsign
            // 
            this.btnAsign.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAsign.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsign.Location = new System.Drawing.Point(199, 379);
            this.btnAsign.Name = "btnAsign";
            this.btnAsign.Size = new System.Drawing.Size(98, 32);
            this.btnAsign.TabIndex = 23;
            this.btnAsign.Text = "ASIGNAR";
            this.btnAsign.UseVisualStyleBackColor = false;
            this.btnAsign.Click += new System.EventHandler(this.btnIngresoMtto_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Tan;
            this.btnDevolver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(214, 379);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(98, 32);
            this.btnDevolver.TabIndex = 24;
            this.btnDevolver.Text = "DEVOLVER";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // cmbConceptoAsig
            // 
            this.cmbConceptoAsig.FormattingEnabled = true;
            this.cmbConceptoAsig.Items.AddRange(new object[] {
            "Asignacion",
            "Devolucion"});
            this.cmbConceptoAsig.Location = new System.Drawing.Point(199, 88);
            this.cmbConceptoAsig.Name = "cmbConceptoAsig";
            this.cmbConceptoAsig.Size = new System.Drawing.Size(195, 21);
            this.cmbConceptoAsig.TabIndex = 26;
            this.cmbConceptoAsig.SelectedIndexChanged += new System.EventHandler(this.cmbConceptoAsig_SelectedIndexChanged);
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.Location = new System.Drawing.Point(52, 88);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(86, 21);
            this.lblConcepto.TabIndex = 25;
            this.lblConcepto.Text = "Concepto:";
            // 
            // dtpFechaDev
            // 
            this.dtpFechaDev.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDev.Location = new System.Drawing.Point(196, 175);
            this.dtpFechaDev.Name = "dtpFechaDev";
            this.dtpFechaDev.Size = new System.Drawing.Size(195, 25);
            this.dtpFechaDev.TabIndex = 28;
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDev.Location = new System.Drawing.Point(50, 175);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(142, 21);
            this.lblFechaDev.TabIndex = 27;
            this.lblFechaDev.Text = "Fecha Devolución:";
            // 
            // sedesTableAdapter
            // 
            this.sedesTableAdapter.ClearBeforeFill = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(196, 297);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(195, 20);
            this.txtObservacion.TabIndex = 33;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacion.Location = new System.Drawing.Point(50, 294);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(106, 21);
            this.lblObservacion.TabIndex = 32;
            this.lblObservacion.Text = "Observación:";
            // 
            // txtUsuarioAsig
            // 
            this.txtUsuarioAsig.Location = new System.Drawing.Point(198, 340);
            this.txtUsuarioAsig.Name = "txtUsuarioAsig";
            this.txtUsuarioAsig.Size = new System.Drawing.Size(195, 20);
            this.txtUsuarioAsig.TabIndex = 35;
            // 
            // lblusuarioAsig
            // 
            this.lblusuarioAsig.AutoSize = true;
            this.lblusuarioAsig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuarioAsig.Location = new System.Drawing.Point(52, 337);
            this.lblusuarioAsig.Name = "lblusuarioAsig";
            this.lblusuarioAsig.Size = new System.Drawing.Size(121, 21);
            this.lblusuarioAsig.TabIndex = 34;
            this.lblusuarioAsig.Text = "Usuario de red:";
            // 
            // cmbCondicionEntrega
            // 
            this.cmbCondicionEntrega.DisplayMember = "Id";
            this.cmbCondicionEntrega.FormattingEnabled = true;
            this.cmbCondicionEntrega.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.cmbCondicionEntrega.Location = new System.Drawing.Point(199, 256);
            this.cmbCondicionEntrega.Name = "cmbCondicionEntrega";
            this.cmbCondicionEntrega.Size = new System.Drawing.Size(192, 21);
            this.cmbCondicionEntrega.TabIndex = 36;
            this.cmbCondicionEntrega.ValueMember = "Id";
            // 
            // lblCondicionEntrega
            // 
            this.lblCondicionEntrega.AutoSize = true;
            this.lblCondicionEntrega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondicionEntrega.Location = new System.Drawing.Point(52, 256);
            this.lblCondicionEntrega.Name = "lblCondicionEntrega";
            this.lblCondicionEntrega.Size = new System.Drawing.Size(148, 21);
            this.lblCondicionEntrega.TabIndex = 37;
            this.lblCondicionEntrega.Text = "Condición Entrega:";
            // 
            // lblEstadoDevolucion
            // 
            this.lblEstadoDevolucion.AutoSize = true;
            this.lblEstadoDevolucion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoDevolucion.Location = new System.Drawing.Point(50, 256);
            this.lblEstadoDevolucion.Name = "lblEstadoDevolucion";
            this.lblEstadoDevolucion.Size = new System.Drawing.Size(149, 21);
            this.lblEstadoDevolucion.TabIndex = 38;
            this.lblEstadoDevolucion.Text = "Estado Devolución:";
            // 
            // cmbEstadoDevolucion
            // 
            this.cmbEstadoDevolucion.DisplayMember = "Id";
            this.cmbEstadoDevolucion.FormattingEnabled = true;
            this.cmbEstadoDevolucion.Items.AddRange(new object[] {
            "Bueno",
            "Con Falla"});
            this.cmbEstadoDevolucion.Location = new System.Drawing.Point(201, 256);
            this.cmbEstadoDevolucion.Name = "cmbEstadoDevolucion";
            this.cmbEstadoDevolucion.Size = new System.Drawing.Size(192, 21);
            this.cmbEstadoDevolucion.TabIndex = 39;
            this.cmbEstadoDevolucion.ValueMember = "Id";
            // 
            // FormSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 479);
            this.Controls.Add(this.cmbEstadoDevolucion);
            this.Controls.Add(this.lblEstadoDevolucion);
            this.Controls.Add(this.lblCondicionEntrega);
            this.Controls.Add(this.cmbCondicionEntrega);
            this.Controls.Add(this.txtUsuarioAsig);
            this.Controls.Add(this.lblusuarioAsig);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.dtpFechaDev);
            this.Controls.Add(this.lblFechaDev);
            this.Controls.Add(this.cmbConceptoAsig);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnAsign);
            this.Controls.Add(this.cmbSedeAsig);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.dtpFechaAsig);
            this.Controls.Add(this.lblFechaAsig);
            this.Controls.Add(this.txtNumAsig);
            this.Controls.Add(this.lblNumeroAsig);
            this.Controls.Add(this.lblAsignacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSalida";
            this.Text = "Asignación y Devolución";
            this.Load += new System.EventHandler(this.FormSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedesDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedesDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAsignacion;
        private System.Windows.Forms.TextBox txtNumAsig;
        private System.Windows.Forms.Label lblNumeroAsig;
        private System.Windows.Forms.DateTimePicker dtpFechaAsig;
        private System.Windows.Forms.Label lblFechaAsig;
        private System.Windows.Forms.ComboBox cmbSedeAsig;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Button btnAsign;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.ComboBox cmbConceptoAsig;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.DateTimePicker dtpFechaDev;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.BindingSource sedesDSBindingSource;
        private SedesDS sedesDS;
        private System.Windows.Forms.BindingSource sedesBindingSource;
        private SedesDSTableAdapters.SedesTableAdapter sedesTableAdapter;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.TextBox txtUsuarioAsig;
        private System.Windows.Forms.Label lblusuarioAsig;
        private System.Windows.Forms.ComboBox cmbCondicionEntrega;
        private System.Windows.Forms.Label lblCondicionEntrega;
        private System.Windows.Forms.Label lblEstadoDevolucion;
        private System.Windows.Forms.ComboBox cmbEstadoDevolucion;
    }
}