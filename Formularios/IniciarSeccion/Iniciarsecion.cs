using Formularios;
using Objetos;
using System;
using System.Windows.Forms;
using static Objetos.Empleado;

namespace sistema_de_viajes
{
    public partial class Iniciarsecion : Form
    {
        private ModeloEmpleado me = new ModeloEmpleado();
        private Usuario u = new Usuario();

        public Iniciarsecion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (me.leerUsuario().HasRows == false)
            {
                TablaEmpleado te = new TablaEmpleado();
                te.Show();
                MessageBox.Show("Bienvenido, registre su cuenta primero para crear su usuario e iniciar seccion");
            }
        }

        private void leer()
        {
            u.usuario = txtusuario.Text;
            u.contraseña = txtcontraseña.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leer();
            if (me.ValidarUser(u))
            {
                if (me.Validar(u) != "")
                {
                    Menuprincipal menu = new Menuprincipal(me.Validar(u));
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error en la contraseña");
                }
            }
            else
            {
                MessageBox.Show("Error en el usuario");
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            int limiteCaracteres = 50;

            if (txtusuario.Text.Length > limiteCaracteres)
            {
                // Si la longitud excede el límite, truncar el texto o mostrar un mensaje al usuario.
                txtusuario.Text = txtusuario.Text.Substring(0, limiteCaracteres);
                MessageBox.Show("Usted supero el limite de caracteres.");
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))             {
                MessageBox.Show("No se permite ese tipo de caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            int limiteCaracteres = 50;

            if (txtusuario.Text.Length > limiteCaracteres)
            {
                // Si la longitud excede el límite, truncar el texto o mostrar un mensaje al usuario.
                txtusuario.Text = txtusuario.Text.Substring(0, limiteCaracteres);
                MessageBox.Show("Usted supero el limite de caracteres.");
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se permite ese tipo de caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
