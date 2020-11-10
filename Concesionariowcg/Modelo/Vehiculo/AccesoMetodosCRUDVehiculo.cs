using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class AccesoMetodosCRUDVehiculo
    {
        //Operacion INSERT
        public int InsertVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacInsert_v();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmcInsert_v(_comando);
        }

        //Operacion SELECT
        public static DataTable ListVehiculo()
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoSelect_v();

            _comando.CommandText = "select * from Vehiculo";

            return MetodosCRUDVehiculo.EjecutarComandoSelect_v(_comando);
        }

        //Operacion UPDATE
        public int UpdateVehiculo(int id, string marca, string modelo, string placa, int anio, int id_tv)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacUpdate_v();

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@placa", placa);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@id_tv", id_tv);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmcUpdate_v(_comando);
        }

        //Operacion DELETE
        public int DeleteVehiculo(int id)
        {
            SqlCommand _comando = MetodosCRUDVehiculo.CrearComandoProcAlmacDelete_v();

            _comando.Parameters.AddWithValue("@id", id);

            return MetodosCRUDVehiculo.EjecutarComandoProcAlmcDelete_v(_comando);
        }
    }
}
