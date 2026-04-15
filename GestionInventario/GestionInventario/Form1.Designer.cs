using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionInventario
{
    partial class FormMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMDI));
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnCreacionUsuarios = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnMiusuaio = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnEnvio = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.picIndicadores = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEstado = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalida = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnIngresomtto = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicadores)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenuVertical.Controls.Add(this.panel10);
            this.pnlMenuVertical.Controls.Add(this.btnSalir);
            this.pnlMenuVertical.Controls.Add(this.pictureBox9);
            this.pnlMenuVertical.Controls.Add(this.btnCreacionUsuarios);
            this.pnlMenuVertical.Controls.Add(this.panel9);
            this.pnlMenuVertical.Controls.Add(this.pictureBox8);
            this.pnlMenuVertical.Controls.Add(this.btnMiusuaio);
            this.pnlMenuVertical.Controls.Add(this.panel8);
            this.pnlMenuVertical.Controls.Add(this.pictureBox7);
            this.pnlMenuVertical.Controls.Add(this.btnEnvio);
            this.pnlMenuVertical.Controls.Add(this.panel6);
            this.pnlMenuVertical.Controls.Add(this.picIndicadores);
            this.pnlMenuVertical.Controls.Add(this.panel7);
            this.pnlMenuVertical.Controls.Add(this.btnEstado);
            this.pnlMenuVertical.Controls.Add(this.panel5);
            this.pnlMenuVertical.Controls.Add(this.pictureBox5);
            this.pnlMenuVertical.Controls.Add(this.panel4);
            this.pnlMenuVertical.Controls.Add(this.btnConsulta);
            this.pnlMenuVertical.Controls.Add(this.pictureBox4);
            this.pnlMenuVertical.Controls.Add(this.panel3);
            this.pnlMenuVertical.Controls.Add(this.btnSalida);
            this.pnlMenuVertical.Controls.Add(this.panel2);
            this.pnlMenuVertical.Controls.Add(this.pictureBox2);
            this.pnlMenuVertical.Controls.Add(this.panel1);
            this.pnlMenuVertical.Controls.Add(this.pictureBox1);
            this.pnlMenuVertical.Controls.Add(this.btnRegistro);
            this.pnlMenuVertical.Controls.Add(this.pictureBox3);
            this.pnlMenuVertical.Controls.Add(this.btnIngresomtto);
            resources.ApplyResources(this.pnlMenuVertical, "pnlMenuVertical");
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenuVertical_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox9
            // 
            resources.ApplyResources(this.pictureBox9, "pictureBox9");
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.TabStop = false;
            // 
            // btnCreacionUsuarios
            // 
            this.btnCreacionUsuarios.FlatAppearance.BorderSize = 0;
            this.btnCreacionUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnCreacionUsuarios, "btnCreacionUsuarios");
            this.btnCreacionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnCreacionUsuarios.Name = "btnCreacionUsuarios";
            this.btnCreacionUsuarios.UseVisualStyleBackColor = true;
            this.btnCreacionUsuarios.Click += new System.EventHandler(this.btnCreacionUsuarios_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // pictureBox8
            // 
            resources.ApplyResources(this.pictureBox8, "pictureBox8");
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.TabStop = false;
            // 
            // btnMiusuaio
            // 
            this.btnMiusuaio.FlatAppearance.BorderSize = 0;
            this.btnMiusuaio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnMiusuaio, "btnMiusuaio");
            this.btnMiusuaio.ForeColor = System.Drawing.Color.White;
            this.btnMiusuaio.Name = "btnMiusuaio";
            this.btnMiusuaio.UseVisualStyleBackColor = true;
            this.btnMiusuaio.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // pictureBox7
            // 
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // btnEnvio
            // 
            this.btnEnvio.FlatAppearance.BorderSize = 0;
            this.btnEnvio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnEnvio, "btnEnvio");
            this.btnEnvio.ForeColor = System.Drawing.Color.White;
            this.btnEnvio.Name = "btnEnvio";
            this.btnEnvio.UseVisualStyleBackColor = true;
            this.btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // picIndicadores
            // 
            resources.ApplyResources(this.picIndicadores, "picIndicadores");
            this.picIndicadores.Name = "picIndicadores";
            this.picIndicadores.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // btnEstado
            // 
            this.btnEstado.FlatAppearance.BorderSize = 0;
            this.btnEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnEstado, "btnEstado");
            this.btnEstado.ForeColor = System.Drawing.Color.White;
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Controls.Add(this.panel11);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnConsulta, "btnConsulta");
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnSalida
            // 
            this.btnSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnSalida, "btnSalida");
            this.btnSalida.ForeColor = System.Drawing.Color.White;
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnRegistro, "btnRegistro");
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click_1);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // btnIngresomtto
            // 
            this.btnIngresomtto.FlatAppearance.BorderSize = 0;
            this.btnIngresomtto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.btnIngresomtto, "btnIngresomtto");
            this.btnIngresomtto.ForeColor = System.Drawing.Color.White;
            this.btnIngresomtto.Name = "btnIngresomtto";
            this.btnIngresomtto.UseVisualStyleBackColor = true;
            this.btnIngresomtto.Click += new System.EventHandler(this.btnIngresomtto_Click_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // FormMDI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.pnlMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.IsMdiContainer = true;
            this.Name = "FormMDI";
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.pnlMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicadores)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlMenuVertical;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button btnIngresomtto;
        private Button btnRegistro;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button btnSalida;
        private Panel panel4;
        private Button btnConsulta;
        private PictureBox pictureBox5;
        private Panel panel5;
        private PictureBox picIndicadores;
        private Panel panel7;
        private Button btnEstado;
        private Panel panel6;
        private PictureBox pictureBox7;
        private Button btnEnvio;
        private PictureBox pictureBox9;
        private Button btnCreacionUsuarios;
        private Panel panel9;
        private PictureBox pictureBox8;
        private Button btnMiusuaio;
        private Panel panel8;
        private Button btnSalir;
        private Panel panel10;
        private Panel panel11;
    }
}
