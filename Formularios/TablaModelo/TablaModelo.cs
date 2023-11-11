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
using Objetos.Modelo;

namespace sistema_modelo
{
    public partial class TablaModelo : Form
    {
        private Modelomodelo modelomodelos;
        private List<Modelo> TodosLosModelos;
        private char estado;

        public TablaModelo()
        {
            InitializeComponent();
            modelomodelos = new Modelomodelo();
            MostrarTodosLosModelos();

            txtnombre.Enabled = false;
            nasiento.Enabled = false;
            txttamanio.Enabled = false;
            npisos.Enabled = false;
        }


        private void MostrarTodosLosModelos()
        {
            try
            {
                TodosLosModelos = modelomodelos.MostrarTodosLosModelos();
                dataGridView1.DataSource = TodosLosModelos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar lugares: " + ex.Message);
            }
        }

        private void btnbuscarmodelo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIDB.Text, out int id) || !string.IsNullOrEmpty(txtModeloB.Text))
            {
                string modelo = txtModeloB.Text;

                List<Modelo> resultadosBusqueda = TodosLosModelos
                    .Where(l =>
                        (id == 0 || l.ID == id) &&
                        (string.IsNullOrEmpty(modelo) || l.Nombre.IndexOf(modelo, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();

                dataGridView1.DataSource = resultadosBusqueda;
            }
            else
            {
                MostrarTodosLosModelos();
            }

        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            estado = 'G';

            txtnombre.Enabled = true;
            nasiento.Enabled = true;
            txttamanio.Enabled = true;
            npisos.Enabled = true;

            txtnombre.Text = "";
            nasiento.Value = 0;
            txttamanio.Text = "";
            npisos.Value = 0;
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (modelomodelos != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        modelomodelos.EliminarModelo(id);

                        MostrarTodosLosModelos();
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string tamanio = txttamanio.Text;
            int asientos = (int)nasiento.Value;
            int pisos = (int)npisos.Value;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tamanio))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            if (modelomodelos != null)
            {
                try
                {
                    if (estado == 'G')
                    {
                        modelomodelos.AgregarModelo(nombre, tamanio, asientos, pisos);
                    }
                    else if (estado == 'E')
                    {
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                        modelomodelos.EditaModelo(id, nombre, tamanio, asientos, pisos);
                    }

                    txtnombre.Text = "";
                    txttamanio.Text = "";
                    nasiento.Value = 0;
                    npisos.Value = 0;

                    txtnombre.Enabled = false;
                    txttamanio.Enabled = false;
                    nasiento.Enabled = false;
                    npisos.Enabled = false;

                    MostrarTodosLosModelos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar o editar el modelo: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            estado = 'E';

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                Modelo modelo = TodosLosModelos.FirstOrDefault(l => l.ID == id);

                if (modelo != null)
                {
                    txtnombre.Text = modelo.Nombre;
                    txttamanio.Text = modelo.Tamaño;
                    nasiento.Value = modelo.Asientos;
                    npisos.Value = modelo.pisos;

                    txtnombre.Enabled = true;
                    txttamanio.Enabled = true;
                    nasiento.Enabled = true;
                    npisos.Enabled = true;
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
            txttamanio.Text = "";
            nasiento.Value = 0;
            npisos.Value = 0;

            txtnombre.Enabled = false;
            txttamanio.Enabled = false;
            nasiento.Enabled = false;
            npisos.Enabled = false;
        }

        private void TablaModelo_Load(object sender, EventArgs e)
        {

        }

        
    }
}
