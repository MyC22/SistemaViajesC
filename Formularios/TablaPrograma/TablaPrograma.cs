using Formularios;
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
    public partial class TablaPrograma : Form
    {
        cronograma c = new cronograma();
        Servicios s = new Servicios();
        ModeloRuta mr = new ModeloRuta();
        ModeloCronograma mc = new ModeloCronograma();
        SeleccionarRuta sr;
        string estado;
        public TablaPrograma(int idusuario)
        {
            InitializeComponent();
            c.idusuario = idusuario;
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
            dataGridView1.DataSource = mc.Mostrarcronograma();
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
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
            c.fechasalida = (DateTime)dtfecha.Value + TimeSpan.Parse(mtxtturno.Text);
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
    }
}
