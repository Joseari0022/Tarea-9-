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
            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
          

        }

        private bool IdValidado(string  Mensaje)
        {
            if(string.IsNullOrEmpty(IdUsuariotextBox.Text))
            {
                IderrorProvider.SetError(IdUsuariotextBox, "Ingrese el Id");
                MessageBox.Show(Mensaje);
                return false;
            }else
            {
                return true;
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (IdValidado("") && BuscarValido())
                Llenar(UsuariosBLL.Buscar(RU.StringToInt(IdUsuariotextBox.Text)));
        }


        private void button15_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            Llenar(usuario);
            UsuariosBLL.Insertar(usuario);
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if(IdValidado("") && BuscarValido())
            {
                UsuariosBLL.Eliminar(RU.StringToInt(IdUsuariotextBox.Text));
                MessageBox.Show("Usuario Eliminado");
            }
        }

        private void Nuevobutton14_Click(object sender, EventArgs e)
        {

        }
    }
}
