namespace GestionInventario
{
    partial class FormEnvio
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
            this.btnEnvio = new System.Windows.Forms.Button();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblCodEnvio = new System.Windows.Forms.Label();
            this.cmbSedeEnvio = new System.Windows.Forms.ComboBox();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.txtCodEnvio = new System.Windows.Forms.TextBox();
            this.lblEstadoEnvio = new System.Windows.Forms.Label();
            this.lblSedeEnvio = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblTipooperacion = new System.Windows.Forms.Label();
            this.cmbTipooperacion = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConfirmarrecepcion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnvio
            // 
            this.btnEnvio.BackColor = System.Drawing.Color.LightBlue;
            this.btnEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvio.Location = new System.Drawing.Point(169, 296);
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.Size = new System.Drawing.Size(139, 32);
            this.btnEnvio.TabIndex = 48;
            this.btnEnvio.Text = "Confirmar Envío";
            this.btnEnvio.UseVisualStyleBackColor = false;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvio.Location = new System.Drawing.Point(201, 26);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(69, 25);
            this.lblEnvio.TabIndex = 34;
            this.lblEnvio.Text = "ENVÍO";
            // 
            // lblCodEnvio
            // 
            this.lblCodEnvio.AutoSize = true;
            this.lblCodEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEnvio.Location = new System.Drawing.Point(57, 111);
            this.lblCodEnvio.Name = "lblCodEnvio";
            this.lblCodEnvio.Size = new System.Drawing.Size(68, 21);
            this.lblCodEnvio.TabIndex = 35;
            this.lblCodEnvio.Text = "Código:";
            this.lblCodEnvio.Click += new System.EventHandler(this.lblNumeroMtto_Click);
            // 
            // cmbSedeEnvio
            // 
            this.cmbSedeEnvio.DisplayMember = "NombreSede";
            this.cmbSedeEnvio.FormattingEnabled = true;
            this.cmbSedeEnvio.Location = new System.Drawing.Point(189, 201);
            this.cmbSedeEnvio.Name = "cmbSedeEnvio";
            this.cmbSedeEnvio.Size = new System.Drawing.Size(195, 21);
            this.cmbSedeEnvio.TabIndex = 51;
            this.cmbSedeEnvio.ValueMember = "Id";
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.AutoSize = true;
            this.lblFechaEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEnvio.Location = new System.Drawing.Point(58, 238);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(56, 21);
            this.lblFechaEnvio.TabIndex = 37;
            this.lblFechaEnvio.Text = "Fecha:";
            this.lblFechaEnvio.Click += new System.EventHandler(this.lblFechaMtto_Click);
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEnvio.Location = new System.Drawing.Point(189, 238);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(195, 25);
            this.dtpFechaEnvio.TabIndex = 38;
            this.dtpFechaEnvio.ValueChanged += new System.EventHandler(this.dtpFechaMtto_ValueChanged);
            // 
            // txtCodEnvio
            // 
            this.txtCodEnvio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCodEnvio.Location = new System.Drawing.Point(189, 108);
            this.txtCodEnvio.Name = "txtCodEnvio";
            this.txtCodEnvio.Size = new System.Drawing.Size(119, 29);
            this.txtCodEnvio.TabIndex = 36;
            // 
            // lblEstadoEnvio
            // 
            this.lblEstadoEnvio.AutoSize = true;
            this.lblEstadoEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoEnvio.Location = new System.Drawing.Point(58, 156);
            this.lblEstadoEnvio.Name = "lblEstadoEnvio";
            this.lblEstadoEnvio.Size = new System.Drawing.Size(63, 21);
            this.lblEstadoEnvio.TabIndex = 46;
            this.lblEstadoEnvio.Text = "Estado:";
            // 
            // lblSedeEnvio
            // 
            this.lblSedeEnvio.AutoSize = true;
            this.lblSedeEnvio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeEnvio.Location = new System.Drawing.Point(58, 198);
            this.lblSedeEnvio.Name = "lblSedeEnvio";
            this.lblSedeEnvio.Size = new System.Drawing.Size(116, 21);
            this.lblSedeEnvio.TabIndex = 50;
            this.lblSedeEnvio.Text = "Sede objetivo:";
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEstado.Location = new System.Drawing.Point(189, 153);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(195, 29);
            this.txtEstado.TabIndex = 52;
            // 
            // lblTipooperacion
            // 
            this.lblTipooperacion.AutoSize = true;
            this.lblTipooperacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipooperacion.Location = new System.Drawing.Point(58, 70);
            this.lblTipooperacion.Name = "lblTipooperacion";
            this.lblTipooperacion.Size = new System.Drawing.Size(125, 21);
            this.lblTipooperacion.TabIndex = 53;
            this.lblTipooperacion.Text = "Tipo operación:";
            // 
            // cmbTipooperacion
            // 
            this.cmbTipooperacion.AutoCompleteCustomSource.AddRange(new string[] {
            "Envío",
            "Recepción"});
            this.cmbTipooperacion.DisplayMember = "NombreSede";
            this.cmbTipooperacion.FormattingEnabled = true;
            this.cmbTipooperacion.Items.AddRange(new object[] {
            "Envío",
            "Recepción"});
            this.cmbTipooperacion.Location = new System.Drawing.Point(189, 73);
            this.cmbTipooperacion.Name = "cmbTipooperacion";
            this.cmbTipooperacion.Size = new System.Drawing.Size(195, 21);
            this.cmbTipooperacion.TabIndex = 54;
            this.cmbTipooperacion.ValueMember = "Id";
            this.cmbTipooperacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipooperacion_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(314, 105);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 32);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirmarrecepcion
            // 
            this.btnConfirmarrecepcion.BackColor = System.Drawing.Color.LightBlue;
            this.btnConfirmarrecepcion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarrecepcion.Location = new System.Drawing.Point(151, 296);
            this.btnConfirmarrecepcion.Name = "btnConfirmarrecepcion";
            this.btnConfirmarrecepcion.Size = new System.Drawing.Size(180, 32);
            this.btnConfirmarrecepcion.TabIndex = 56;
            this.btnConfirmarrecepcion.Text = "Confirmar Recepcion";
            this.btnConfirmarrecepcion.UseVisualStyleBackColor = false;
            // 
            // FormEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 378);
            this.Controls.Add(this.btnConfirmarrecepcion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbTipooperacion);
            this.Controls.Add(this.lblTipooperacion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbSedeEnvio);
            this.Controls.Add(this.lblSedeEnvio);
            this.Controls.Add(this.btnEnvio);
            this.Controls.Add(this.lblEstadoEnvio);
            this.Controls.Add(this.dtpFechaEnvio);
            this.Controls.Add(this.lblFechaEnvio);
            this.Controls.Add(this.txtCodEnvio);
            this.Controls.Add(this.lblCodEnvio);
            this.Controls.Add(this.lblEnvio);
            this.Name = "FormEnvio";
            this.Text = "FormEnvio";
            this.Load += new System.EventHandler(this.FormEnvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnvio;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblCodEnvio;
        private System.Windows.Forms.ComboBox cmbSedeEnvio;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvio;
        private System.Windows.Forms.TextBox txtCodEnvio;
        private System.Windows.Forms.Label lblEstadoEnvio;
        private System.Windows.Forms.Label lblSedeEnvio;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblTipooperacion;
        private System.Windows.Forms.ComboBox cmbTipooperacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfirmarrecepcion;
    }
}