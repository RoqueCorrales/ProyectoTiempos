using DBAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTiempos.Controladores
{
    class SorteoPremiado : ErrorHandler
    {
        private Modelo.SorteoPremiado sorPre;
      
        public SorteoPremiado()
        {
            this.sorPre = new Modelo.SorteoPremiado();
        }

        public void Insert( string codigo_sorteo, int numUno, int numDos, int numTres, int id_sorteo)
        {
            this.sorPre = new Modelo.SorteoPremiado();
            this.sorPre.Insert(codigo_sorteo,numUno,numDos,numTres,id_sorteo);
            if (this.sorPre.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorPre.errorDescription;
            }
        }
    }
}
