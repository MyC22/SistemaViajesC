using Formularios;
using Objetos;
using Objetos.Buses;
using Objetos.Cronograma;
using Objetos.Modelo;
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
    public partial class TablaPrograma : Form
    {
        cronograma c = new cronograma();
        Servicios s = new Servicios();
        ModeloRuta mr = new ModeloRuta();
        ModeloCronograma mc = new ModeloCronograma();
        ModelBus mb = new ModelBus();
        SeleccionarRuta sr;
        List<cronogramalista> cl = new List<cronogramalista>();
        string estado;
        public TablaPrograma(string usuario)
        {
            InitializeComponent();
            c.usuario = usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sr = new SeleccionarRuta();
            sr.FormClosed += SeleccionarRutaclose;
            sr.Show();
        }
        private void SeleccionarRutaclose(object sender, EventArgs e)
        {
            c.idruta = sr.id;
            if(c.idruta != 0)
            {
                SqlDataReader dr= mr.listarRutaID(c.idruta);
                if (dr.Read())
                {
                    txtruta.Text = dr["Nombre"].ToString();
                }
            }
        }

        private void TablaPrograma_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            cl = mc.Mostrarcronograma();
            dataGridView1.DataSource = cl;
            cbbuses.DataSource = mb.MostrarTodosBuses();
            cbbuses.ValueMember = "";
            cbbuses.DisplayMember = "Placa";
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private Boolean validardatos()
        {
            if (txtpiso1.Text != "" &&
                txtpiso2.Text != "" &&
                txtruta.Text != "" &&
                mtxtturno.Text != "" &&
                txtservicio.Text != "" &&
                cbbuses.SelectedIndex != -1 &&
                c.idruta != 0)
            {
                return true;
            }
            else return false;
        }
        private void limpiar()
        {
            txtpiso1.Clear();
            txtpiso2.Clear();
            txtruta.Clear();
            c.idruta = 0;
            cbbuses.SelectedIndex = -1;
            cbturno.SelectedIndex = -1;
            mtxtturno.Clear();
            txtservicio.Clear();
        }
        private void desactivartxt()
        {
            txtpiso1.Enabled = false;
            txtpiso2.Enabled = false;
            cbbuses.Enabled = false;
            cbturno.Enabled = false;
            mtxtturno.Enabled = false;
            txtservicio.Enabled = false;
        }
        private void activartxt()
        {
            txtpiso1.Enabled = true;
            txtpiso2.Enabled = true;
            cbbuses.Enabled = true;
            cbturno.Enabled = true;
            mtxtturno.Enabled = true;
            txtservicio.Enabled = true;
        }
        private void datos()
        {
            c.placabus = cbbuses.Text;
            c.fechasalida = (DateTime)dtfecha.Value.Date + TimeSpan.Parse(mtxtturno.Text);
            s.preciop1 = Convert.ToDouble(txtpiso1.Text);
            s.preciop2 = Convert.ToDouble(txtpiso2.Text);
            s.nombre = txtservicio.Text;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            limpiar();
            label12.Text = "Añadir";
            estado = "g";
            btnguardar.Enabled = true;
            activartxt();
            dataGridView1.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                if(estado == "g")
                {
                    datos();
                    mc.Agregarcronograma(s, c);
                    limpiar();
                    desactivartxt();
                    dataGridView1.DataSource = mc.Mostrarcronograma();
                    btneditar.Enabled = false;
                    btnguardar.Enabled = false;
                    btnañadir.Enabled = true;
                    btneliminar.Enabled = false;
                    dataGridView1.Enabled = true;
                    MessageBox.Show("se guardo");
                }
            }
            else { MessageBox.Show("Falta datos"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string origen = txtorigenB.Text;
            string destino = txtdestinoB.Text;
            DateTime fecha = DateTime.MinValue;
            if (DateTime.TryParse(mtxtfechaB.Text, out DateTime demora)) { fecha = DateTime.Parse(mtxtfechaB.Text); }
            List<cronogramalista> result = cl.Where(c =>
            (string.IsNullOrEmpty(origen) || c.origen.IndexOf(origen, StringComparison.OrdinalIgnoreCase) >= 0)&&
            (string.IsNullOrEmpty(destino) || c.origen.IndexOf(destino, StringComparison.OrdinalIgnoreCase) >= 0)&&
            fecha.Equals(DateTime.MinValue) || c.fecha.Date.CompareTo(fecha)==0)
                .ToList();
            dataGridView1.DataSource = result;
        }
    }
}
