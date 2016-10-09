using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuario
{
    public partial class Form1 : Form
    {
        RegisterUsersForm RU = new RegisterUsersForm();
        public Form1()
        {
            InitializeComponent();
        }

        public void Llenar(Usuarios u)
        {
            u.NombreUsuario = NombretextBox.Text;
            u.Contrasena = ContrasenatextBox10.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            Llenar(usuario);
            UsuariosBLL.Insertar(usuario);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (IdValidado("Favor ingresar el id del mensajero que desea buscar") && BuscarValido())
                Llenar(UsuariosBLL.Buscar(RU.StringToInt(IdUsuariotextBox.Text)));

        }

        private bool IdValidado(string  Mensaje)
        {
            if(string.IsNullOrEmpty(IdUsuariotextBox.Text))
            {
                ErrorProvider.
            }
        }

        private bool BuscarValido()
        {
            if(UsuariosBLL.Buscar(RU.StringToInt(IdUsuariotextBox.Text))== null )
            {
                MessageBox.Show("Este usuario no existe");
                return false;
            }
            
                return true;
            
        }
    }
}
