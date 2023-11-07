using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Objetos.Empleado;

namespace sistema_de_viajes
{
    public partial class TablaCliente : Form
    {
        List<ClienteListaPersona> clp = new List<ClienteListaPersona>();
        List<ClienteListaEmpresa> cle = new List<ClienteListaEmpresa>();
        ModeloCliente mc = new ModeloCliente();
        Cliente c = new Cliente();
        ClienteEmpresa ce   = new ClienteEmpresa();
        ClientePersona cpe = new ClientePersona();
        string rdseleccionado = "Persona";
        string estado;
        public TablaCliente()
        {
            InitializeComponent();
        }

        private void SeleecionarCliente_Load(object sender, EventArgs e)
        {
            clp = mc.MostrarClientePersona();
            dataGridView1.DataSource = clp;
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            desactivartxt();
            lruc.Visible = false;
            ldireccion.Visible = false;
            txtruc.Visible = false;
            txtdireccion.Visible = false;
            rdpersona.Checked = true;
            radioButton1.Checked = true;

        }
        private void limpiar()
        {
            txtapellido.Clear();
            txtcelular.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtcorreo.Clear();
            txtruc.Clear();
            dtnacimiento.ResetText();
            txtdireccion.Clear();
            rdpersona.Checked = true;
            rdempresa.Checked = false;
        }
        private void desactivartxt()
        {
            txtapellido.Enabled = false;
            txtcelular.Enabled = false;
            txtdni.Enabled = false;
            txtnombre.Enabled = false;
            txtcorreo.Enabled = false;
            txtruc.Enabled = false;
            txtdireccion.Enabled = false;
            rdpersona.Enabled = false;
            rdempresa.Enabled = false;
            dtnacimiento.Enabled = false;
        }
        private void activartxt()
        {
            txtapellido.Enabled = true;
            txtcelular.Enabled = true;
            txtdni.Enabled = true;
            txtnombre.Enabled = true;
            txtcorreo.Enabled = true;
            txtruc.Enabled = true;
            txtdireccion.Enabled = true;
            rdpersona.Enabled = true;
            rdempresa.Enabled = true;
            dtnacimiento.Enabled = true;
        }
        private Boolean validarDatos()
        {
            if(rdpersona.Checked) 
            {
                if(txtnombre.Text !="" &&
                   txtapellido.Text !="" &&
                   txtdni.Text !="" &&
                   txtcelular.Text !=""&&
                   txtcorreo.Text !="") { return true; } else { return false; }
            }else if(rdempresa.Checked){
                if(txtnombre.Text !=""&&
                    txtruc.Text !=""&&
                    txtdireccion.Text !=""&&
                    txtcelular.Text != "" &&
                   txtcorreo.Text != "") { return true; } else { return false; }
            }else return false;
        }
        private void datos()
        {
            c.Celular = Convert.ToInt32(txtcelular.Text);
            c.Correo = txtcorreo.Text;
            c.Apellido = txtapellido.Text;
            c.DNI = txtdni.Text;
            c.Nombres = txtnombre.Text;
            c.Nacimiento = dtnacimiento.Value;
            c.Ruc = txtruc.Text;
            c.Direccion = txtdireccion.Text;
            c.Tipo = rdseleccionado;
        }
        private void datospersona()
        {
            cpe.Celular = Convert.ToInt32(txtcelular.Text);
            cpe.Correo = txtcorreo.Text;
            cpe.Apellido = txtapellido.Text;
            cpe.DNI = txtdni.Text;
            cpe.Nombres = txtnombre.Text;
            cpe.Nacimiento = dtnacimiento.Value;
            cpe.Tipo = rdseleccionado;
        }
        private void datosempresa()
        {
            ce.Celular = Convert.ToInt32(txtcelular.Text);
            ce.Correo = txtcorreo.Text;
            ce.Ruc = txtruc.Text;
            ce.Nombres = txtnombre.Text;
            ce.Direccion = txtdireccion.Text;
            ce.Tipo = rdseleccionado;
        }

        private void rdpersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rdpersona.Checked) 
            { 
                rdseleccionado = rdpersona.Text;
                lruc.Visible = false;
                ldireccion.Visible = false;
                txtruc.Visible = false;
                txtdireccion.Visible = false;

                lnacimiento.Visible = true;
                dtnacimiento.Visible = true;
                txtdni.Visible = true;
                ldni.Visible = true;
                lapellido.Visible = true;
                txtapellido.Visible = true;
            }
        }

        private void rdempresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdempresa.Checked) 
            { 
                rdseleccionado = rdempresa.Text;
                lruc.Visible = true;
                ldireccion.Visible = true;
                txtruc.Visible = true;
                txtdireccion.Visible = true;

                lnacimiento.Visible = false;
                dtnacimiento.Visible = false;
                txtdni.Visible = false;
                ldni.Visible = false;
                lapellido.Visible = false;
                txtapellido.Visible = false;
            }
        }
        private void cancelar()
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            dataGridView1.Enabled = true;
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            btneliminar.Enabled = false;
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                LdniB.Visible = true;
                txtdniB.Visible = true;
                lrucB.Visible = false;
                txtrucB.Visible = false;

                clp = mc.MostrarClientePersona();
                dataGridView1.DataSource = clp;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                LdniB.Visible = false;
                txtdniB.Visible = false;

                lrucB.Visible = true;
                txtrucB.Visible = true;

                cle = mc.MostrarClienteEmpresa();
                dataGridView1.DataSource = cle;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (estado.Equals("e"))
                {
                    Boolean validar = false;
                    if (rdpersona.Checked)
                    {
                        string dni = c.DNI;
                        datospersona();
                        if(dni != c.DNI){ if (mc.ValidarDni(cpe)) { MessageBox.Show("No se edito, no se puede haber Dni de cliente iguales"); } else { validar = true; } } else { validar = true; }
                    }
                    else if (rdempresa.Checked)
                    {
                        string ruc = c.Ruc;
                        datosempresa();
                        if(ruc != c.Ruc){if (mc.ValidarRuc(ce)) { MessageBox.Show("No se edito, no se puede haber ruc de cliente iguales"); } else {validar = true;}}else { validar = true; }
                    }
                    if (validar)
                    {
                        datos();
                        mc.editarCliente(c);
                        limpiar();
                        desactivartxt();
                        if (radioButton1.Checked) { 
                            clp = mc.MostrarClientePersona(); 
                            dataGridView1.DataSource = clp;
                        }
                        if (radioButton2.Checked) { 
                            cle = mc.MostrarClienteEmpresa();
                            dataGridView1.DataSource = cle;
                        }
                        cancelar();
                        MessageBox.Show("se edito");
                    }
                }
                if (estado.Equals("g"))
                {
                    if(rdpersona.Checked)
                    {
                        datospersona();
                        if (mc.ValidarDni(cpe)) { MessageBox.Show("No se guardo, no se puede haber Dni de cliente iguales"); }
                        else
                        {
                            mc.guardarPersona(cpe);
                            limpiar();
                            desactivartxt();
                            clp = mc.MostrarClientePersona();
                            dataGridView1.DataSource = clp;
                            cancelar();
                            MessageBox.Show("se guardo");
                        }
                    }
                    if(rdempresa.Checked)
                    {
                        datosempresa();
                        if (mc.ValidarRuc(ce)) { MessageBox.Show("No se guardo, no se puede haber ruc de cliente iguales"); }
                        else
                        {
                            mc.guardarEmpresa(ce);
                            limpiar();
                            desactivartxt();
                            cle = mc.MostrarClienteEmpresa();
                            dataGridView1.DataSource = cle;
                            cancelar();
                            MessageBox.Show("se guardo");
                        }
                    }
                }
            }else MessageBox.Show("No se guardo, faltan rellenar datos");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            c.ID = id;
            SqlDataReader dr = mc.listarClienteID(id);
            if (dr.Read())
            {
                txtnombre.Text = dr["Nombres"].ToString();
                txtapellido.Text = dr["Apellido"].ToString();
                txtruc.Text = dr["Ruc"].ToString();
                txtdni.Text = dr["DNI"].ToString();
                txtdireccion.Text = dr["Direccion"].ToString();
                txtcelular.Text = dr["Celular"].ToString();
                txtcorreo.Text = dr["Correo"].ToString();
                if (dr["Tipo"].ToString().Equals(rdpersona.Text))
                {
                    rdpersona.Checked = true;
                    rdempresa.Checked = false;
                    dtnacimiento.Value = (DateTime)dr["nacimiento"];
                }
                if (dr["Tipo"].ToString().Equals(rdempresa.Text))
                {
                    rdpersona.Checked = false;
                    rdempresa.Checked = true;
                }
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
            }
            datos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            mc.eliminarcliente(c.ID);
            if (rdpersona.Checked) { dataGridView1.DataSource = mc.MostrarClientePersona(); }
            if (rdempresa.Checked) { dataGridView1.DataSource = mc.MostrarClienteEmpresa(); }
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            MessageBox.Show("Se elimino con exito");
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            estado = "e";
            btnguardar.Enabled = true;
            activartxt();
            btnañadir.Enabled = false;
        }

    }
}

