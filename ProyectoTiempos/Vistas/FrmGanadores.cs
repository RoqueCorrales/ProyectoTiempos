using ProyectoTiempos.Controladores;
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
        private Logica log;
        private Sorteo sorteo;
        public FrmGanadores()
        {
            InitializeComponent();
            notificacion = new Notificacion();
            log = new Logica();
            sorteo = new Sorteo();
            cargarCombo();
            //cbSorteo = log.cargarCombo();
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
                notificacion.enviarCorreo(textBox1.Text, textBox2.Text, Convert.ToDouble(textBox3.Text), Convert.ToInt32(textBox4.Text));
                
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
           public ComboBox cargarCombo()
        {
            DataTable result = new DataTable();
           
            result = this.sorteo.SelectSorteosEstadoTrue();
           
            for (int i = 0; i < result.Rows.Count; i++)
            {
                cbSorteo.Items.Add(result.Rows[i]["codigo"]);
            }
            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);
                
            }

            return cbSorteo;
        }

        private void cbSorteo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

      
    
