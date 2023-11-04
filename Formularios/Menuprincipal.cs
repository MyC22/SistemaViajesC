using Formularios.SelecionarCliente;
using Objetos;
using Presentacion;
using sistema_de_viajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal(int idempleado)
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaEmpleado te = new TablaEmpleado();
            te.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menuprincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciarsecion ini= new Iniciarsecion();
            ini.Show();
            this.Hide();
        }

        private void boletosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearBoleto crearBoleto = new CrearBoleto();
            crearBoleto.Show();
        }

        private void recervacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearViajes crearViajes = new CrearViajes();
            crearViajes.Show();
        }

        private void boletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscarboletos buscarboletos = new Buscarboletos();
            buscarboletos.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarFactura buscarFactura = new BuscarFactura();
            buscarFactura.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarCliente mostrarClientes = new SeleccionarCliente();
            mostrarClientes.Show();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaBuses tablaBuses = new TablaBuses();
            tablaBuses.Show();
        }

        private void programacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaPrograma tablaPrograma = new TablaPrograma();
            tablaPrograma.Show();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaCargos tablaCargos = new TablaCargos();
            tablaCargos.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaModelo tablaModelo = new TablaModelo();
            tablaModelo.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seleccionarprograma seleccionarprograma = new Seleccionarprograma();
            seleccionarprograma.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarCliente seleccionarCliente = new SeleccionarCliente();
            seleccionarCliente.Show();
        }
    }
}
