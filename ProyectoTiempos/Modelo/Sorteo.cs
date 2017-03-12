using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAccess;
using System.Data;

namespace ProyectoTiempos.Modelo
{
    public class Sorteo : ErrorHandler
    {
        public int id { set; get; }
        public DateTime fecha { set; get; }
        public string descripcion { set; get; }
        public Boolean estado { set; get; }
        public string codigo { set; get; }

        public Sorteo()
        {
                
        }
     

        public Sorteo(string descripcion, string codigo, DateTime fecha, bool estado)
        {
            this.descripcion = descripcion;
            this.codigo = codigo;
            this.fecha = fecha;
            this.estado = estado;
        }

        public DataTable Select()
        {
            DataTable result = Program.da.SqlQuery("select * from sorteo;", new Dictionary<string, object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }

        public void Insert()
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("fecha", this.fecha);
            parametros.Add("estado", this.estado);
            parametros.Add("descripcion", this.descripcion);
            parametros.Add("codigo", this.codigo);
            
            DataTable result = Program.da.SqlQuery("insert into sorteo(descripcion,fecha,estado,codigo ) values (@descripcion ,@fecha,@estado,@codigo) returning id;", parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
                return;
            }
            if (result.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(result.Rows[0]["id"]);
            }




        }
        public DataTable Select(string codigo)
        {

            DataTable result = Program.da.SqlQuery("select * from sorteo where codigo = '" + codigo + "'", new Dictionary<string, object>());
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }


    }
}
