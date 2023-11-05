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
                if (me.Validar(u) != 0)
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
    }
}
