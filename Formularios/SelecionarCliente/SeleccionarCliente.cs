using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using sistema_de_viajes;

namespace Formularios.SelecionarCliente
{
    public partial class SeleccionarCliente : Form
    {
        List<ClienteListaPersona> clp = new List<ClienteListaPersona>();
        List<ClienteListaEmpresa> cle = new List<ClienteListaEmpresa>();
        ModeloCliente mc = new ModeloCliente();
        Cliente c  = new Cliente();
        int idservicio;
        public SeleccionarCliente(int idservicio)
        {
            InitializeComponent();
            this.idservicio = idservicio;
        }
         
        private void SeleccionarCliente_Load(object sender, EventArgs e)
        { 
            clp = mc.MostrarClientePersona();
            dataGridView1.DataSource = clp;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                LdniB.Visible = true;
                txtdniB.Visible = true;
                lrucB.Visible = false;
                txtrucB.Visible = false;
                txtnombrecliente.Text = "";
                txtdniB.Text = "";
                txtrucB.Text = "";
                clp = mc.MostrarClientePersona();
                dataGridView1.DataSource = clp;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LdniB.Visible = false;
                txtdniB.Visible = false;
                lrucB.Visible = true;
                txtrucB.Visible = true;
                txtnombrecliente.Text = "";
                txtdniB.Text = "";
                txtrucB.Text = "";
                cle = mc.MostrarClienteEmpresa();
                dataGridView1.DataSource = cle;
            }
        }

        private void btnañadirCliente_Click(object sender, EventArgs e)
        {
            TablaCliente te = new TablaCliente();
            te.Show();
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtnombrecliente.Text != "" || txtdniB.Text != "" || txtrucB.Text != "")
            {
                if (radioButton1.Checked)
                {
                    string nombreCliente = txtnombrecliente.Text;
                    string Dni = txtdniB.Text;
                    List<ClienteListaPersona> resultadosBusqueda = clp
                        .Where(c =>
                            (string.IsNullOrEmpty(nombreCliente) || c.Nombres.IndexOf(nombreCliente, StringComparison.OrdinalIgnoreCase) >= 0) &&
                            (string.IsNullOrEmpty(Dni) || c.DNI.IndexOf(Dni, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();
                    dataGridView1.DataSource = resultadosBusqueda;
                }
                if (radioButton2.Checked)
                {
                    string nombreCliente = txtnombrecliente.Text;
                    string ruc = txtrucB.Text;
                    List<ClienteListaEmpresa> resultadosBusqueda = cle
                        .Where(c =>
                            (string.IsNullOrEmpty(nombreCliente) || c.Nombres.IndexOf(nombreCliente, StringComparison.OrdinalIgnoreCase) >= 0) &&
                            (string.IsNullOrEmpty(ruc) || c.Ruc.IndexOf(ruc, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();
                    dataGridView1.DataSource = resultadosBusqueda;
                }
            }
            else
            {
                if (radioButton1.Checked) { dataGridView1.DataSource = mc.MostrarClientePersona(); }
                if (radioButton2.Checked) { dataGridView1.DataSource = mc.MostrarClienteEmpresa(); }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Seleccionarprograma se = new Seleccionarprograma();
            se.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(c.ID != 0)
            {
                CrearBoleto cb = new CrearBoleto(idservicio, c.ID);
                cb.Show();
                this.Close();
            }else { MessageBox.Show("Primero debe seleccionar a un cliente"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            c.ID = id;
        }
    }
}
