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

            txtnombre.Enabled = false;
            txtDescripcion.Enabled = false;
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

        ModeloCargo mc = new ModeloCargo();
        Cargo c = new Cargo();

        private void TablaCargos_Load(object sender, EventArgs e)
        {
       
        }

        private void btnbuscarcargo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id) || !string.IsNullOrEmpty(txtfiltronombre.Text))
            {
                string cargo = txtfiltronombre.Text;

                List<Cargo> resultadosBusqueda = TodosLosCargos
                    .Where(l =>
                        (id == 0 || l.ID == id) &&
                        (string.IsNullOrEmpty(cargo) || l.cargo.IndexOf(cargo, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();

                dataGridView1.DataSource = resultadosBusqueda;
            }
            else
            {
                MostrarTodosLosCargos();
            }

        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            estado = "G";

            btnguardar.Enabled = true;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;

            txtnombre.Enabled = true;
            txtDescripcion.Enabled = true;

            txtnombre.Text = "";
            txtDescripcion.Text = "";
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (modelocargo != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        modelocargo.EliminarCargo(id);

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
                        modelocargo.AgregarCargo(cargo, descripcion);
                    }
                    else if (estado == "E")
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                        modelocargo.EditaCargo(id, cargo, descripcion);
                    }

                    txtnombre.Text = "";
                    txtDescripcion.Text = "";

                    txtnombre.Enabled = false;
                    txtDescripcion.Enabled = false;

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

        private void btneditar_Click(object sender, EventArgs e)
        {
            estado = "E";

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                Cargo cargo = TodosLosCargos.FirstOrDefault(l => l.ID == id);

                if (cargo != null)
                {
                    txtnombre.Text = cargo.cargo;
                    txtDescripcion.Text = cargo.descripcion;

                    txtnombre.Enabled = true;
                    txtDescripcion.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un modelo para editar.");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtDescripcion.Text = "";

            btneditar.Enabled = true;
            btneliminar.Enabled = true;

            txtnombre.Enabled = false;
            txtDescripcion.Enabled = false;
            MostrarTodosLosCargos();
        }


       private void desactivartxt()
        {
            txtnombre.Enabled = false;
            txtDescripcion.Enabled = false;
        }

        private void activartxt()
        {
            txtnombre.Enabled = true;
            txtDescripcion.Enabled = true;
        }

        private void limpiar() 
        {
            txtnombre.Clear();
            txtDescripcion.Clear();
        }

        private void datos()
        {
            c.cargo = txtnombre.Text;
            c.descripcion = txtDescripcion.Text;
        }

        
    }
}
