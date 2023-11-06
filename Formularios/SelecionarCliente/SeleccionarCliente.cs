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
        private ModeloCliente modeloCliente;
        private List<Cliente> todosLosClientes;

        public SeleccionarCliente()
        {
            InitializeComponent();
            modeloCliente = new ModeloCliente();
            todosLosClientes = modeloCliente.MostrarClientes();
            dataGridView1.DataSource = todosLosClientes;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtnombrecliente.Text;
            string apellidoCliente = txtapellidocliente.Text;
            int celularCliente;

            if (int.TryParse(txtcelularcliente.Text, out celularCliente))
            {
                List<Cliente> resultadosBusqueda = todosLosClientes
                    .Where(c =>
                        (string.IsNullOrEmpty(nombreCliente) || c.Nombres.IndexOf(nombreCliente, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(apellidoCliente) || c.Apellido.IndexOf(apellidoCliente, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (c.Celular == celularCliente))
                    .ToList();

                dataGridView1.DataSource = resultadosBusqueda;

                txtnombrecliente.Text = "";
                txtapellidocliente.Text = "";
                txtcelularcliente.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de celular válido.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeleccionarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
