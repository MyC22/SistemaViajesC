using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Objetos;
using static Objetos.Empleado;

namespace Formularios
{
    public partial class TablaLugar : Form
    {
        private ModeloLugar modeloLugar = new ModeloLugar();
        private List<Lugarr> todosLosLugares;
        private string estado;

        public TablaLugar()
        {
            InitializeComponent();
        }

        private void TablaLugar_Load(object sender, EventArgs e)
        {
            MostrarTodosLosLugares();
            DesactivarCampos();
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            label12.Text = "";
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
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
        private void cancelar()
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            dataGridView2.Enabled = true;
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
            dataGridView2.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            btnguardar.Enabled = true;
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
                        DesactivarCampos();
                        dataGridView2.Enabled = true;
                        btneditar.Enabled = false;
                        btnguardar.Enabled = false;
                        btnañadir.Enabled = true;
                        MessageBox.Show("Se elimino con exito");
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
                    cancelar();
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
            estado = "E";
            ActivarCampos();
            btnguardar.Enabled = true;
            btnañadir.Enabled = false;
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
            MostrarTodosLosLugares();
            DesactivarCampos();
            cancelar();
        }

        private void txtlugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se permite ese tipo de caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtdistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 45) || (e.KeyChar >= 47 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se permite ese tipo de caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells[0].Value;
            SqlDataReader dr = modeloLugar.listarlugarId(id);
            if (dr.Read())
            {
                txtDepartamento.Text = dr["Departamento"].ToString();
                txtTerminal.Text = dr["Terminal"].ToString();
                txtDistrito.Text = dr["Distrito"].ToString();
                txtDireccion.Text = dr["Direccion"].ToString();
                int idcargo = cbEstado.FindStringExact(dr["Estado"].ToString());
                cbEstado.SelectedIndex = idcargo;
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }
    }
}
