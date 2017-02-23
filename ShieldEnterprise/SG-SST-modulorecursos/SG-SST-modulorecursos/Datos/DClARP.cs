using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SG_SST_modulorecursos.Entidades;

namespace SG_SST_modulorecursos.Datos
{
    class DClARP
    {
        DClConexion conex = new DClConexion();

        SqlConnection conexion; 
        SqlCommand cmdarp;
        SqlDataAdapter adaparp; 

        public int mtdARP(EClARP objEARP)
        {
            string agregar = "Select Into ARP (ARP) values ('" + objEARP.ARP + "')";
            conexion = conex.mtdconexion();
            cmdarp = new SqlCommand(agregar, conexion);
            conexion.Open();
            int reg = cmdarp.ExecuteNonQuery();
            conexion.Close();
            return reg; 
        }

        public object mtdlistararp(string Arp ="")
        {

            string sql = "";
            if (Arp != "")
            {
                sql = "Select * From ARP Where ARP = '"+Arp+"'";

            }
            else
            {
                sql = "Select * From ARP";

            }


            DataTable tblARP = new DataTable();
            conexion = conex.mtdconexion();
            adaparp = new SqlDataAdapter(sql, conexion);
            conexion.Open();
            adaparp.Fill(tblARP); 
            conexion.Close();

            List<EClARP> lista = new List<EClARP>();

            foreach (DataRow fila in tblARP.Rows)
            {
                EClARP objEarp = new EClARP();

                objEarp.IdARP = int.Parse(fila["IdARP"].ToString());
                objEarp.ARP = fila["ARP"].ToString();

                lista.Add(objEarp); 


            }
            return lista; 
        }






    }
}
