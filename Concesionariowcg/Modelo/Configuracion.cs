﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Configuracion
    {
        static string cadenaConexion = @"Data source=DESKTOP-61D6P56\SQLEXPRESS; Initial Catalog=concesionario;Trusted_Connection=true";

        public static string CadenaConexion
        {
           get { return cadenaConexion; }
        }
    }
}
