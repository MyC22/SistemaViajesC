using Objetos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistema_de_viajes
{
    public partial class CrearBoleto : Form
    {
        string estado;
        int idservicio;
        int idcliente;
        comprobante c = new comprobante();
        Servicios s = new Servicios();
        boletos b = new boletos();
        ModeloBoleto mb = new ModeloBoleto();
        public CrearBoleto(int idservicio, int idcliente)
        {
            InitializeComponent();
            this.idcliente = idcliente;
            this.idservicio = idservicio;

        }

        private void CrearBoleto_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            SqlDataReader dr = mb.listarservicio(idservicio);
            if (dr.Read())
            {
                s.preciop1 = (float)dr["Precio_piso1"];
                s.preciop2 = (float)dr["Precio_piso2"];
            }
            cbpiso.SelectedIndex = -1;
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            desactivartxt();
        }
        private void desactivartxt()
        {
            txtapellido.Enabled = false;
            txtnombre.Enabled = false;
            cbpiso.Enabled = false;
        }
        private void activartxt()
        {
            txtapellido.Enabled = true;
            txtnombre.Enabled = true;
            cbpiso.Enabled = true;
        }
        private void limpiar()
        {
            txtapellido.Clear();
            txtnombre.Clear();
            cbpiso.SelectedIndex = -1;
            lprecio.Text = "Precio";
        }
        private void cancelar()
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            dataGridView1.Enabled = true;
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

        private void btnañadir_Click(object sender, EventArgs e)
        {
            activartxt();
            limpiar();
            estado = "g";
            btnguardar.Enabled = true;
            activartxt();
            dataGridView1.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void cbpiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbpiso.Text == "Piso 1")
            {
                lprecio.Text = s.preciop1.ToString();
            }
            if (cbpiso.Text == "Piso 2")
            {
                lprecio.Text = s.preciop2.ToString();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtnombre.Text, txtapellido.Text , lprecio.Text);
            limpiar();
        }
    }
}
