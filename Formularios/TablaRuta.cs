using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Formularios
{
    public partial class TablaRuta : Form
    {
        ModeloRuta modeloRuta = new ModeloRuta();
        Rutas r = new Rutas();
        List<Rutas> todasLasRutas = new List<Rutas>();
        string estado;
        private void TablaRuta_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            cbDestino.DataSource = modeloRuta.listarlugar();
            cborigen.DataSource = modeloRuta.listarlugar();
            desactivartxt();
            cbDestino.ValueMember = "ID";
            cbDestino.DisplayMember = "Departamento";
            cborigen.ValueMember = "ID";
            cborigen.DisplayMember = "Departamento";
            cborigen.SelectedIndex = -1;
            cbDestino.SelectedIndex = -1;
            MostrarTodasLasRutas();

        }
        public TablaRuta()
        {
            InitializeComponent();
        }
        public Boolean validar()
        {
            if(cbDestino.SelectedIndex < 0 &&
                cborigen.SelectedIndex < 0&&
                txtnombre.Text == "")
            {
                return false;
            }else return true;
        }
        private void MostrarTodasLasRutas()
        {
            try
            {
                todasLasRutas = modeloRuta.MostrarRutas();
                dataGridView1.DataSource = todasLasRutas;
                dataGridView1.Columns["IDOrigen"].Visible = false;
                dataGridView1.Columns["IDDestino"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar rutas: " + ex.Message);
            }
        }
        private void limpiar()
        {
            txtnombre.Clear();
            cborigen.SelectedIndex = -1;
            cbDestino.SelectedIndex = -1;
            maskedTxtDemora.Clear();
        }
        private void datos()
        {
            r.Nombre = txtnombre.Text;
            r.IDDestino = (int)cbDestino.SelectedValue;
            r.IDOrigen = (int)cborigen.SelectedValue;
            r.Demora = TimeSpan.Parse(maskedTxtDemora.Text);
        }
        private void desactivartxt()
        {
            txtnombre.Enabled = false;
            cborigen.Enabled = false;
            cbDestino.Enabled = false;
            maskedTxtDemora.Enabled = false;
        }
        private void activartxt()
        {
            txtnombre.Enabled = true;
            cborigen.Enabled = true;
            cbDestino.Enabled = true;
            maskedTxtDemora.Enabled = true;
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (txtnombreB.Text != "" || txtorigenB.Text != "" || txtDestinoB.Text != "")
            {
                string nombre = txtnombreB.Text;
                string destino = txtDestinoB.Text;
                string origen = txtorigenB.Text;
                List<Rutas> resultadosBusqueda = todasLasRutas
                    .Where(c =>
                        (string.IsNullOrEmpty(nombre) || c.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(origen) || c.Origen.IndexOf(origen, StringComparison.OrdinalIgnoreCase) >= 0) &&
                        (string.IsNullOrEmpty(destino) || c.Destino.IndexOf(destino, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();
                dataGridView1.DataSource = resultadosBusqueda;
            }
            else
            {
                MostrarTodasLasRutas();
            }
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            limpiar();
            estado = "g";
            btnguardar.Enabled = true;
            activartxt();
            dataGridView1.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            modeloRuta.EliminarRutaPorID(r.ID);
            MostrarTodasLasRutas();
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            MessageBox.Show("Se elimino con exito");
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                if (!TimeSpan.TryParse(maskedTxtDemora.Text, out TimeSpan demora))
                {
                    MessageBox.Show("El formato de tiempo para Demora es incorrecto.");
                }
                else
                {
                    if (estado == "g")
                    {

                        datos();
                        try
                        {
                            if (r.IDDestino != r.IDOrigen)
                            {
                                modeloRuta.AgregarRuta(r);
                                dataGridView1.Enabled = true;
                                btneditar.Enabled = false;
                                btnguardar.Enabled = false;
                                btnañadir.Enabled = true;
                                btneliminar.Enabled = false;
                                limpiar();
                                desactivartxt();
                                MostrarTodasLasRutas();
                            }
                            else { MessageBox.Show("no se guardo, no puedes asignar destino y origen del mismo lugar"); }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar la ruta: " + ex.Message);
                        }
                    }
                    if (estado == "e")
                    {
                        datos();
                        if (r.IDDestino != r.IDOrigen)
                        {
                            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                            modeloRuta.EditarRuta(r);
                            limpiar();
                            desactivartxt();
                            MostrarTodasLasRutas();
                            dataGridView1.Enabled = true;
                            btneditar.Enabled = false;
                            btnguardar.Enabled = false;
                            btnañadir.Enabled = true;
                            btneliminar.Enabled = false;
                            MessageBox.Show("se guardo");
                        }
                        else { MessageBox.Show("no se edito, no puedes asignar destino y origen del mismo lugar"); }
                    }

                }
            }else { MessageBox.Show("Falta rellenar datos"); }
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            estado = "e";
            btnguardar.Enabled = true;
            activartxt();
            btnañadir.Enabled = false;
        }
        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;
            MostrarTodasLasRutas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            r.ID = id;
            SqlDataReader dr = modeloRuta.listarRutaID(id);
            if (dr.Read())
            {
                txtnombre.Text = dr["Nombre"].ToString();
                maskedTxtDemora.Text = dr["Demora"].ToString();
                cbDestino.SelectedValue = (int)dr["IDDestino"];
                cborigen.SelectedValue = (int)dr["IDOrigen"];
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
            }
            datos();
        }

    }
}