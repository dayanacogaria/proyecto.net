using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG_SST_modulorecursos.Entidades;
using System.Data;
using System.Data.SqlClient; 

namespace SG_SST_modulorecursos.Datos
{
    class DClRol
    {
            DClConexion conexion = new DClConexion();

        SqlConnection conex;
        SqlCommand coman;
        SqlDataAdapter adaprol;

        public int mtddaros(EClRol objERol)
        {
            string agre = "Insert into Rol (Rol) Values ('" + objERol.Rol + "')";
            conex = conexion.mtdconexion();
            coman = new SqlCommand(agre, conex);
            conex.Open();
            int reg = coman.ExecuteNonQuery(); 
            conex.Close();

            return reg; 
       }

        public object mtdlis(string rol = "")
        {
            string bus = "";
            if (rol!="")
            {
                bus = "Select * From Rol Where Rol = '" + rol + "' ";
            }
            else
            {
                bus = "Select * From Rol"; 
            }

            DataTable tblrol = new DataTable();
            conex = conexion.mtdconexion();
            adaprol = new SqlDataAdapter(bus,conex);
            conex.Open();
            adaprol.Fill(tblrol); 
            conex.Close();

            List<EClRol> lista = new List<EClRol>();

            foreach (DataRow fila in tblrol.Rows)
            {
                EClRol objERol = new EClRol();

                objERol.IdRol = Convert.ToInt32(fila["IdRol"].ToString());
                objERol.Rol = fila["Rol"].ToString();

                lista.Add(objERol); 
            }

            return lista; 

        }




    }
}
