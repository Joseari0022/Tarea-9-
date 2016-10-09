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
            u.NombreUsuario = NombretextBox10.Text;
            u.Contrasena = ContrasenatextBox12.Text;
        }

       
        private bool BuscarValido()
        {
            if(UsuariosBLL.Buscar(String(IdUsuariotextBox.Text))== null )
            {
                MessageBox.Show("Este usuario no existe");
                return false;
            }
            
                return true;
            
        }
 
        private bool IdValidado(string mensaje)
        {
            if(string.IsNullOrEmpty(IdUsuariotextBox.Text))
            {
                BuscarerrorProvider.SetError(IdUsuariotextBox,"Ingrese Id");
                MessageBox.Show(mensaje);
                return false;
            }else
            {
                return true;
            }
        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        

        private void button10_Click(object sender, EventArgs e)
        {
            if (IdValidado("Favor Ingrese Id del Usuario") && BuscarValido())
                Llenarusu(UsuariosBLL.Buscar(String(IdUsuariotextBox.Text)));
        }

        private void Llenarusu(Usuarios usuario)
        {
            IdUsuariotextBox.Text = usuario.IdUsuario.ToString();
            NombretextBox10.Text = usuario.NombreUsuario;
            ContrasenatextBox12.Text = usuario.Contrasena;
            ConfirmarContrasenatextBox13.Text = usuario.Contrasena;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            BuscarerrorProvider.Clear();
            Llenar(usuario);
            UsuariosBLL.Insertar(usuario);
            if(ValidarTexb() && ValidarExist(NombretextBox10.Text))
            {
                UsuariosBLL.Insertar(usuario);
                Limpiarme();
                MessageBox.Show("Guardado con exito");
            }
        }

        public void Limpiarme()
        {
            IdUsuariotextBox.Clear();
            NombretextBox10.Clear();
            ContrasenatextBox12.Clear();
            ConfirmarContrasenatextBox13.Clear();
        }

        public bool ValidarTexb()
        {
            if (string.IsNullOrEmpty(NombretextBox10.Text) && string.IsNullOrEmpty(ContrasenatextBox12.Text) && string.IsNullOrEmpty(ConfirmarContrasenatextBox13.Text)) 
            {
                NombreerrorProvider.SetError(NombretextBox10, "Ingresar el nombre");
                ContrasenaerrorProvider.SetError(ContrasenatextBox12, "Ingresar contraseña");
                ConfirmarContrasenaerrorProvider.SetError(ConfirmarContrasenatextBox13, "Confirmar contraseña");
                MessageBox.Show("Llenar todos los campos");
            }
            if(string.IsNullOrEmpty(NombretextBox10.Text))
            {
                NombreerrorProvider.SetError(NombretextBox10, "Ingrese el nombre");
                return false;
            }
            if(string.IsNullOrEmpty(ContrasenatextBox12.Text))
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.SetError(ContrasenatextBox12, "Ingrese contraseña");
                return false;
            }
            if(string.IsNullOrEmpty(ConfirmarContrasenatextBox13.Text))
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.Clear();
                ConfirmarContrasenaerrorProvider.SetError(ConfirmarContrasenatextBox13, "Confirmar contraseña");
                return false;
            }
            if(ContrasenatextBox12.Text != ConfirmarContrasenatextBox13.Text)
            {
                NombreerrorProvider.Clear();
                ContrasenaerrorProvider.Clear();
                ConfirmarContrasenaerrorProvider.Clear();
                ConfirmarContrasenaerrorProvider.SetError(ConfirmarContrasenatextBox13, "La contraseña no coincide");
                return false;
            }

            return true;
        }

        private bool ValidarExist(string aux)
        {
            if(UsuariosBLL.GetListaNombreUsuario(aux).Count() > 0)
            {
                MessageBox.Show("Este nombre de usuario existe intentar con otro por favor ");
                return false;
            }
            else
            {
                return true;
            } 
            
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if(IdValidado("Dijite el id del usuario a eliminar") && BuscarValido())
            {
                UsuariosBLL.Eliminar(String(IdUsuariotextBox.Text));
                Limpiarme();
                MessageBox.Show("Usuario Eliminado");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiarme();
        }

        private void Nuevobutton14_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            if(IdValidado(" Favor Buscar el Usuario a modificar") && ValidarTexb())
            {
                Llenar(usuario);
                if (ValidarExist(NombretextBox10.Text));
                {
                    UsuariosBLL.Modificar(String(IdUsuariotextBox.Text), usuario);
                    Limpiarme();
                    MessageBox.Show("La modificacion fue todo un exito");
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {


        }



    }
}
