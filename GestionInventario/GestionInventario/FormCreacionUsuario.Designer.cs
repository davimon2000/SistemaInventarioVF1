namespace GestionInventario
{
    partial class FormCreacionUsuario
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
            this.lblUsuarioRedInd = new System.Windows.Forms.Label();
            this.lblSedeIndicador = new System.Windows.Forms.Label();
            this.lblMiusuario = new System.Windows.Forms.Label();
            this.lblNomIndicador = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkMtto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblUsuarioRedInd
            // 
            this.lblUsuarioRedInd.AutoSize = true;
            this.lblUsuarioRedInd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRedInd.Location = new System.Drawing.Point(70, 144);
            this.lblUsuarioRedInd.Name = "lblUsuarioRedInd";
            this.lblUsuarioRedInd.Size = new System.Drawing.Size(69, 21);
            this.lblUsuarioRedInd.TabIndex = 50;
            this.lblUsuarioRedInd.Text = "Usuario:";
            // 
            // lblSedeIndicador
            // 
            this.lblSedeIndicador.AutoSize = true;
            this.lblSedeIndicador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeIndicador.Location = new System.Drawing.Point(70, 187);
            this.lblSedeIndicador.Name = "lblSedeIndicador";
            this.lblSedeIndicador.Size = new System.Drawing.Size(51, 21);
            this.lblSedeIndicador.TabIndex = 48;
            this.lblSedeIndicador.Text = "Sede:";
            // 
            // lblMiusuario
            // 
            this.lblMiusuario.AutoSize = true;
            this.lblMiusuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiusuario.Location = new System.Drawing.Point(130, 43);
            this.lblMiusuario.Name = "lblMiusuario";
            this.lblMiusuario.Size = new System.Drawing.Size(192, 25);
            this.lblMiusuario.TabIndex = 46;
            this.lblMiusuario.Text = "CREACIÓN USUARIO";
            // 
            // lblNomIndicador
            // 
            this.lblNomIndicador.AutoSize = true;
            this.lblNomIndicador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomIndicador.Location = new System.Drawing.Point(70, 95);
            this.lblNomIndicador.Name = "lblNomIndicador";
            this.lblNomIndicador.Size = new System.Drawing.Size(75, 21);
            this.lblNomIndicador.TabIndex = 45;
            this.lblNomIndicador.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNombre.Location = new System.Drawing.Point(199, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 29);
            this.txtNombre.TabIndex = 52;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.Location = new System.Drawing.Point(199, 136);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 29);
            this.txtUsuario.TabIndex = 53;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContraseña.Location = new System.Drawing.Point(199, 270);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(197, 29);
            this.txtContraseña.TabIndex = 54;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // cmbSede
            // 
            this.cmbSede.DisplayMember = "NombreSede";
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(199, 190);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(195, 21);
            this.cmbSede.TabIndex = 55;
            this.cmbSede.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Tecnico",
            "Practicante"});
            this.cmbRol.DisplayMember = "NombreSede";
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Tecnico",
            "Practicante"});
            this.cmbRol.Location = new System.Drawing.Point(199, 232);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(195, 21);
            this.cmbRol.TabIndex = 58;
            this.cmbRol.ValueMember = "Id";
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.LightBlue;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(199, 363);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(70, 32);
            this.btnCrear.TabIndex = 59;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Permisos mtto:";
            // 
            // checkMtto
            // 
            this.checkMtto.AutoSize = true;
            this.checkMtto.Location = new System.Drawing.Point(199, 326);
            this.checkMtto.Name = "checkMtto";
            this.checkMtto.Size = new System.Drawing.Size(35, 17);
            this.checkMtto.TabIndex = 61;
            this.checkMtto.Text = "Si";
            this.checkMtto.UseVisualStyleBackColor = true;
            this.checkMtto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormCreacionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 423);
            this.Controls.Add(this.checkMtto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblUsuarioRedInd);
            this.Controls.Add(this.lblSedeIndicador);
            this.Controls.Add(this.lblMiusuario);
            this.Controls.Add(this.lblNomIndicador);
            this.Name = "FormCreacionUsuario";
            this.Text = "Creacion Usuarios";
            this.Load += new System.EventHandler(this.FormCreacionUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsuarioRedInd;
        private System.Windows.Forms.Label lblSedeIndicador;
        private System.Windows.Forms.Label lblMiusuario;
        private System.Windows.Forms.Label lblNomIndicador;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkMtto;
    }
}