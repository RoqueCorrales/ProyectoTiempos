using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using System.Data;

namespace ProyectoTiempos.Controladores
{
   public  class Sorteo : ErrorHandler
    {
        private Modelo.Sorteo sorteo;
        public Sorteo()
        {
            this.sorteo = new Modelo.Sorteo();
        }
        public void Insert(string descripcion, string codigo, DateTime fecha,  Boolean estado)
        {
            this.sorteo = new Modelo.Sorteo(descripcion, codigo, fecha, estado);
            this.sorteo.Insert();
            if (this.sorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
        }

        public DataTable Select()
        {
            DataTable result = new DataTable();
            result = new DataTable();
            result = this.sorteo.Select();
           if(this.sorteo.isError) {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
            return result;
        }

        public DataTable SelectCodigo(String codigo)
        {
            DataTable result = new DataTable();
            result = new DataTable();
            result = this.sorteo.SelectCodigo(codigo);
            if (this.sorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
            return result;
        }

    }
}

