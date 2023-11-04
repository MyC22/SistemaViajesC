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
        private bool usuarioHaIniciadoSesion = false;

        public Iniciarsecion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (me.leerUsuario().HasRows == false && !usuarioHaIniciadoSesion)
            {
                MessageBox.Show("Bienvenido, Inicie seccion para entrar al programa");
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
                if (me.Validar(u) != 0)
                {
                    Menuprincipal menu = new Menuprincipal(me.Validar(u));
                    menu.Show();
                    this.Hide();
                    usuarioHaIniciadoSesion = true;
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
    }
}
