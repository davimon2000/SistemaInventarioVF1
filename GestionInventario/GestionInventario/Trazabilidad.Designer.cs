namespace GestionInventario
{
    partial class Trazabilidad
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trazabilidad));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.dgvPorcentajemtto = new System.Windows.Forms.DataGridView();
            this.chartPorcentajemtto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentajemtto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPorcentajemtto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(505, 30);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(180, 32);
            this.lblRegistro.TabIndex = 13;
            this.lblRegistro.Text = "TRAZABILIDAD";
            // 
            // dgvPorcentajemtto
            // 
            this.dgvPorcentajemtto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorcentajemtto.Location = new System.Drawing.Point(71, 149);
            this.dgvPorcentajemtto.Name = "dgvPorcentajemtto";
            this.dgvPorcentajemtto.RowHeadersWidth = 51;
            this.dgvPorcentajemtto.RowTemplate.Height = 24;
            this.dgvPorcentajemtto.Size = new System.Drawing.Size(590, 277);
            this.dgvPorcentajemtto.TabIndex = 14;
            // 
            // chartPorcentajemtto
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPorcentajemtto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPorcentajemtto.Legends.Add(legend1);
            this.chartPorcentajemtto.Location = new System.Drawing.Point(702, 149);
            this.chartPorcentajemtto.Name = "chartPorcentajemtto";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPorcentajemtto.Series.Add(series1);
            this.chartPorcentajemtto.Size = new System.Drawing.Size(422, 277);
            this.chartPorcentajemtto.TabIndex = 15;
            this.chartPorcentajemtto.Text = "chart1";
            // 
            // Trazabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 450);
            this.Controls.Add(this.chartPorcentajemtto);
            this.Controls.Add(this.dgvPorcentajemtto);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Trazabilidad";
            this.Text = "Trazabilidad";
            this.Load += new System.EventHandler(this.Trazabilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorcentajemtto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPorcentajemtto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataGridView dgvPorcentajemtto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPorcentajemtto;
    }
}