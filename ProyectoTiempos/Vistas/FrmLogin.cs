using System;
using System.Windows.Forms;
using ProyectoTiempos.Controlador;
using System.Data;

namespace ProyectoTiempos
{
    public partial class FrmLogin : Form
    {
        Persona persona;

        private FrmPrincipal oPrincipal;
        public FrmLogin()
        {
            InitializeComponent();

            this.persona = new Persona();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            correoRegistrado();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro oRegistro = new FrmRegistro();
            oRegistro.ShowDialog();
        }





        private Boolean correoRegistrado()
        {
            DataTable p = persona.Select(txtCorreo.Text);
            if (p.Rows.Count <= 0)
            {
                MessageBox.Show("Correo no registrado");
                return false;
            }
            DataRow row = p.Rows[0];
            string pass = row["contrasenna"].ToString();
            String correo = row["correo"].ToString();
            String priv = row["privilegios"].ToString();
            Boolean privilegios = Convert.ToBoolean(priv);

            if (txtCorreo.Text.Equals(correo) && txtContrasenna.Text.Equals(pass))
            {
                oPrincipal = new FrmPrincipal(privilegios);
                oPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales no validos");
            }
            return true;

        }





    }
}
