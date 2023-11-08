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

namespace Formularios
{
    public partial class TablaLugar : Form
    {
        private ModeloLugar modeloLugar;
        private List<Lugarr> todosLosLugares;

        public TablaLugar()
        {
            InitializeComponent();
            modeloLugar = new ModeloLugar();
            MostrarTodosLosLugares();

            cbfiltro.Items.AddRange(new string[] { "Seleccionar", "ID", "Distrito", "Departamento" });
            cbfiltro.SelectedIndex = 0;

            txtDepartamento.Enabled = false;
            txtDistrito.Enabled = false;
            txtTerminal.Enabled = false;
            txtDireccion.Enabled = false;
            cbEstado.Enabled = false;
        }

        private void MostrarTodosLosLugares()
        {
            try
            {
                todosLosLugares = modeloLugar.MostrarTodosLosLugares();
                dataGridView2.DataSource = todosLosLugares;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar lugares: " + ex.Message);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cbfiltro.SelectedItem.ToString();
            string valorFiltro = txtfiltro.Text;

            if (filtroSeleccionado == "Seleccionar")
            {
                MessageBox.Show("Por favor, seleccione un filtro válido antes de buscar.");
                return;
            }

            try
            {
                if (txtfiltro.Enabled)
                {
                    List<Lugarr> lugaresEncontrados = todosLosLugares
                        .Where(lugar =>
                        (filtroSeleccionado == "ID" && valorFiltro != "" && lugar.ID.ToString().Equals(valorFiltro, StringComparison.OrdinalIgnoreCase)) ||
                        (filtroSeleccionado == "Distrito" && valorFiltro != "" && lugar.Distrito.IndexOf(valorFiltro, StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (filtroSeleccionado == "Departamento" && valorFiltro != "" && lugar.Departamento.IndexOf(valorFiltro, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();

                    dataGridView2.DataSource = lugaresEncontrados;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un filtro válido antes de buscar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar lugares: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = cbfiltro.SelectedItem.ToString();

            txtfiltro.Enabled = (filtroSeleccionado != "Seleccionar");
            btBuscar.Enabled = txtfiltro.Enabled;
        }

        private void btnañadir_Click_1(object sender, EventArgs e)
        {
            txtDepartamento.Enabled = true;
            txtDistrito.Enabled = true;
            txtTerminal.Enabled = true;
            txtDireccion.Enabled = true;
            cbEstado.Enabled = true;

            txtDepartamento.Text = "";
            txtDistrito.Text = "";
            txtTerminal.Text = "";
            txtDireccion.Text = "";
            cbEstado.SelectedIndex = 0;
        }


        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (modeloLugar != null)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        modeloLugar.EliminarLugar(id);

                        MostrarTodosLosLugares();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el lugar: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un lugar para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            string departamento = txtDepartamento.Text;
            string distrito = txtDistrito.Text;
            string terminal = txtTerminal.Text;
            string direccion = txtDireccion.Text;
            string estado = cbEstado.SelectedItem.ToString();

            if (string.IsNullOrEmpty(departamento) || string.IsNullOrEmpty(distrito) || string.IsNullOrEmpty(terminal) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            if (modeloLugar != null)
            {
                try
                {
                    modeloLugar.AgregarLugar(distrito, direccion, terminal, departamento, estado);

                    txtDepartamento.Text = "";
                    txtDistrito.Text = "";
                    txtTerminal.Text = "";
                    txtDireccion.Text = "";
                    cbEstado.SelectedIndex = 0;

                    txtDepartamento.Enabled = false;
                    txtDistrito.Enabled = false;
                    txtTerminal.Enabled = false;
                    txtDireccion.Enabled = false;
                    cbEstado.Enabled = false;

                    MostrarTodosLosLugares();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el lugar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        private void btneditar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);

                Lugarr lugar = todosLosLugares.FirstOrDefault(l => l.ID == id);

                if (lugar != null)
                {
                    txtDepartamento.Text = lugar.Departamento;
                    txtDistrito.Text = lugar.Distrito;
                    txtTerminal.Text = lugar.Terminal;
                    txtDireccion.Text = lugar.Direccion;
                    cbEstado.SelectedItem = lugar.Estado;

                    txtDepartamento.Enabled = true;
                    txtDistrito.Enabled = true;
                    txtTerminal.Enabled = true;
                    txtDireccion.Enabled = true;
                    cbEstado.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un lugar para editar.");
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            txtDepartamento.Text = "";
            txtDistrito.Text = "";
            txtTerminal.Text = "";
            txtDireccion.Text = "";
            cbEstado.SelectedIndex = 0;

            txtDepartamento.Enabled = false;
            txtDistrito.Enabled = false;
            txtTerminal.Enabled = false;
            txtDireccion.Enabled = false;
            cbEstado.Enabled = false;
        }
    }
}
