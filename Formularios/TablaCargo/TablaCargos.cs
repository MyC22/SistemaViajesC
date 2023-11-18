using Objetos.Modelo;
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
using static Objetos.Empleado;
using System.Reflection.Emit;
using System.Data.SqlClient;

namespace sistema_de_viajes
{
    public partial class TablaCargos : Form
    {
        private ModeloCargo modelocargo;
        private List<Cargo> TodosLosCargos;
        private string estado;


        public TablaCargos()
        {
            InitializeComponent();
            modelocargo = new ModeloCargo();
            MostrarTodosLosCargos();
            // Se desactivan los campos de texto al inicio del formulario.
            desactivartxt();
        }

        private void MostrarTodosLosCargos()
        {
            try
            {
                TodosLosCargos = modelocargo.MostrarTodosLosCargos();
                dataGridView1.DataSource = TodosLosCargos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar Cargos: " + ex.Message);
            }
        }

        // Instancias de ModeloCargo y Cargo para operaciones internas.
        ModeloCargo mc = new ModeloCargo();
        Cargo c = new Cargo();

        private void TablaCargos_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            MostrarTodosLosCargos();
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            desactivartxt();
        }

        // Botón para realizar la búsqueda de Cargos.
        private void btnbuscarcargo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id) || !string.IsNullOrEmpty(txtfiltronombre.Text))
            {
                string cargo = txtfiltronombre.Text;

                // Filtra la lista de Cargos según los criterios de búsqueda.
                List<Cargo> resultadosBusqueda = TodosLosCargos
                    .Where(l =>
                        (id == 0 || l.ID == id) &&
                        (string.IsNullOrEmpty(cargo) || l.cargo.IndexOf(cargo, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();

                // Actualiza el DataGridView con los resultados de la búsqueda.
                dataGridView1.DataSource = resultadosBusqueda;
            }
            else
            {
                // Muestra todos los Cargos si no se proporcionan criterios de búsqueda.
                MostrarTodosLosCargos();
            }
        }

        // Botón para añadir un nuevo Cargo.
        private void btnañadir_Click(object sender, EventArgs e)
        {
            estado = "G";

            // Habilita el botón de guardar y deshabilita los de editar y eliminar.
            btnguardar.Enabled = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
            dataGridView1.Enabled = false;
            // Habilita los campos de texto para la entrada de nuevos datos.
            activartxt();

            // Limpia los campos de texto.
            limpiar();
        }

        // Botón para eliminar un Cargo.
        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (modelocargo != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        // Elimina el Cargo seleccionado.
                        modelocargo.EliminarCargo(id);

                        // Actualiza la lista de Cargos en el DataGridView.
                        MostrarTodosLosCargos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el Cargo: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un Cargo para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        // Botón para guardar o editar un Cargo.
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string cargo = txtnombre.Text;
            string descripcion = txtDescripcion.Text;

            if (string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            if (modelocargo != null)
            {
                try
                {
                    if (estado == "G")
                    {
                        // Agrega un nuevo Cargo.
                        modelocargo.AgregarCargo(cargo, descripcion);
                    }
                    else if (estado == "E")
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                        // Edita un Cargo existente.
                        modelocargo.EditaCargo(id, cargo, descripcion);
                    }

                    // Limpia los campos de texto.
                    limpiar();

                    // Desactiva los campos de texto.
                    desactivartxt();
                    cancelar();
                    // Actualiza la lista de Cargos en el DataGridView.
                    MostrarTodosLosCargos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar o editar el Cargo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        // Botón para editar un Cargo.
        private void btneditar_Click(object sender, EventArgs e)
        {
            estado = "E";
            dataGridView1.Enabled = false;
            btnguardar.Enabled = true;
            activartxt();
            btnañadir.Enabled = false;
        }
        private void cancelar()
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            dataGridView1.Enabled = true;
        }
        // Botón para cancelar la operación actual y volver al estado inicial.
        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Limpia los campos de texto.
            limpiar();
            cancelar();
            // Desactiva los campos de texto.
            desactivartxt();

            // Actualiza la lista de Cargos en el DataGridView.
            MostrarTodosLosCargos();
        }


        // Método para desactivar los campos de texto.
        private void desactivartxt()
        {
            txtnombre.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        // Método para activar los campos de texto.
        private void activartxt()
        {
            txtnombre.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        // Método para limpiar los campos de texto.
        private void limpiar()
        {
            txtnombre.Clear();
            txtDescripcion.Clear();
        }

        // Método para obtener datos de los campos de texto y asignarlos a la instancia de Cargo.
        private void datos()
        {
            c.cargo = txtnombre.Text;
            c.descripcion = txtDescripcion.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            SqlDataReader dr = modelocargo.listarcargoId(id);
            if (dr.Read())
            {
                txtDescripcion.Text = dr["Descripcion"].ToString();
                txtnombre.Text = dr["Cargo"].ToString();
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
            }
            datos();
        }
    }
}
