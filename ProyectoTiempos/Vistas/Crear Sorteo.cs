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
            // Refrescar();
            dgSorteos = new DataGridView();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblSerial.Text = serial.sacarSerial();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtHora.Value.Date +
                    dtHora.Value.TimeOfDay;
            MessageBox.Show(fecha.ToString());
         
            string descripcion = txtDescripcion.Text;
            string codigo = lblSerial.Text;
            Boolean estado = false;

            sorteo.Insert(descripcion, codigo, fecha, estado);

        }
        private void Refrescar()
        {
            DataTable result = new DataTable();
            result = this.sorteo.Select();
            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);
                return;
            }
            this.dgSorteos.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
