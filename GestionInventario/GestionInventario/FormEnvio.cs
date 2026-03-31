using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario
{
    public partial class FormEnvio : Form
    {
        private static FormEnvio instancia = null;
        public static FormEnvio ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed) //Si no se ha creado la ventana o si se ha cerrado
            {
                instancia = new FormEnvio();
                return instancia;
            }
            return instancia;
        }

        public FormEnvio()
        {
            InitializeComponent();
        }

        private void lblNumeroMtto_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaMtto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaMtto_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipooperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipooperacion = cmbTipooperacion.SelectedItem.ToString();
            if (tipooperacion == "Envío")
            {
                btnEnvio.Visible = true;
                btnConfirmarrecepcion.Visible = false;
            }
            else
            if (tipooperacion == "Recepción")
            {
                btnEnvio.Visible = false;
                btnConfirmarrecepcion.Visible = true;
            }
        }

        private void FormEnvio_Load(object sender, EventArgs e)
        {
            cmbTipooperacion.SelectedItem = "Recepción"; // Establecer el valor predeterminado del ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
