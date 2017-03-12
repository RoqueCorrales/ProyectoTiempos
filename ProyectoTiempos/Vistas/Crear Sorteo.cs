using ProyectoTiempos.Controladores;
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
    public partial class FrmCrearSorteo : Form
    {
        private Serial serial;
        private Sorteo sorteo;
        public FrmCrearSorteo()
        {
            InitializeComponent();
            serial = new Serial();
            sorteo = new Sorteo();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblSerial.Text = serial.sacarSerial();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtHora.Value.Date +
                    dtHora.Value.TimeOfDay;

         
            string descripcion = txtDescripcion.Text;
            string codigo = lblSerial.Text;
            Boolean estado = false;

            sorteo.Insert(descripcion, codigo, fecha, estado);

        }
    }
}
