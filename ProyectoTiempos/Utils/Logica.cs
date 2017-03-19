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
        private SorteoPremiado sorPre;
        public Logica()
        {
            sorteo = new Sorteo();
            sorPre = new SorteoPremiado();
        }


        public ComboBox cargarCombo()
        {
            DataTable result = new DataTable();
            ComboBox combo = new ComboBox();
            result = this.sorteo.SelectCodigo();
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


        public int buscarID(string codigo)
        {
            int id_sorteo;
            DataTable result = new DataTable();
            result = this.sorteo.SelectCodigo(codigo);
            DataRow row = result.Rows[0];
            string id = row["id"].ToString();
            id_sorteo = Convert.ToInt32(id);
            return id_sorteo;
        }


        public Boolean existeSorteo(string codigo)
        {
            DataTable sor = new DataTable();

            sor = sorteo.SelectCodigo(codigo);

            if(sor.Rows.Count > 0)
            {
                return true;
            }


            return false;
        }


        public ComboBox cargarComboxSorteosNoPremiados()
        {
            DataTable todos = new DataTable();
            DataTable resultPremiados = new DataTable();
            ComboBox combo = new ComboBox();
            todos= this.sorteo.SelectSorteosEstadoTrue();
            resultPremiados = this.sorPre.Select();
            if (this.sorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
            if ( this.sorPre.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorPre.errorDescription;
            }
            for (int i = 0; i < todos.Rows.Count; i++)
            {
                string a = (todos.Rows[i]["codigo"]).ToString();
                for (int j = 0; j < resultPremiados.Rows.Count; j++)
                {
                    if (!resultPremiados.Rows[j]["codigo_sorteo"].ToString().Equals(a))
                    {
                        combo.Items.Add(a);
                    }
                }
            }
            


            return combo;
        }



    }
    }

