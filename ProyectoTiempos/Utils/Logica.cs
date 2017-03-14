using DBAccess;
using ProyectoTiempos.Controladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiempos.Utils
{
    public class Logica : ErrorHandler
    {
        private Sorteo sorteo;
        public Logica()
        {
            sorteo = new Sorteo();
        }


        public ComboBox cargarCombo()
        {
            DataTable result = new DataTable();
            ComboBox combo = new ComboBox();
            result = this.sorteo.Select();
            if (this.sorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
            for (int i = 0; i < result.Rows.Count; i++)
            {
                combo.Items.Add(result.Rows[i]["codigo"]);
            }


            return combo;
            }
        }
    }

