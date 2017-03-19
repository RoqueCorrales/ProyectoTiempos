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
    public partial class FrmNumerosPremiados : Form
    {
        private DataTable result;
        private Sorteo sorteo;
        private SorteoPremiado sorPre;
        private Logica log;


        public FrmNumerosPremiados()
        {
            InitializeComponent();
            //result = new DataTable();
            sorPre = new SorteoPremiado();
            sorteo = new Sorteo();
            log = new Logica();
            refrecar();
           
            //cbSorteo = log.cargarComboxSorteosNoPremiados();
        }

        public ComboBox cargarCombo()
        {

            DataTable todos = new DataTable();
            DataTable resultPremiados = new DataTable();

            todos = sorteo.SelectSorteosEstadoTrue();
            resultPremiados = sorPre.Select();
            List<string> lista = new List<string>();

            for (int i = 0; i < todos.Rows.Count; i++)
            {
                string a = (todos.Rows[i]["codigo"]).ToString();
                lista.Add(a);
             }

            for (int j = 0; j < resultPremiados.Rows.Count; j++)
            {
                string a = resultPremiados.Rows[j]["codigo_sorteo"].ToString();
                if (lista.Contains(a))
                {
                    lista.Remove(a);
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                cbSorteo.Items.Add(lista[i]);
            }

            return cbSorteo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Object selectedItem = cbSorteo.SelectedItem;
            string sorteo = selectedItem.ToString();
            int id = log.buscarID(sorteo);
            int numUno = Convert.ToInt32(cbPrimero.SelectedItem.ToString());
            int numDos = Convert.ToInt32(cbSegundo.SelectedItem.ToString());
            int numTres =Convert.ToInt32(cbTercero.SelectedItem.ToString());
            sorPre.Insert(sorteo, numUno, numDos, numTres, id);

            if (this.sorteo.isError)
            {
                MessageBox.Show(this.sorteo.errorDescription);

            }
            refrecar();
        }

        public void refrecar()
        {
            cbSorteo.Items.Clear();
            cargarCombo();
            //cbSorteo.SelectedIndex = -1;
            cbPrimero.SelectedIndex = -1;
            cbTercero.SelectedIndex = -1;
            cbSegundo.SelectedIndex = -1;
        }

            }
}
