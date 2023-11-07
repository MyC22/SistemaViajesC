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

namespace Formularios.SelecionarCliente
{
    public partial class SeleccionarCliente : Form
    {
        List<ClienteListaPersona> cl = new List<ClienteListaPersona>();
        ModeloCliente mc = new ModeloCliente();
        public SeleccionarCliente()
        {
            InitializeComponent();
        }
        
        private void SeleccionarCliente_Load(object sender, EventArgs e)
        { 
            cl = mc.MostrarClientePersona();
            dataGridView1.DataSource = cl;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtnombrecliente.Text;
            string apellidoCliente = txtapellidocliente.Text;
            string Dni = txtdni.Text;
            List<ClienteListaPersona> resultadosBusqueda = cl
                .Where(c =>
                    (string.IsNullOrEmpty(nombreCliente) || c.Nombres.IndexOf(nombreCliente, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(apellidoCliente) || c.Apellido.IndexOf(apellidoCliente, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (string.IsNullOrEmpty(Dni) || c.DNI.IndexOf(Dni, StringComparison.OrdinalIgnoreCase) >= 0))
                .ToList();

            dataGridView1.DataSource = resultadosBusqueda;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

<<<<<<< HEAD
        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {

        }
=======
>>>>>>> b722301344b9498b80208a35a17e1c7ded1593d2
    }
}
