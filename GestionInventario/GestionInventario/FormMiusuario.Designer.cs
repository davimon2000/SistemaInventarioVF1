namespace GestionInventario
{
    partial class FormMiusuario
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
            this.lblNomIndicador = new System.Windows.Forms.Label();
            this.lblMiusuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblSedeIndicador = new System.Windows.Forms.Label();
            this.lblUsuarioRed = new System.Windows.Forms.Label();
            this.lblUsuarioRedInd = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomIndicador
            // 
            this.lblNomIndicador.AutoSize = true;
            this.lblNomIndicador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomIndicador.Location = new System.Drawing.Point(48, 82);
            this.lblNomIndicador.Name = "lblNomIndicador";
            this.lblNomIndicador.Size = new System.Drawing.Size(75, 21);
            this.lblNomIndicador.TabIndex = 37;
            this.lblNomIndicador.Text = "Nombre:";
            // 
            // lblMiusuario
            // 
            this.lblMiusuario.AutoSize = true;
            this.lblMiusuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiusuario.Location = new System.Drawing.Point(147, 31);
            this.lblMiusuario.Name = "lblMiusuario";
            this.lblMiusuario.Size = new System.Drawing.Size(93, 25);
            this.lblMiusuario.TabIndex = 39;
            this.lblMiusuario.Text = "USUARIO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(175, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 21);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(175, 123);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(44, 21);
            this.lblSede.TabIndex = 42;
            this.lblSede.Text = "Sede";
            // 
            // lblSedeIndicador
            // 
            this.lblSedeIndicador.AutoSize = true;
            this.lblSedeIndicador.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSedeIndicador.Location = new System.Drawing.Point(48, 123);
            this.lblSedeIndicador.Name = "lblSedeIndicador";
            this.lblSedeIndicador.Size = new System.Drawing.Size(51, 21);
            this.lblSedeIndicador.TabIndex = 41;
            this.lblSedeIndicador.Text = "Sede:";
            // 
            // lblUsuarioRed
            // 
            this.lblUsuarioRed.AutoSize = true;
            this.lblUsuarioRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRed.Location = new System.Drawing.Point(175, 165);
            this.lblUsuarioRed.Name = "lblUsuarioRed";
            this.lblUsuarioRed.Size = new System.Drawing.Size(112, 21);
            this.lblUsuarioRed.TabIndex = 44;
            this.lblUsuarioRed.Text = "Usuario de red";
            // 
            // lblUsuarioRedInd
            // 
            this.lblUsuarioRedInd.AutoSize = true;
            this.lblUsuarioRedInd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRedInd.Location = new System.Drawing.Point(48, 165);
            this.lblUsuarioRedInd.Name = "lblUsuarioRedInd";
            this.lblUsuarioRedInd.Size = new System.Drawing.Size(121, 21);
            this.lblUsuarioRedInd.TabIndex = 43;
            this.lblUsuarioRedInd.Text = "Usuario de red:";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.BackColor = System.Drawing.Color.LightGray;
            this.btnRestablecer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(120, 309);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(167, 32);
            this.btnRestablecer.TabIndex = 49;
            this.btnRestablecer.Text = "Restablecer";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNuevaPass.Location = new System.Drawing.Point(33, 264);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.Size = new System.Drawing.Size(167, 29);
            this.txtNuevaPass.TabIndex = 50;
            this.txtNuevaPass.UseSystemPasswordChar = true;
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirmarPass.Location = new System.Drawing.Point(206, 264);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.Size = new System.Drawing.Size(167, 29);
            this.txtConfirmarPass.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Confirmar Contraseña:";
            // 
            // FormMiusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarPass);
            this.Controls.Add(this.txtNuevaPass);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.lblUsuarioRed);
            this.Controls.Add(this.lblUsuarioRedInd);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblSedeIndicador);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMiusuario);
            this.Controls.Add(this.lblNomIndicador);
            this.Name = "FormMiusuario";
            this.Text = "Mi usuario";
            this.Load += new System.EventHandler(this.FormMiusuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNomIndicador;
        private System.Windows.Forms.Label lblMiusuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblSedeIndicador;
        private System.Windows.Forms.Label lblUsuarioRed;
        private System.Windows.Forms.Label lblUsuarioRedInd;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}