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
            label12.Text = "";
            txtapellido.Clear();
            txtcontraseña.Clear();
            txtdni.Clear();
            txtnombre.Clear();
            txtusuario.Clear();
            cbcargo.SelectedIndex = -1;
            cbpermisos.SelectedIndex = -1;
            cbsexo.SelectedIndex = -1;
            numedad.Value = 0;
        }
        private Boolean validardatos()
        {
            if (txtapellido.Text != "" &&
                txtcontraseña.Text != "" &&
                txtdni.Text != "" &&
                txtnombre.Text != "" &&
                txtusuario.Text != "" &&
                cbcargo.SelectedValue != null &&
                cbpermisos.Text != "" &&
                cbsexo.SelectedIndex != null &&
                numedad.Value != null) { return true; }
            else return false;

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
            toolTip1.SetToolTip(btnañadir, "Añadir");
            toolTip1.SetToolTip(btneliminar, "Eliminar");
            toolTip1.SetToolTip(btncancelar, "Cancelar");
            toolTip1.SetToolTip(btnguardar, "Guardar");
            toolTip1.SetToolTip(btneditar, "Editar");
            label12.Text = "";
            dataGridView1.DataSource = me.listarEmpleado();
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
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
            limpiar();
            label12.Text = "Añadir";
            estado = "g";
            btnguardar.Enabled=true;
            activartxt();
            dataGridView1.Enabled = false;
            btneditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnadd.Enabled = true;
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(validardatos())
            {
                if (estado.Equals("e"))
                {
                    string dni = em.dni;
                    string usuario = u.usuario;
                    Boolean v1 = false;
                    Boolean v2 = false;
                    datos();
                    if (txtdni.Text != dni)
                        {
                        if (me.ValidarDni(em)) { MessageBox.Show("No se guardo, no se puede haber Dni de empleados iguales"); }
                        else { v1 = true; }
                    }
                    else { v1 = true; }
                    if (txtusuario.Text != usuario)
                    {
                        if (me.ValidarUser(u)) { MessageBox.Show("No se guardo, no se puede haber nombre de usuarios iguales"); }
                        else { v2 = true; }
                    }else { v2 = true; }
                    if (v1 && v2)
                    {
                        me.editarEmpleado(em, u);
                        limpiar();
                        desactivartxt();
                        dataGridView1.DataSource = me.listarEmpleado();
                        dataGridView1.Enabled = true;
                        btneditar.Enabled = false;
                        btnguardar.Enabled = false;
                        btnañadir.Enabled = true;
                        btneliminar.Enabled = false;
                        MessageBox.Show("se guardo");
                    }
                    
                }
                if (estado.Equals("g"))
                {
                    datos();
                    if (me.ValidarDni(em)) { MessageBox.Show("No se guardo, no se puede haber Dni de empleados iguales"); }
                    else if (me.ValidarUser(u)) { MessageBox.Show("No se guardo, no se puede haber nombre de usuarios iguales"); }
                    else
                    {
                        me.guardarEmpleado(em, u);
                        limpiar();
                        desactivartxt();
                        dataGridView1.DataSource = me.listarEmpleado();
                        btneditar.Enabled = false;
                        btnguardar.Enabled = false;
                        btnañadir.Enabled = true;
                        btneliminar.Enabled = false;
                        dataGridView1.Enabled = true;
                        MessageBox.Show("se guardo");
                    }
                }
            } else MessageBox.Show("No se guardo, faltan rellenar datos");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            em.id = id;
            label12.Text = "Descripcion";
            SqlDataReader dr= me.listarEmpleadoId(id);
            if (dr.Read())
            {
                txtapellido.Text = dr["Apellido"].ToString();
                txtcontraseña.Text = dr["Contrasena"].ToString();
                txtdni.Text = dr["Dni"].ToString();
                txtnombre.Text = dr["Nombres"].ToString();
                txtusuario.Text = dr["Usuario"].ToString();
                int idcargo = cbcargo.FindStringExact(dr["Cargo"].ToString());
                cbcargo.SelectedIndex = idcargo;
                int idtipo = cbpermisos.FindStringExact(dr["Tipocuenta"].ToString());
                cbpermisos.SelectedIndex = idtipo;
                cbsexo.SelectedIndex = Convert.ToInt32(dr["SexoEmpl"].ToString());
                numedad.Value = (int)dr["EdadEmpl"];
                btneditar.Enabled = true;
                btneliminar.Enabled = true;
            }
            datos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            label12.Text = "Editar";
            estado = "e";
            btnguardar.Enabled = true;
            activartxt();
            btnadd.Enabled = false;
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtfiltro.Text != "")
            { dataGridView1.DataSource = me.buscarEmpleado(cbfiltro.Text, txtfiltro.Text); }
            else dataGridView1.DataSource = me.listarEmpleado();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            me.eliminarEmpleado(em.id);
            limpiar();
            desactivartxt();
            dataGridView1.Enabled = true;
            btneditar.Enabled = false;
            btnguardar.Enabled = false;
            btnañadir.Enabled = true;
            MessageBox.Show("Se elimino con exito");
            cbcargo.DataSource = me.listarcargos();
        }
    }
}
