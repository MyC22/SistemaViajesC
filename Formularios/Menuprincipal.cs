using Formularios.SelecionarCliente;
using Objetos;
using Presentacion;
using sistema_de_viajes;
using sistema_modelo;
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
        string usuario;
        public Menuprincipal(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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

        private void recervacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaRuta TablaRuta = new TablaRuta();
            TablaRuta.Show();
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
            TablaCliente TablaCliente = new TablaCliente();
            TablaCliente.Show();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaBuses tablaBuses = new TablaBuses();
            tablaBuses.Show();
        }

        private void programacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaPrograma tablaPrograma = new TablaPrograma(usuario);
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

        private void lugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaLugar tablaLugar = new TablaLugar();
            tablaLugar.Show();
        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaRuta tablaRuta = new TablaRuta();
            tablaRuta.Show();
        }

        private void boletosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Seleccionarprograma se = new Seleccionarprograma();
            se.Show();
        }
    }
}
