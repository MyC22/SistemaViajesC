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
using Objetos.Buses;

namespace sistema_de_viajes
{
    public partial class TablaBuses : Form
    {
        public TablaBuses()
        {
            InitializeComponent();
            comboFiltrar.Items.AddRange(new string[] { "Seleccionar", "ID", "Placa", "Modelo", "Lugar" });
            comboModelo.Items.AddRange(new string[] { "Seleccionar", "modelo1", "modelo2", "modelo3", "modelo4", "modelo15" });
            comboFiltrar.SelectedIndex = 0;
            comboModelo.SelectedIndex = 0;

            textPlaca.Enabled= false;
            comboModelo.Enabled= false;
            textLugar.Enabled= false;
            dateDisponible.Enabled= false;
            textAsientos.Enabled= false;
        }

        //Variables de instancia
        CBuss buss = new CBuss();
        Buses bus = new Buses();
        bool edit = false;

        //Eventos para las cajas de texto
        private void textPlaca_Enter(object sender, EventArgs e)
        {
            if (textPlaca.Text == "Nro Placa") textPlaca.Text = "";
        }

        private void textPlaca_Leave(object sender, EventArgs e)
        {
            if (textPlaca.Text == "") textPlaca.Text = "Nro Placa";
        }

        private void textLugar_Enter(object sender, EventArgs e)
        {
            if (textLugar.Text == "Lugar") textLugar.Text = "";
        }

        private void textLugar_Leave(object sender, EventArgs e)
        {
            if (textLugar.Text == "") textLugar.Text = "Lugar";
        }

        private void textAsientos_Enter(object sender, EventArgs e)
        {
            if (textAsientos.Text == "Nro Asientos") textAsientos.Text = "";
        }

        private void textAsientos_Leave(object sender, EventArgs e)
        {
            if (textAsientos.Text == "") textAsientos.Text = "Nro Asientos";

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
            dateDisponible.Text ="00/00/0000";
        }
        private void getdata()
        {
            CBuss bu = new CBuss();
            DvgDatos.DataSource = bu.MostrarBuss();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                try
                {
                    //Insertar
                    bus.Placa1 = Convert.ToInt32(textPlaca.Text);
                    bus.IdModelo = Convert.ToInt32(comboModelo.Text);
                    bus.Lugar1 = textLugar.Text;
                    bus.Disponibilidad1 = DateTime.ParseExact(dateDisponible.Text,
                        "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    buss.InsertarBuss(bus);
                    ClearTextBoxs();
                    getdata();
                    btnguardar.Enabled = false;
                    btnanadir.Enabled = true;
                    MessageBox.Show("SE GUARDO EL REGISTRO", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR{ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (edit)
            { 

                try
                {
                    bus.Placa1 = Convert.ToInt32(textPlaca.Text);
                    bus.IdModelo = Convert.ToInt32(comboModelo.Text);
                    bus.Lugar1 = textLugar.Text;
                    bus.Disponibilidad1 = DateTime.ParseExact(dateDisponible.Text,
                        "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    buss.Modificar(bus);
                    ClearTextBoxs();
                    getdata();
                    btnguardar.Enabled = false;
                    btnanadir.Enabled = true;
                    edit = false;
                    MessageBox.Show("SE ACTUALIZO EL REGISTRO", "ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR{ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnanadir_Click(object sender, EventArgs e)
        {
            textPlaca.Enabled = true;
            comboModelo.Enabled = true;
            textLugar.Enabled = true;
            dateDisponible.Enabled = true;
            textAsientos.Enabled = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (DvgDatos.SelectedRows.Count>0)
            {
                textPlaca.Enabled=false;
                btnanadir.Enabled=false;
                btnguardar.Enabled=true;
                edit= true;

                textPlaca.Text = DvgDatos.CurrentRow.Cells[0].Value.ToString();
                comboModelo.Text = DvgDatos.CurrentRow.Cells[1].Value.ToString();
                textLugar.Text = DvgDatos.CurrentRow.Cells[2].Value.ToString();
                textAsientos.Text= DvgDatos.CurrentRow.Cells[3].Value.ToString();
                dateDisponible.Text= DvgDatos.CurrentRow.Cells[4].Value.ToString();
            }
            
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            textPlaca.Text = "";
            comboModelo.SelectedIndex=0;
            textLugar.Text = "";
            textAsientos.Text = "";

            textPlaca.Enabled = false;
            comboModelo.Enabled = false;
            textLugar.Enabled = false;
            dateDisponible.Enabled = false;
            textAsientos.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
