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
            this.btnRestablecer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Location = new System.Drawing.Point(92, 222);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(194, 32);
            this.btnRestablecer.TabIndex = 49;
            this.btnRestablecer.Text = "Restablecer contraseña";
            this.btnRestablecer.UseVisualStyleBackColor = false;
            // 
            // FormMiusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 315);
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
    }
}