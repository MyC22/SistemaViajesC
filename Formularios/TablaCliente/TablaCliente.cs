using Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ce.Ruc = (int)Convert.ToInt64(txtruc.Text);
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
    }
}

