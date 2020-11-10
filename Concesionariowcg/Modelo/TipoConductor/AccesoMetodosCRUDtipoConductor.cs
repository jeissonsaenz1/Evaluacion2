using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.TipoConductor
{
    public class AccesoMetodosCRUDtipoConductor
    {
        //Operacion INSERT
        public int InsertTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacInsert_tc();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmcInsert_tc(_comando);
        }

        //Operacion SELECT
        public static DataTable ListTipoConductor()
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoSelect_tc();

            _comando.CommandText = "select * from Tipo_Conductor";

            return MetodosCRUDtipoConductor.EjecutarComandoSelect_tc(_comando);
        }

        //Operacion UPDATE
        public int UpdateTipoConductor(int id, string tipo_persona)
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacUpdate_tc();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@tipo_persona", tipo_persona);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmcUpdate_tc(_comando);
        }

        //Operacion DELETE
        public int DeleteTipoConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDtipoConductor.CrearComandoProcAlmacDelete_tc();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDtipoConductor.EjecutarComandoProcAlmcDelete_tc(_comando);
        }
    }
}
