﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string usuario = "root";
            string password = "";
            string bd = "nomina";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" +
                password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }
    }
}


//Jose Andres Veron Canel