using Formularios;
using Objetos;
using System;
using System.Windows.Forms;
using static Objetos.Empleado;

namespace sistema_de_viajes
{
    public partial class Iniciarsecion : Form
    {
        public Iniciarsecion()
        {
            InitializeComponent();  
        }
        ModeloEmpleado me = new ModeloEmpleado();
        Usuario u = new Usuario();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (me.leerUsuario().HasRows == false)
            {
                this.Hide();
                TablaEmpleado te = new TablaEmpleado();
                te.Show();
                te.nuevo = true;
                MessageBox.Show("Bienvenido, create tu nuevo usuario como empleado");
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
                if (me.Validar(u))
                {
                    Menuprincipal menu = new Menuprincipal();
                    menu.Show();
                    this.Hide();
                }
                else MessageBox.Show("Error en la contraseña");
            }
            else MessageBox.Show("Error en el usuario");
        }
    }
}
