using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conductor
{
    public class AccesoMetodosCRUDConductor
    {
        //Operacion INSERT
        public int InsertConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, string id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacInsert_c();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDConductor.EjecutarComandoProcAlmcInsert_c(_comando);
        }

        //Operacion SELECT
        public static DataTable ListConductor()
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoSelect_c();

            _comando.CommandText = "select * from Conductor";

            return MetodosCRUDConductor.EjecutarComandoSelect_c(_comando);
        }

        //Operacion UPDATE
        public int UpdateConductor(int id, string nombre, string tipo_licencia, int id_vehiculo, string id_tipo_conductor)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacUpdate_c();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipo_licencia", tipo_licencia);
            _comando.Parameters.AddWithValue("@id_vehiculo", id_vehiculo);
            _comando.Parameters.AddWithValue("@id_tipo_conductor", id_tipo_conductor);

            return MetodosCRUDConductor.EjecutarComandoProcAlmcUpdate_c(_comando);
        }

        //Operacion DELETE
        public int DeleteConductor(int id)
        {
            SqlCommand _comando = MetodosCRUDConductor.CrearComandoProcAlmacDelete_c();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDConductor.EjecutarComandoProcAlmcDelete_c(_comando);
        }
    }
}
