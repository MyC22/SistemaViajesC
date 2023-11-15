using Objetos;
using Objetos.Cronograma;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistema_de_viajes
{
    public partial class CrearBoleto : Form
    {
        string estado;
        int index;
        int asientos;
        double precio = 0;
        comprobante c = new comprobante();
        Servicios s = new Servicios();
        boletos b = new boletos();
        ModeloBoleto mb = new ModeloBoleto();
        modelocomprobante mc = new modelocomprobante();
        ModeloCronograma mcr = new ModeloCronograma();
        pasajero p = new pasajero();
        public CrearBoleto(int idservicio, int idcliente)
        {
            InitializeComponent();
            c.idcliente = idcliente;
            b.idservicio = idservicio;

        }

        private void CrearBoleto_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            SqlDataReader dr = mb.listarservicio(b.idservicio);
            if (dr.Read())
            {
                s.preciop1 = (float)dr["Precio_piso1"];
                s.preciop2 = (float)dr["Precio_piso2"];
            }
            cbpiso.SelectedIndex = -1;
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            desactivartxt();
            txttotal.Text = precio.ToString();
            int id = mcr.mostraridcronograma(b.idservicio);
            asientos = mcr.mostrarasientosdiponibles(id);
            txtasientos.Text = asientos.ToString();
        }
        private Boolean validar()
        {
            if(txtapellido.Text != "" &&
               txtnombre.Text != "" &&
               cbpiso.SelectedIndex != -1)
            {
                return true;
            }else return false;
        }
        private void desactivartxt()
        {
            txtapellido.Enabled = false;
            txtnombre.Enabled = false;
            cbpiso.Enabled = false;
        }
        private void activartxt()
        {
            txtapellido.Enabled = true;
            txtnombre.Enabled = true;
            cbpiso.Enabled = true;
        }
        private void limpiar()
        {
            txtapellido.Clear();
            txtnombre.Clear();
            cbpiso.SelectedIndex = -1;
            lprecio.Text = "Precio";
        }
        private void cancelar()
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            dataGridView1.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cancelar();
            limpiar();
            desactivartxt();
            index = -1;
        }

        private void btnañadir_Click(object sender, EventArgs e)
        {
            activartxt();
            limpiar();
            estado = "g";
            btnguardar.Enabled = true;
            activartxt();
            dataGridView1.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void cbpiso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbpiso.Text == "Piso 1")
            {
                lprecio.Text = s.preciop1.ToString();
            }
            if (cbpiso.Text == "Piso 2")
            {
                lprecio.Text = s.preciop2.ToString();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(validar())
            {
                if(estado=="g")
                { 
                    if(asientos != 0)
                    {
                        dataGridView1.Rows.Add(txtnombre.Text, txtapellido.Text , lprecio.Text);
                        precio = precio + double.Parse(lprecio.Text);
                        txttotal.Text = precio.ToString();
                        asientos = asientos - 1;
                        txtasientos.Text = asientos.ToString();
                    }else { MessageBox.Show("ya no se puede tener mas boleto, verifica la cantidad de asientos disponibles"); }
                }
                if(estado=="e")
                {
                    if (index != -1)
                    {
                        dataGridView1.Rows[index].Cells[0].Value = txtnombre.Text;
                        dataGridView1.Rows[index].Cells[1].Value = txtapellido.Text;
                        precio = precio - double.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString());
                        precio = precio + double.Parse(lprecio.Text);
                        txttotal.Text = precio.ToString();
                        dataGridView1.Rows[index].Cells[2].Value = lprecio.Text;
                    }
                }
                limpiar();
                desactivartxt();
                cancelar();
            }
            else { MessageBox.Show("Falta rellenar datos"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int filas = dataGridView1.Rows.Count;
            if(filas !=0)
            {
                double preciot = double.Parse(txttotal.Text);
                double precio = (preciot * 100) / 118;
                double igv = preciot - precio;
                c.igv = igv;
                c.precio = precio;
                c.precioT = preciot;
                c.tipocomporbante = "Factura";
                c.fecha = DateTime.Now;
                b.idfactura = mc.agregarfactura(c);
                for (int i = 0; i < filas; i++)
                {
                    p.nombre = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    p.apellidos = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    b.precio = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    b.idpasajero = mb.agregarpasajero(p);
                    mb.agregarboleto(b);
                }
                MessageBox.Show("Se a creado correctamente");
                    this.Close();
            }
            else { MessageBox.Show("primero debes crear boletos"); }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtapellido.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtnombre.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            lprecio.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            if (lprecio.Text == s.preciop1.ToString() )
            {
                cbpiso.SelectedIndex = 1;
            }
            else if (lprecio.Text == s.preciop2.ToString())
            {
                cbpiso.SelectedIndex = 0;
            }
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            estado = "e";
            btnguardar.Enabled = true;
            activartxt();
            btnañadir.Enabled = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(index != -1)
            {
                precio = precio - double.Parse(dataGridView1.Rows[index].Cells[2].Value.ToString());
                txttotal.Text = precio.ToString();
                dataGridView1.Rows.RemoveAt(index);
                asientos = asientos + 1;
                txtasientos.Text = asientos.ToString();
                limpiar();
                cancelar();
                index = -1;
            }
        }
    }
}
