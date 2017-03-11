using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTiempos.Controlador;

namespace ProyectoTiempos
{
    
    public partial class FrmRegistro : Form
    {

        private Persona persona;
        public FrmRegistro()
        {
            InitializeComponent();
            persona = new Persona();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string contrasena = txtContrasenna.Text;
            string correo = txtCorreo.Text;
            string ced = txtCedula.Text;

            if (PasswordConfirm())
            {

                this.persona.Insert(nombre, apellido, ced, contrasena, correo);
                if (this.persona.isError)
                {
                    MessageBox.Show(this.persona.errorDescription);
                    return;
                }
                MessageBox.Show("Persona Registrada");
                this.Close();
            }
        }
        public Boolean PasswordConfirm()
        {
            if (txtContrasenna.Text.Equals(txtContrasennaConfirm.Text))
            {
                return true;
            }
            MessageBox.Show("--------------------Oops!-----------------\n" +
                            "        Contraseñas no son iguales");
            return false;
        }


    }


}

