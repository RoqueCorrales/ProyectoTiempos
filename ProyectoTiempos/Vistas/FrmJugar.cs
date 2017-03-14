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
    public partial class FrmJugar : Form
    {
        private Sorteo sorteo;
        public FrmJugar()
        {
            InitializeComponent();
            sorteo = new Sorteo();
            cargarCombo();
        }

        public ComboBox cargarCombo()
        {
            DataTable result = new DataTable();

            result = this.sorteo.SelectCodigo();

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
