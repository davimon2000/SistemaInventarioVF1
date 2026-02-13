namespace GestionInventario
{
    partial class FormEstado
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.registroActivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRegistro = new System.Windows.Forms.Label();
            this.chartActivos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.inventarioActivosDataSet2 = new GestionInventario.InventarioActivosDataSet2();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new GestionInventario.InventarioActivosDataSet2TableAdapters.MarcasTableAdapter();
            this.dgvEstado = new System.Windows.Forms.DataGridView();
            this.estadoYSedeView = new GestionInventario.EstadoYSedeView();
            this.resumenActivosPorSedeEstadoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resumenActivosPorSedeEstadoViewTableAdapter = new GestionInventario.EstadoYSedeViewTableAdapters.ResumenActivosPorSedeEstadoViewTableAdapter();
            this.sedeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoYSedeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenActivosPorSedeEstadoViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registroActivosBindingSource
            // 
            this.registroActivosBindingSource.DataMember = "RegistroActivos";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(300, 33);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(157, 25);
            this.lblRegistro.TabIndex = 12;
            this.lblRegistro.Text = "ESTADO ACTUAL";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // chartActivos
            // 
            this.chartActivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartActivos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartActivos.Legends.Add(legend1);
            this.chartActivos.Location = new System.Drawing.Point(38, 312);
            this.chartActivos.Name = "chartActivos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartActivos.Series.Add(series1);
            this.chartActivos.Size = new System.Drawing.Size(675, 250);
            this.chartActivos.TabIndex = 13;
            this.chartActivos.Text = "chart1";
            this.chartActivos.Click += new System.EventHandler(this.chart1_Click);
            // 
            // inventarioActivosDataSet2
            // 
            this.inventarioActivosDataSet2.DataSetName = "InventarioActivosDataSet2";
            this.inventarioActivosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.inventarioActivosDataSet2;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // dgvEstado
            // 
            this.dgvEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstado.AutoGenerateColumns = false;
            this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sedeDataGridViewTextBoxColumn,
            this.estadoActualDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgvEstado.DataSource = this.resumenActivosPorSedeEstadoViewBindingSource;
            this.dgvEstado.Location = new System.Drawing.Point(38, 78);
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.Size = new System.Drawing.Size(675, 186);
            this.dgvEstado.TabIndex = 22;
            this.dgvEstado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // estadoYSedeView
            // 
            this.estadoYSedeView.DataSetName = "EstadoYSedeView";
            this.estadoYSedeView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resumenActivosPorSedeEstadoViewBindingSource
            // 
            this.resumenActivosPorSedeEstadoViewBindingSource.DataMember = "ResumenActivosPorSedeEstadoView";
            this.resumenActivosPorSedeEstadoViewBindingSource.DataSource = this.estadoYSedeView;
            // 
            // resumenActivosPorSedeEstadoViewTableAdapter
            // 
            this.resumenActivosPorSedeEstadoViewTableAdapter.ClearBeforeFill = true;
            // 
            // sedeDataGridViewTextBoxColumn
            // 
            this.sedeDataGridViewTextBoxColumn.DataPropertyName = "Sede";
            this.sedeDataGridViewTextBoxColumn.HeaderText = "Sede";
            this.sedeDataGridViewTextBoxColumn.Name = "sedeDataGridViewTextBoxColumn";
            // 
            // estadoActualDataGridViewTextBoxColumn
            // 
            this.estadoActualDataGridViewTextBoxColumn.DataPropertyName = "EstadoActual";
            this.estadoActualDataGridViewTextBoxColumn.HeaderText = "EstadoActual";
            this.estadoActualDataGridViewTextBoxColumn.Name = "estadoActualDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // FormEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(773, 562);
            this.Controls.Add(this.dgvEstado);
            this.Controls.Add(this.chartActivos);
            this.Controls.Add(this.lblRegistro);
            this.Name = "FormEstado";
            this.Text = "Estado";
            this.Load += new System.EventHandler(this.FormEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroActivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioActivosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoYSedeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumenActivosPorSedeEstadoViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.BindingSource registroActivosBindingSource;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartActivos;
        private InventarioActivosDataSet2 inventarioActivosDataSet2;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private InventarioActivosDataSet2TableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridView dgvEstado;
        private EstadoYSedeView estadoYSedeView;
        private System.Windows.Forms.BindingSource resumenActivosPorSedeEstadoViewBindingSource;
        private EstadoYSedeViewTableAdapters.ResumenActivosPorSedeEstadoViewTableAdapter resumenActivosPorSedeEstadoViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sedeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}