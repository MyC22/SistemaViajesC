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

        public TablaModelo()
        {
            InitializeComponent();
            modelomodelos = new Modelomodelo();

            cbofiltrar.Items.AddRange(new string[] { "Seleccionar", "ID", "Nombre", "Tamaño", "Asientos" });
            cbofiltrar.SelectedIndex = 0;

            txtnombre.Enabled = false;
            txtasientos.Enabled = false;
            txttamanio.Enabled = false;

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
            string filtroSeleccionado = cbofiltrar.SelectedItem.ToString();
            string valorFiltro = txtfiltrar.Text;

            if (filtroSeleccionado == "Seleccionar")
            {
                MessageBox.Show("Por favor, seleccione un filtro válido antes de buscar.");
                return;
            }

            try
            {
                if (txtfiltrar.Enabled)
                {
                    List<Modelo> ModelosEncontrados = TodosLosModelos
                        .Where(Modelo =>
                        (filtroSeleccionado == "ID" && valorFiltro != "" && Modelo.ID.ToString().Equals(valorFiltro, StringComparison.OrdinalIgnoreCase)) ||
                        (filtroSeleccionado == "Nombre" && valorFiltro != "" && Modelo.Nombre.Equals(valorFiltro, StringComparison.OrdinalIgnoreCase)) ||
                        (filtroSeleccionado == "Tamaño" && valorFiltro != "" && Modelo.Equals(valorFiltro, StringComparison.OrdinalIgnoreCase)))
                        .ToList();

                    dataGridView1.DataSource = ModelosEncontrados;
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

        private void cbofiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = cbofiltrar.SelectedItem.ToString();
            txtfiltrar.Enabled = (filtroSeleccionado != "Seleccionar");
            btnbuscarmodelo.Enabled = txtfiltrar.Enabled;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {

            txtnombre.Enabled = true;
            txtasientos.Enabled = true;
            txttamanio.Enabled = true;

            txtnombre.Text = "";
            txtasientos.Text = "";
            txttamanio.Text = "";
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
                        modelomodelos.EliminarLugar(id);

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

        private void TablaModelo_Load(object sender, EventArgs e)
        {

        }

        
    }
}
