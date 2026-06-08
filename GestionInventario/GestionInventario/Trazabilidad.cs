using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionInventario
{
    public partial class Trazabilidad : Form
    {

        string connectionString = Conexion.cadena;
        private static Trazabilidad instancia = null;
        public static Trazabilidad ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new Trazabilidad();
                return instancia;
            }
            return instancia;
        }



        public Trazabilidad()
        {
            InitializeComponent();
        }

        private void Trazabilidad_Load(object sender, EventArgs e)
        {
            CargarPorcentajeMtto();
            CargarGraficoPorcentajeMtto();
        }

        private void CargarPorcentajeMtto()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT
            a.Activo AS TipoActivo,
            COUNT(DISTINCT r.Id) AS TotalActivos,
            COUNT(m.Id) AS TotalMttos,
            CAST(
                COUNT(m.Id) * 100.0 /
                NULLIF(COUNT(DISTINCT r.Id),0)
                AS DECIMAL(10,2)
            ) AS PorcentajeMtto
        FROM RegistroActivos r
        INNER JOIN Activos a
            ON r.IdActivo = a.Id
        LEFT JOIN Mantenimiento m
            ON r.Id = m.InventarioId
        GROUP BY a.Activo";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPorcentajemtto.DataSource = dt;

                // Personalizar encabezados
                dgvPorcentajemtto.Columns["TipoActivo"].HeaderText = "Tipo de Activo";
                dgvPorcentajemtto.Columns["TotalActivos"].HeaderText = "Total Activos";
                dgvPorcentajemtto.Columns["TotalMttos"].HeaderText = "Ingresos Mtto";
                dgvPorcentajemtto.Columns["PorcentajeMtto"].HeaderText = "Porcentaje mantenimiento";

                // Formato del porcentaje
                //dgvPorcentajemtto.Columns["PorcentajeMtto"].DefaultCellStyle.Format = "N2";
                dgvPorcentajemtto.Columns["PorcentajeMtto"].DefaultCellStyle.Format = "0.00' %'";
            }
        }

        private void CargarGraficoPorcentajeMtto()
        {
            chartPorcentajemtto.Series.Clear();
            chartPorcentajemtto.ChartAreas[0].AxisX.Interval = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
        SELECT
            a.Activo AS TipoActivo,
            COUNT(DISTINCT r.Id) AS TotalActivos,
            COUNT(m.Id) AS TotalMttos,
            CAST(
                COUNT(m.Id) * 100.0 /
                NULLIF(COUNT(DISTINCT r.Id),0)
                AS DECIMAL(10,2)
            ) AS PorcentajeMtto
        FROM RegistroActivos r
        INNER JOIN Activos a
            ON r.IdActivo = a.Id
        LEFT JOIN Mantenimiento m
            ON r.Id = m.InventarioId
        GROUP BY a.Activo
        ORDER BY PorcentajeMtto DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Series serie = new Series("% Mtto");
                serie.ChartType = SeriesChartType.Bar;
                serie.IsValueShownAsLabel = true;

                foreach (DataRow row in dt.Rows)
                {
                    serie.Points.AddXY(
                        row["TipoActivo"].ToString(),
                        Convert.ToDouble(row["PorcentajeMtto"])
                    );
                }

                chartPorcentajemtto.Series.Add(serie);
            }
        }

    }
}
