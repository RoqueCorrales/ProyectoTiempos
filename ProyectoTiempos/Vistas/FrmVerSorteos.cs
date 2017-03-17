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
    public partial class FrmVerSorteos : Form
    {
        private DataTable result;
        private Sorteo sorteo;
        public FrmVerSorteos()
        {
            InitializeComponent();
            result = new DataTable();
            sorteo = new Sorteo();
            cargarCombo();
        }
      
        public ComboBox cargarCombo()
        {
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
    }
}
