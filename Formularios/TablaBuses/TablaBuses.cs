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
using Objetos.Modelo;

namespace sistema_de_viajes
{
    public partial class TablaBuses : Form
    {
        private ModelBus modelobus;
        // Modelomodelo mm = new Modelomodelo();
        private List<Buses> todosLosBuses;
        private string estado;
        public TablaBuses()
        {
            InitializeComponent();
            comboFiltrar.Items.AddRange(new string[] { "Seleccionar", "Placa", "IdModelo", "Lugar", "Disponibilidad" });
            comboModelo.Items.AddRange(new String[] { "1", "2" });
            //comboModelo.DataSource = mm.MostrarTodosLosModelos();
            //comboModelo.ValueMember = "ID";
            //comboModelo.DisplayMember = "Nombre";
            comboFiltrar.SelectedIndex = 0;
            comboModelo.SelectedIndex = 0;
            modelobus = new ModelBus();
            Mostrarbuses();
            Desacampos();
            btncancelar.Enabled = false;
        }


        //Eventos para las cajas de texto




        //El evento Enter nos dice si al momento de hacer click en el cuadro textLugar
        //tiene de contenido "Lugar" esta al hacer click se eliminara
        //y sera reemplazado por el nuevo valor que es el contenido vacio
        private void textLugar_Enter(object sender, EventArgs e)
        {
            if (textLugar.Text == "Lugar") textLugar.Text = "";
        }
        //El evento Leave nos dice que al dejar de hacer click en el cuadro textLugar
        //este se comparara si esta vacio, si esta vacio se le agregar Lugar
        // *En el caso de agregar valores este se mantendra sin molestar al usuario dejandolo vacio *
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

            textPlaca.Text = "Placa";
            textLugar.Text = "Lugar";

        }

        //Esta funcion nos ayuda a mostrar buses, tiene un try y catch
        //por si sucede un error este no moleste al usuario
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
        //Funcion desaccampos
        //Esta funcion al ser llamada desactiva ciertos campos
        private void Desacampos()
        {
            textPlaca.Enabled = false;
            comboModelo.Enabled = false;
            textLugar.Enabled = false;
            dateDisponible.Enabled = false;

        }
        //Funcion ActivarCampos
        //Esta funcion al ser llamada activa ciertos campos
        private void ActivarCampos()
        {

            comboModelo.Enabled = true;
            textLugar.Enabled = true;
            dateDisponible.Enabled = true;

        }
        private void iniciboton() 
        {
            btnanadir.Enabled = true;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnguardar.Enabled = false;
            btncancelar.Enabled = false;
        }


        //Boton guardar, este al hacer click toma como valor de las cajas de texto y
        //Las almacena en diferentes variables
        //este nos indica si uno o otro esta vacio para realizar la accion de editar o añadir
        // si el estado es igual a "G" este se guardara, si es igual a "E" este se editara
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string placa = textPlaca.Text;
            int modelo = Convert.ToInt32(comboModelo.Text);
            //int modelo = (int)comboModelo.SelectedValue;
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
                    }
                    else if (estado == "E")
                    {
                        if (DvgDatos.SelectedRows.Count > 0)
                        {
                            //String placas = (DvgDatos.SelectedRows[0].Cells["Placa"].Value).ToString();
                            modelobus.EditarBuss(placa, modelo, lugar, disponibilidad);
                            MessageBox.Show("Se guardó la edición.");
                            
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un lugar para editar.");
                            return;
                        }
                    }
                    iniciboton();
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

        //Boton añadir, este boton nos ayuda a activar los cuadros de texto y botones para realizar la accion de añadir
        //da como valor a estado la "G" para que haga su funcion al momento de guardar
        private void btnanadir_Click(object sender, EventArgs e)
        {
            ActivarCampos();
            textPlaca.Enabled = true;
            btnanadir.Enabled = false;
            btnguardar.Enabled = true;
            btneditar.Enabled = false;
            btncancelar.Enabled = true;
            btneliminar.Enabled = false;
            estado = "G";

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (DvgDatos.SelectedRows.Count > 0)
            {
                string placa = (DvgDatos.SelectedRows[0].Cells["Placa"].Value).ToString();

                Buses bus = todosLosBuses.FirstOrDefault(b => b.Placa == placa);

                if (bus != null)
                {
                    estado = "E";
                    ActivarCampos();

                    textPlaca.Text = bus.Placa.ToString();
                    comboModelo.Text = bus.IdModelo.ToString();
                    textLugar.Text = bus.Lugar;
                    dateDisponible.Value = Convert.ToDateTime(bus.Disponibilidad);

                    textPlaca.Enabled = false;
                    btnanadir.Enabled = false;
                    btnBuscar.Enabled = false;
                    btneditar.Enabled = false;
                    btnguardar.Enabled = true;
                    btneliminar.Enabled = false;
                    btncancelar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un lugar para editar.");
            }

        }


        private void btncancelar_Click(object sender, EventArgs e)
        {

            ClearTextBoxs();
            comboModelo.SelectedIndex = 0;



            Desacampos();

            btnguardar.Enabled = false;
            btnanadir.Enabled = true;
            btncancelar.Enabled = false;
            btneditar.Enabled = true;
            btneliminar.Enabled = true;

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (modelobus != null)
            {
                if (DvgDatos.SelectedRows.Count > 0)
                {
                    string id = (DvgDatos.SelectedRows[0].Cells["Placa"].Value).ToString();

                    try
                    {
                        modelobus.EliminarBuss(id);

                        Mostrarbuses();
                        ClearTextBoxs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el Buss: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un Buss para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        private void textPlaca_TextChanged(object sender, EventArgs e)
        {
            int limiteCaracteres = 7;

            if (textPlaca.Text.Length > limiteCaracteres)
            {
                // Si la longitud excede el límite, truncar el texto o mostrar un mensaje al usuario.
                textPlaca.Text = textPlaca.Text.Substring(0, limiteCaracteres);
                MessageBox.Show("Usted supero el limite de caracteres.");
            }
        }

        private void textPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 46 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 255)) //|| (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se permite ese tipo de caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textPlaca_Enter_1(object sender, EventArgs e)
        {
            if (textPlaca.Text == "Placa") textPlaca.Text = "";
        }

        private void textPlaca_Leave_1(object sender, EventArgs e)
        {
            if (textPlaca.Text == "") textPlaca.Text = "Placa";
        }
    }
}
