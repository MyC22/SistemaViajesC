using Formularios.SelecionarCliente;
using Objetos;
using Objetos.Cronograma;
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

namespace sistema_de_viajes
{
    public partial class Seleccionarprograma : Form
    {
        List<cronogramalista> cl = new List<cronogramalista>();
        Servicios s = new Servicios();
        ModeloCronograma mc = new ModeloCronograma();
        public Seleccionarprograma()
        {
            InitializeComponent();
        }

        private void Seleccionarprograma_Load(object sender, EventArgs e)
        {
            mostrartabla();
        }
        private void mostrartabla()
        {
            cl = mc.Mostrarcronograma();
            dataGridView1.DataSource = cl;
            int filas = dataGridView1.Rows.Count;
            for (int i = 0; i < filas; i++)
            {
                int id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                dataGridView1.Rows[i].Cells["Asientos"].Value = mc.mostrarasientosdiponibles(id);
            }
            List<cronogramalista> result = cl.Where(c => (c.Asientos != 0)).ToList();
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(s.id != 0)
            {
                SeleccionarCliente sc = new SeleccionarCliente(s.id);
                sc.Show();
                this.Close();
            } else { MessageBox.Show("Primero debe seleccionar a una cronograma de viajes"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idcronograma = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlDataReader dr = mc.mostrarservicio(idcronograma);
            if (dr.Read()) { 
                s.id = (int)dr["ID"];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtdestinoB.Text != "" || txtorigenB.Text != "" || (DateTime.TryParse(mtxtfechaB.Text, out DateTime fechar)))
            {
                string origen = txtorigenB.Text;
                string destino = txtdestinoB.Text;
                DateTime fecha = DateTime.MinValue;
                if (DateTime.TryParse(mtxtfechaB.Text, out DateTime result1)) { fecha = DateTime.Parse(mtxtfechaB.Text); }
                List<cronogramalista> result = cl.Where(c =>
                (string.IsNullOrEmpty(origen) || c.origen.IndexOf(origen, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (string.IsNullOrEmpty(destino) || c.destino.IndexOf(destino, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (fecha.Equals(DateTime.MinValue) || c.fecha.Date.CompareTo(fecha) == 0) && c.Asientos != 0)
                    .ToList();
                dataGridView1.DataSource = result;
                s.id = 0;
                txtorigenB.Focus();
            }
            else
            {
                mostrartabla();
            }
        }
    }
}
