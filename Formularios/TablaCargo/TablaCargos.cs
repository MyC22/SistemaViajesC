using Objetos.Cargo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Objetos.Empleado;

namespace sistema_de_viajes
{
    public partial class TablaCargos : Form
    {
        public TablaCargos()
        {
            InitializeComponent();
        }

        ModeloCargo mc = new ModeloCargo();
        Cargo c = new Cargo();

        private void TablaCargos_Load(object sender, EventArgs e)
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            dataGridView1.DataSource = mc.listarCargo();
            desactivartxt();
        }

        private void desactivartxt()
        {
            txtCargo.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void activartxt()
        {
            txtCargo.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void limpiar() 
        {
            txtCargo.Clear();
            txtDescripcion.Clear();
        }

        private void datos()
        {
            c.nombre = txtCargo.Text;
            c.descripcion = txtDescripcion.Text;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            btnguardar.Enabled = true;
            activartxt();
            dataGridView1.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try 
            {
                datos();
                mc.guardarCargo(c);
                limpiar();
                desactivartxt();
                dataGridView1.DataSource = mc.listarCargo();
                btnguardar.Enabled = false;
                btnañadir.Enabled = true;
                btncancelar.Enabled = false;
                btneditar.Enabled = false;
                MessageBox.Show("SE GUARDÓ CORRECTAMENTE", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"SE PRODUJO UN ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
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
