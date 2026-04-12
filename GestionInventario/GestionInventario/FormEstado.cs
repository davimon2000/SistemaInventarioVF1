using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace GestionInventario
{
    public partial class FormEstado : Form
    {

        string connectionString = "Server=LPT140112\\SQLEXPRESS;Database=InventarioActivos;User Id=inventarioUser;Password=Inventario2025++;";
        private static FormEstado instancia = null;
        public static FormEstado ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new FormEstado();
                return instancia;
            }
            return instancia;
        }
        public FormEstado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEstado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet3.vw_ResumenActivosPorSedeEstado' Puede moverla o quitarla según sea necesario.
            this.vw_ResumenActivosPorSedeEstadoTableAdapter.Fill(this.inventarioActivosDataSet3.vw_ResumenActivosPorSedeEstado);
            // TODO: esta línea de código carga datos en la tabla 'estadoYSedeView.ResumenActivosPorSedeEstadoView' Puede moverla o quitarla según sea necesario.
            this.resumenActivosPorSedeEstadoViewTableAdapter.Fill(this.estadoYSedeView.ResumenActivosPorSedeEstadoView);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet2.Marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.inventarioActivosDataSet2.Marcas);
            // TODO: esta línea de código carga datos en la tabla 'inventarioActivosDataSet_MarcasVisual.RegistroActivos' Puede moverla o quitarla según sea necesario.
            //  this.registroActivosTableAdapter.Fill(this.inventarioActivosDataSet_MarcasVisual.RegistroActivos);
            //CargarGraficoEstadoGeneral();
            //CargarEstadoDiademas();
            // Asignar evento al combo
            //cmbGrafico.SelectedIndexChanged += cmbGrafico_SelectedIndexChanged;
            //cmbGraficoMarcas.SelectedIndexChanged += cmbGraficoMarcas_SelectedIndexChanged;
            CargarGrafico();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {

        }

        private void CargarGraficoEstadoGeneral()
        {
        //    chart1.Series.Clear();
        //    chart1.Titles.Clear();
        //    chart1.Titles.Add("Estado general de diademas");

        //    Series serie = new Series("Diademas");
        //    serie.ChartType = SeriesChartType.Pie;
        //    serie.IsValueShownAsLabel = true; // Mostrar valor como etiqueta
        //    serie.LabelForeColor = Color.Black; //  Color del número
        //    serie.Font = new Font("Arial", 10); //  Estilo del número

            

        //    int disponibles = 0;
        //    int enMantenimiento = 0;

        //    string query = @"
        //SELECT EstadoDefinitivo, COUNT(*) as Total 
        //FROM VistaActivos
        //WHERE EstadoDefinitivo IN ('Nuevo', 'Disponible(Registro)', 'Recuperado', 'Baja', 'En Mtto', 'Reparado', 'Bueno', 'Asignado')
        //GROUP BY EstadoDefinitivo";

        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        conn.Open();
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                string estado = reader["EstadoDefinitivo"].ToString();
        //                int total = Convert.ToInt32(reader["Total"]);

        //                if (estado == "En Mtto")
        //                    enMantenimiento += total;
        //                else
        //                {
        //                    if (estado != "Baja" && estado != "Asignado")
        //                    {
        //                        disponibles += total;
        //                    }
        //                }   
        //            }
        //        }
        //    }

        //    serie.Points.AddXY("Disponibles para asignar", disponibles);
        //    serie.Points.AddXY("En mantenimiento", enMantenimiento);

        //    chart1.Series.Add(serie);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void FiltrarDatos()
        {
            //List<string> condiciones = new List<string>();

            //if (cmbMarca.SelectedItem != null && cmbMarca.SelectedItem.ToString() != "TODOS")
            //    condiciones.Add("Marca = @Marca");

            //if (cmbEstado.SelectedItem != null && cmbEstado.SelectedItem.ToString() != "Todos")
            //    condiciones.Add("EstadoDefinitivo = @Estado");

            ////if (cmbSede.SelectedItem != null && cmbSede.SelectedItem.ToString() != "Todos")
            //    condiciones.Add("Sede = @Sede");

            ////if (cmbFalla.SelectedItem != null && cmbFalla.SelectedItem.ToString() != "Todos")
            //    condiciones.Add("TipoFalla = @Falla");

            //string where = condiciones.Count > 0 ? "WHERE " + string.Join(" AND ", condiciones) : "";

            //string query = "SELECT * FROM VistaActivos " + where;

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //using (SqlCommand cmd = new SqlCommand(query, conn))
            //{
            //    if (query.Contains("@Marca")) cmd.Parameters.AddWithValue("@Marca", cmbMarca.SelectedItem.ToString());               
            //    if (query.Contains("@Estado")) cmd.Parameters.AddWithValue("@Estado", cmbEstado.SelectedItem.ToString());
            //    if (query.Contains("@Sede")) cmd.Parameters.AddWithValue("@Sede", cmbSede.SelectedItem.ToString());
            //    //if (query.Contains("@Falla")) cmd.Parameters.AddWithValue("@Falla", cmbFalla.SelectedItem.ToString());

            //    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            //    {
            //        DataTable dt = new DataTable();
            //        adapter.Fill(dt);
            //        dgvResultados.DataSource = dt;

            //        lblTotal.Text =  dt.Rows.Count.ToString();
            //    }
            //}
        }

        private void chartMarcas_Click(object sender, EventArgs e)
        {

        }
        private void CargarGraficoMarcas()
        {
            //chartMarcas.Series.Clear();
            //chartMarcas.Titles.Clear();

            //Series serie = new Series("Diademas por Marca");
            //serie.ChartType = SeriesChartType.Column;
            //serie.IsValueShownAsLabel = true;


            //string query = "SELECT Marca, COUNT(*) AS Cantidad FROM RegistroActivos GROUP BY Marca";
    //        string query = @"
    //SELECT M.Marca, COUNT(*) AS Cantidad
    //FROM RegistroActivos RA
    //INNER JOIN Marcas M ON RA.Marca = M.Id
    //GROUP BY M.Marca";


//            string query = @"
//SELECT M.Marca, COUNT(*) AS Cantidad
//FROM RegistroActivos RA
//INNER JOIN Marcas M ON RA.Marca = M.Id
//WHERE NOT EXISTS (
//    SELECT 1
//    FROM VistaActivos MT
//    WHERE MT.CodInterno= RA.CodInterno
//      AND MT.EstadoDefinitivo = 'Baja' -- Ajusta si usas otro valor
//)
//GROUP BY M.Marca";

//            Color[] colores = new Color[]
//    {
//        Color.SteelBlue,
//        Color.Orange,
//        Color.ForestGreen,
//        Color.Firebrick,
//        Color.MediumPurple,
//        Color.Teal,
//        Color.Goldenrod,
//        Color.CadetBlue,
//        Color.IndianRed,
//        Color.DarkCyan
//    };

//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                SqlCommand cmd = new SqlCommand(query, con);
//                con.Open();
//                SqlDataReader reader = cmd.ExecuteReader();

//                //while (reader.Read())
//                //{
//                //    string marca = reader["Marca"].ToString();
//                //    int cantidad = Convert.ToInt32(reader["Cantidad"]);
//                //    serie.Points.AddXY(marca, cantidad);
//                //}

//                //reader.Close();

//                int i = 0;
//                while (reader.Read())
//                {
//                    string nombreMarca = reader["Marca"].ToString();
//                    int cantidad = Convert.ToInt32(reader["Cantidad"]);

//                    int colorIndex = i % colores.Length;

//                    DataPoint punto = new DataPoint();
//                    punto.AxisLabel = nombreMarca;
//                    punto.YValues = new double[] { cantidad };
//                    punto.Color = colores[colorIndex];

//                    serie.Points.Add(punto);
//                    i++;
//                }

//                reader.Close();
//            }

//            chartMarcas.Series.Add(serie);
//            chartMarcas.Titles.Add("Cantidad de Diademas por Marca");
//            chartMarcas.Legends.Clear(); // ← Esto oculta la leyenda
        }

        private void cmbGraficoMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string opcion = cmbGraficoMarcas.SelectedItem.ToString();

            //if (opcion == "Marcas-Disponibles")
            //{
            //    chartMarcas.Visible = true;
            //    CargarGraficoMarcas();
            //}
            //else if (opcion == "Estado-Sede")
            //{
            //    chartMarcas.Visible = false;
                
            //}
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarEstadoDiademas()
        {
            try
            {
                string query = @"
WITH UltimoMovimiento AS (
    SELECT 
        a.IdActivo,
        a.SedeId,
        a.EstadoDevolucion,
        ROW_NUMBER() OVER (
            PARTITION BY a.IdActivo
            ORDER BY a.Id DESC
        ) AS rn
    FROM Asignacion a
),
EstadoActual AS (
    SELECT 
        um.SedeId,
        CASE 
            WHEN m.EstadoSalida = 'EnMtto' THEN 'En Mtto'
            WHEN um.EstadoDevolucion IS NULL THEN 'Asignado'
            ELSE um.EstadoDevolucion
        END AS Estado
    FROM UltimoMovimiento um
    LEFT JOIN Mantenimiento m 
        ON m.InventarioId = um.IdActivo
    WHERE um.rn = 1
)
SELECT 
    s.NombreSede AS Sede,
    ea.Estado,
    COUNT(*) AS Cantidad
FROM EstadoActual ea
INNER JOIN Sedes s ON s.Id = ea.SedeId
GROUP BY s.NombreSede, ea.Estado
ORDER BY s.NombreSede, ea.Estado;
";

                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    cn.Open();
                    da.Fill(dt);
                    dgvEstado.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar el estado de las diademas\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarGrafico()
        {
            chartActivos.Series.Clear();
            chartActivos.ChartAreas[0].AxisX.Interval = 1;

            //string conexion = "TU_CADENA_DE_CONEXION";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Sede, EstadoActual, Cantidad FROM vw_ResumenActivosPorSedeEstado";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                var sedes = dt.AsEnumerable()
                              .Select(r => r["Sede"].ToString())
                              .Distinct()
                              .ToList();

                var estados = dt.AsEnumerable()
                                .Select(r => r["EstadoActual"].ToString())
                                .Distinct()
                                .ToList();

                // Crear series primero
                foreach (var estado in estados)
                {
                    Series serie = new Series(estado);
                    serie.ChartType = SeriesChartType.Column;
                    serie.IsValueShownAsLabel = true; // muestra cantidad arriba
                    chartActivos.Series.Add(serie);
                }

                // Ahora recorrer sedes (categorías del eje X)
                foreach (var sede in sedes)
                {
                    foreach (var estado in estados)
                    {
                        var fila = dt.AsEnumerable()
                            .FirstOrDefault(r =>
                                r["Sede"].ToString() == sede &&
                                r["EstadoActual"].ToString() == estado);

                        int cantidad = fila != null
                            ? Convert.ToInt32(fila["Cantidad"])
                            : 0;

                        chartActivos.Series[estado].Points.AddXY(sede, cantidad);
                    }
                }
            }
        }
    }
}
