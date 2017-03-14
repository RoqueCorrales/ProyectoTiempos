using ProyectoTiempos.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiempos.Vistas
{
    public partial class FrmGanadores : Form
    {
        private Notificacion notificacion;
        public FrmGanadores()
        {
            InitializeComponent();
            notificacion = new Notificacion();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {

            notificacion.enviarCorreo(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox4.Text));

        }
    }
}
