using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using Objetos.Buses;

namespace sistema_de_viajes
{
    public partial class TablaBuses : Form
    {
        private ModelBus modelobus;
        private List<Buses> todosLosBuses;
        private string estado;
        public TablaBuses()
        {
            InitializeComponent();
            comboFiltrar.Items.AddRange(new string[] { "Seleccionar", "ID", "Placa", "Modelo", "Lugar" });
            comboModelo.Items.AddRange(new string[] { "0", "1", "2", "3", "4", "15" });
            comboFiltrar.SelectedIndex = 0;
            comboModelo.SelectedIndex = 0;
            modelobus = new ModelBus();
            Mostrarbuses();
            Desacampos();
        }

        
        //Eventos para las cajas de texto
        private void textPlaca_Enter(object sender, EventArgs e)
        {
            if (textPlaca.Text == "------") textPlaca.Text = "";
        }
        private void textPlaca_Leave(object sender, EventArgs e)
        {
            if (textPlaca.Text == "") textPlaca.Text = "------";
        }
        private void textLugar_Enter(object sender, EventArgs e)
        {
            if (textLugar.Text == "Lugar") textLugar.Text = "";
        }
        private void textLugar_Leave(object sender, EventArgs e)
        {
            if (textLugar.Text == "") textLugar.Text = "Lugar";
        }
       
       
        private void textFiltrar_Enter(object sender, EventArgs e)
        {
            if (textFiltrar.Text == "Buscar por filtro") textFiltrar.Text = "";
        }//termino de eventos 

        private void TablaBuses_Load(object sender, EventArgs e)
        {
            btnguardar.Enabled = false;
        }
        private void ClearTextBoxs()
        {
            textPlaca.Text = "Nro Placa";
            comboModelo.Text = "";
            textLugar.Text = "Lugar";

        }
        private void Mostrarbuses()
        {
            try
            {
                todosLosBuses = modelobus.MostrarTodosBuses();
                DvgDatos.DataSource = todosLosBuses;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar lugares: " + ex.Message);
            }
        }
        private void Desacampos()
        {
            textPlaca.Enabled=false;
            comboModelo.Enabled=false;
            textLugar.Enabled=false;
            dateDisponible.Enabled=false;
        }
        private void ActivarCampos()
        {
            textPlaca.Enabled = true;
            comboModelo.Enabled = true;
            textLugar.Enabled = true;
            dateDisponible.Enabled = true;
            
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string placa = textPlaca.Text;
            int modelo = Convert.ToInt32(comboModelo.Text);
            string lugar = textLugar.Text;
            DateTime disponibilidad = (DateTime)dateDisponible.Value;
            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(lugar))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            if (modelobus != null)
            {
                try
                {
                    if (estado == "G")
                    {
                        modelobus.AgregarBuss(placa, modelo, lugar, disponibilidad);
                        MessageBox.Show("Se añadió el lugar correctamente.");
                        btnanadir.Enabled = true;
                        btnguardar.Enabled = false;;
                    }
                    else if (estado == "E")
                    {
                        if (DvgDatos.SelectedRows.Count > 0)
                        {
                            int id = Convert.ToInt32(DvgDatos.SelectedRows[0].Cells["ID"].Value);
                            modelobus.EditarBuss(placa, modelo, lugar, disponibilidad);
                            MessageBox.Show("Se guardó la edición.");
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un lugar para editar.");
                            return;
                        }
                    }

                    Mostrarbuses();
                    ClearTextBoxs();
                    Desacampos();
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
    

        private void btnanadir_Click(object sender, EventArgs e)
        {
            textPlaca.Enabled = true;
            comboModelo.Enabled = true;
            textLugar.Enabled = true;
            dateDisponible.Enabled = true;
            btnanadir.Enabled= false;
            btnguardar.Enabled = true;
            estado = "G";

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            textPlaca.Text = "";
            comboModelo.SelectedIndex=0;
            textLugar.Text = "";
            

            textPlaca.Enabled = false;
            comboModelo.Enabled = false;
            textLugar.Enabled = false;
            dateDisponible.Enabled = false;
           
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
