using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio_Negocio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IngresarButton_Click(object sender, EventArgs e)
           {
           UsuarioDA usuarioDA = new UsuarioDA();   
            Usuario usuario = new Usuario();

            usuario = usuarioDA.login(NomUsuarioTextBox.Text, ContraseñaTextBox.Text);
            //if (usuario == null)
            //{
            //    MessageBox.Show("Datos Erroneos");
            //    return;
            //}
            //else if(!usuario.EstaActivo)
            //{
            //    MessageBox.Show("Usuario Inactivo");
            //    return;
            //}
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
