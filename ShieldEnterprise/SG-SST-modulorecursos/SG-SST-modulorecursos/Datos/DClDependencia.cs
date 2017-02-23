using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG_SST_modulorecursos.Entidades;
using System.Data;
using System.Data.SqlClient; 


namespace SG_SST_modulorecursos.Datos
{
    class DClDependencia
    {
        DClConexion conexion = new DClConexion();
        SqlConnection conex;
        SqlCommand comand;
        SqlDataAdapter adpdep;

        public int mtdregdep(EClDependencia objEDependencia)
        {
            string sql = "Insert Into Dependencia (Dependencia,Descripcion) Values ('" + objEDependencia.Dependencia + "','" + objEDependencia.Descripcion + "')";
            conex = conexion.mtdconexion();

            comand = new SqlCommand(sql, conex);
            conex.Open();
            int reg = comand.ExecuteNonQuery(); 
            conex.Close();
            return reg; 


        }

        public object mtdlisdep (string nom="")
        {
            string sql = ""; 
            if (nom!= "")
            {
                sql = "Select * from Dependencia Where Dependencia = '" + nom + "'";

            }else
            {
                sql = "Select * from Dependencia ";
            }


            DataTable tbldep = new DataTable();
            conex = conexion.mtdconexion();
            adpdep = new SqlDataAdapter(); 
            conex.Open();
            adpdep.Fill(tbldep);
            conex.Close();

            List<EClDependencia> listadep = new List<EClDependencia>();

            foreach (DataRow fil in tbldep.Rows)
            {
                EClDependencia objEDependencia = new EClDependencia();


                objEDependencia.IdDependencia = Convert.ToInt32(fil["IdDependencia"].ToString());
                objEDependencia.Dependencia = fil["Dependencia"].ToString();
                objEDependencia.Descripcion = fil["Descripcion"].ToString();

                listadep.Add(objEDependencia);

            }

            return listadep;  



        }
    






    }
}
