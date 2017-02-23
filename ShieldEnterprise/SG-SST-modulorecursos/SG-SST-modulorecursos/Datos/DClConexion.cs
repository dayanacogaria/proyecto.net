using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SG_SST_modulorecursos.Datos
{
    class DClConexion
    {

        SqlConnection cadena;

        public SqlConnection mtdconexion()
        {
             cadena = new SqlConnection ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|SG-SSTMR.mdf;Integrated Security = True");
            return cadena;
        }


    }
}
