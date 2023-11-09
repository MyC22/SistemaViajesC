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

namespace Formularios
{
    public partial class TablaRuta : Form
    {
        private ModeloRuta modeloRuta;
        private List<Rutas> todasLasRutas;

        public TablaRuta()
        {
            InitializeComponent();
            modeloRuta = new ModeloRuta();
            MostrarTodasLasRutas();

            cbfiltro.Items.AddRange(new string[] { "Seleccionar", "ID", "Nombre" });
            cbfiltro.SelectedIndex = 0;

            txtnombre.Enabled = false;
            cborigen.Enabled = false;
            cbDestino.Enabled = false;
            maskedTxtDemora.Enabled = false;
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string filtroSeleccionado = cbfiltro.SelectedItem.ToString();
            string valorFiltro = txtfiltro.Text;

            if (filtroSeleccionado == "Seleccionar")
            {
                MessageBox.Show("Por favor, seleccione un filtro válido antes de buscar.");
                return;
            }

            try
            {
                if (txtfiltro.Enabled)
                {
                    List<Rutas> rutasEncontradas = modeloRuta.BuscarRuta(filtroSeleccionado == "ID" ? Convert.ToInt32(valorFiltro) : 0, filtroSeleccionado == "Nombre" ? valorFiltro : "");

                    dataGridView1.DataSource = rutasEncontradas;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un filtro válido antes de buscar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar rutas: " + ex.Message);
            }
        }

        private void cbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroSeleccionado = cbfiltro.SelectedItem.ToString();

            txtfiltro.Enabled = (filtroSeleccionado != "Seleccionar");
            btbuscar.Enabled = txtfiltro.Enabled;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            cborigen.Enabled = true;
            cbDestino.Enabled = true;
            maskedTxtDemora.Enabled = true;

            txtnombre.Text = "";
            cborigen.DataSource = GetAllLugares();
            cborigen.DisplayMember = "Distrito";
            cborigen.ValueMember = "ID";
            cbDestino.DataSource = GetAllLugares();
            cbDestino.DisplayMember = "Distrito";
            cbDestino.ValueMember = "ID";
            maskedTxtDemora.Text = "";
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (modeloRuta != null)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    try
                    {
                        modeloRuta.EliminarRutaPorID(id);

                        MostrarTodasLasRutas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la ruta: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una ruta para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (modeloRuta != null)
            {
                int idOrigen, idDestino;
                if (!int.TryParse(cborigen.SelectedValue.ToString(), out idOrigen) || !int.TryParse(cbDestino.SelectedValue.ToString(), out idDestino))
                {
                    MessageBox.Show("IDOrigen y IDDestino deben ser números enteros.");
                    return;
                }

                if (!TimeSpan.TryParse(maskedTxtDemora.Text, out TimeSpan demora))
                {
                    MessageBox.Show("El formato de tiempo para Demora es incorrecto.");
                    return;
                }

                string nombre = txtnombre.Text;

                try
                {
                    modeloRuta.AgregarRuta(idOrigen, idDestino, nombre, demora);

                    txtnombre.Text = "";
                    cborigen.DataSource = GetAllLugares();
                    cborigen.DisplayMember = "Distrito";
                    cborigen.ValueMember = "ID";
                    cbDestino.DataSource = GetAllLugares();
                    cbDestino.DisplayMember = "Distrito";
                    cbDestino.ValueMember = "ID";
                    maskedTxtDemora.Text = "";

                    txtnombre.Enabled = false;
                    cborigen.Enabled = false;
                    cbDestino.Enabled = false;
                    maskedTxtDemora.Enabled = false;

                    MostrarTodasLasRutas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la ruta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se ha inicializado la propiedad ConnectionString. Verifica la cadena de conexión.");
            }
        }


        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                Rutas ruta = todasLasRutas.FirstOrDefault(r => r.ID == id);

                if (ruta != null)
                {
                    txtnombre.Text = ruta.Nombre;
                    cborigen.SelectedValue = ruta.IDOrigen;
                    cbDestino.SelectedValue = ruta.IDDestino;
                    maskedTxtDemora.Text = ruta.Demora.ToString();

                    txtnombre.Enabled = true;
                    cborigen.Enabled = true;
                    cbDestino.Enabled = true;
                    maskedTxtDemora.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una ruta para editar.");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            cborigen.Text = "";
            cbDestino.Text = "";
            maskedTxtDemora.Text = "";

            txtnombre.Enabled = false;
            cborigen.Enabled = false;
            cbDestino.Enabled = false;
            maskedTxtDemora.Enabled = false;
        }

        private List<Lugarr> GetAllLugares()
        {
            Conexion conexion = new Conexion();
            using (SqlConnection connection = conexion.Open())
            {
                using (SqlCommand command = new SqlCommand("MostrarTodosLosLugares", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    List<Lugarr> lugares = new List<Lugarr>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lugarr lugar = new Lugarr
                            {
                                ID = (int)reader["ID"],
                                Distrito = reader["Distrito"].ToString()
                            };
                            lugares.Add(lugar);
                        }
                    }

                    return lugares;
                }
            }
        }
    }
}