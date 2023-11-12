using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Objetos;

namespace Formularios
{
    public partial class TablaLugar : Form
    {
        private ModeloLugar modeloLugar;
        private List<Lugarr> todosLosLugares;
        private string estado;

        public TablaLugar()
        {
            InitializeComponent();
            modeloLugar = new ModeloLugar();
            MostrarTodosLosLugares();

            DesactivarCampos();
        }
        private void ActivarCampos()
        {
            txtDepartamento.Enabled = true;
            txtDistrito.Enabled = true;
            txtTerminal.Enabled = true;
            txtDireccion.Enabled = true;
            cbEstado.Enabled = true;
        }

        private void DesactivarCampos()
        {
            txtDepartamento.Enabled = false;
            txtDistrito.Enabled = false;
            txtTerminal.Enabled = false;
            txtDireccion.Enabled = false;
            cbEstado.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtDepartamento.Text = "";
            txtDistrito.Text = "";
            txtTerminal.Text = "";
            txtDireccion.Text = "";
            cbEstado.SelectedIndex = 0;
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
            if (txtdepartamentB.Text != "" || txtdistritoB.Text != "" || txtterminalB.Text != "")
            {
                string departamento = txtdepartamentB.Text;
                string distrito = txtdistritoB.Text;
                string terminal = txtterminalB.Text;

                List<Lugarr> resultadosBusqueda = todosLosLugares
                    .Where(l =>
                        (string.IsNullOrEmpty(departamento) || l.Departamento.IndexOf(departamento, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(distrito) || l.Distrito.IndexOf(distrito, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(terminal) || l.Terminal.IndexOf(terminal, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();

                dataGridView2.DataSource = resultadosBusqueda;
            }
            else
            {
                MostrarTodosLosLugares();
            }
        }

        private void btnañadir_Click_1(object sender, EventArgs e)
        {
            estado = "G";
            ActivarCampos();
            LimpiarCampos();
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
                        LimpiarCampos();
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
            string estadoLugar = cbEstado.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(departamento) || string.IsNullOrEmpty(distrito) || string.IsNullOrEmpty(terminal) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(estadoLugar))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            if (modeloLugar != null)
            {
                try
                {
                    if (estado == "G")
                    {
                        modeloLugar.AgregarLugar(distrito, direccion, terminal, departamento, estadoLugar);
                        MessageBox.Show("Se añadió el lugar correctamente.");
                    }
                    else if (estado == "E")
                    {
                        if (dataGridView2.SelectedRows.Count > 0)
                        {
                            int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["ID"].Value);
                            modeloLugar.EditarLugar(id, distrito, direccion, terminal, departamento, estadoLugar);
                            MessageBox.Show("Se guardó la edición.");
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un lugar para editar.");
                            return;
                        }
                    }

                    MostrarTodosLosLugares();
                    LimpiarCampos();
                    DesactivarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar/editar el lugar: " + ex.Message);
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
                    estado = "E";
                    ActivarCampos();

                    txtDepartamento.Text = lugar.Departamento;
                    txtDistrito.Text = lugar.Distrito;
                    txtTerminal.Text = lugar.Terminal;
                    txtDireccion.Text = lugar.Direccion;
                    cbEstado.SelectedItem = lugar.Estado;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un lugar para editar.");
            }
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarTodosLosLugares();
            DesactivarCampos();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["ID"].Value);

                Lugarr lugar = todosLosLugares.FirstOrDefault(l => l.ID == id);

                if (lugar != null)
                {
                    txtDepartamento.Text = lugar.Departamento;
                    txtDistrito.Text = lugar.Distrito;
                    txtTerminal.Text = lugar.Terminal;
                    txtDireccion.Text = lugar.Direccion;
                    cbEstado.SelectedItem = lugar.Estado;
                }
            }
        }

        private void TablaLugar_Load(object sender, EventArgs e)
        {

        }
    }
}
