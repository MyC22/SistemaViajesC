using Objetos;
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
using System.Windows.Forms.VisualStyles;
using static Objetos.Empleado;

namespace sistema_de_viajes
{
    public partial class TablaEmpleado : Form
    {
        public TablaEmpleado()
        {
            InitializeComponent();
        }
        public Boolean nuevo { get; set; }
        String estado;
        ModeloEmpleado me = new ModeloEmpleado();
        empleado em = new empleado();
        Usuario u = new Usuario();
        private void limpiar()
        {
            txtapellido.Clear();
            txtcontraseña.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
            cbcargo.SelectedIndex = -1;
            cbpermisos.SelectedIndex = -1;
            cbsexo.SelectedIndex = -1;
            numedad.TextAlign = 0;
        }
        private void datos()
        {
            em.nombre = txtnombre.Text;
            em.apellido = txtapellido.Text;
            em.edad = (int)numedad.Value;
            em.cargo = (int)cbcargo.SelectedValue;
            em.dni = txtdni.Text;
            em.sexo = cbsexo.SelectedIndex.ToString();
            u.usuario = txtusuario.Text;
            u.contraseña = txtcontraseña .Text;
            u.tipo = cbpermisos .Text;
        }
        private void TablaEmpleado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = me.listarEmpleado();
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            cbpermisos.Items.Add("Admin");
            cbpermisos.Items.Add("Usuario");
            cbsexo.Items.Add("Masculino");
            cbsexo.Items.Add("Femenino");
            cbcargo.DataSource = me.listarcargos();
            cbcargo.ValueMember = "ID";
            cbcargo.DisplayMember = "Cargo";
            cbcargo.SelectedIndex = -1;
            desactivartxt();
        }
        private void desactivartxt()
        {
            txtapellido.Enabled = false;
            txtcontraseña.Enabled = false;
            txtdni.Enabled = false;
            txtnombre.Enabled = false;
            txtusuario .Enabled = false;
            cbsexo .Enabled = false;
            cbcargo.Enabled = false;
            cbpermisos.Enabled = false;
            numedad .Enabled = false;
        }
        private void activartxt()
        {
            txtapellido.Enabled = true;
            txtcontraseña.Enabled = true;
            txtdni.Enabled = true;
            txtnombre.Enabled = true;
            txtusuario.Enabled = true;
            cbcargo .Enabled = true;
            cbpermisos  .Enabled = true;
            cbsexo .Enabled = true;
            numedad.Enabled = true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            estado = "g";
            btnGuardar.Enabled=true;
            activartxt();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            limpiar();
            desactivartxt();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (estado.Equals("g"))
            {
                datos();
                me.guardarEmpleado(em, u);
            }
        }
    }
}
