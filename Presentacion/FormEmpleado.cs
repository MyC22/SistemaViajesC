using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Empleado.Atributos;
//using Dominio.Crud;

namespace Presentacion
{
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //CPersona persona = new CPersona();
        //Empleados attributes = new Empleados();
        bool edit = false;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void getData()
        {
            //CPersona cPersona = new CPersona();
            //dvgDatos.DataSource = cPersona.Mostrar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbGenero.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            getData();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre") txtNombre.Text = "";
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") txtNombre.Text = "Nombre";
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido") txtApellido.Text = "";
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "") txtApellido.Text = "Apellido";
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID") txtID.Text = "";
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "") txtID.Text = "ID";
        }

        private void ClearTextBox()
        {
            txtID.Text = "ID";
            txtApellido.Text = "Apellido";
            txtNombre.Text = "Nombre";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                /*try 
                {
                    attributes.ID = Convert.ToInt32(txtID.Text);
                    attributes.Nombre = txtNombre.Text;
                    attributes.Apellido = txtApellido.Text;
                    attributes.Sexo = cbGenero.Text;
                    persona.Insertar(attributes);
                    ClearTextBox();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    MessageBox.Show("SE GUARDÓ CORRECTAMENTE", "INSERTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO UN ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

            }else if(edit == true)
            {
                //ACTUALIZAR
                /*try
                {
                    attributes.ID = Convert.ToInt32(txtID.Text);
                    attributes.Nombre = txtNombre.Text;
                    attributes.Apellido = txtApellido.Text;
                    attributes.Sexo = cbGenero.Text;
                    persona.Modificar(attributes);
                    ClearTextBox();
                    getData();
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    txtID.Enabled = true;
                    edit = false;
                    MessageBox.Show("SE ACTUALIZÓ UN REGISTRO DE FORMA EXITOSA", "MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dvgDatos.SelectedRows.Count > 0)
            {
                txtID.Enabled = false;
                btnNuevo.Enabled = false;
                btnGuardar.Enabled = true;
                edit = true;
                //CARGAR DATOS
                txtID.Text = dvgDatos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dvgDatos.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dvgDatos.CurrentRow.Cells[2].Value.ToString();
                cbGenero.Text = dvgDatos.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if(txtBuscar.Text == "Buscar...") txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar...";
                getData();
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*if (dvgDatos.SelectedRows.Count > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("¿DESEAS ELIMINAR ESTE REGISTRO?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        attributes.ID = Convert.ToInt32(dvgDatos.CurrentRow.Cells[0].Value.ToString());
                        persona.Eliminar(attributes);
                        getData();
                        MessageBox.Show("REGISTRO ELIMINADO CORRECTAMENTE", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"SE PRODUJO EL SIGUIENTE ERROR: {ex.ToString()}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }
        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //CPersona cPersona = new CPersona();
            //dvgDatos.DataSource = cPersona.Buscar(txtBuscar.Text);
        }
    }
}
