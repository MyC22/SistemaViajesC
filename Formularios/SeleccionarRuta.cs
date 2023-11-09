using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class SeleccionarRuta : Form
    {
        ModeloRuta modeloRuta = new ModeloRuta();
        Rutas r = new Rutas();
        List<Rutas> todasLasRutas = new List<Rutas>();
        public int id { get; set; }
        public SeleccionarRuta()
        {
            InitializeComponent();
        }

        private void SeleccionarRuta_Load(object sender, EventArgs e)
        {
            MostrarTodasLasRutas();
            button2.Enabled = false;
        }
        private void MostrarTodasLasRutas()
        {
            try
            {
                todasLasRutas = modeloRuta.MostrarRutas();
                dataGridView1.DataSource = todasLasRutas;
                dataGridView1.Columns["IDOrigen"].Visible = false;
                dataGridView1.Columns["IDDestino"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar rutas: " + ex.Message);
            }
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            if (txtnombreB.Text != "" || txtorigenB.Text != "" || txtDestinoB.Text != "")
            {
                string nombre = txtnombreB.Text;
                string destino = txtDestinoB.Text;
                string origen = txtorigenB.Text;
                List<Rutas> resultadosBusqueda = todasLasRutas
                    .Where(c =>
                        (string.IsNullOrEmpty(nombre) || c.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(origen) || c.Origen.IndexOf(origen, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(destino) || c.Destino.IndexOf(destino, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();
                dataGridView1.DataSource = resultadosBusqueda;
            }
            else
            {
                MostrarTodasLasRutas();
            }
            button2.Enabled = false;
            this.id = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.id != 0 || this.id != null || this.id > 0 )
            {

                this.Close();
            }
            else { MessageBox.Show("Se necesita que seleccione una ruta"); }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.id = 0;
            this.Close();
        }
    }
}
