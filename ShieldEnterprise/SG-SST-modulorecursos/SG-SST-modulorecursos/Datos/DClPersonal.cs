using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG_SST_modulorecursos.Entidades;
using System.Data;
using System.Data.SqlClient;


namespace SG_SST_modulorecursos.Datos
{
    class DClPersonal
    {

        DClConexion conex = new DClConexion();

        SqlConnection conexion;
        SqlCommand cmdregper;
        SqlDataAdapter adapper;

        public int mtdRegPer (EClPersonal objeperso)
        {
            string inser = "Insert Into Personal (Documento, Nombre, Apellido, Telefono, Email, Direccion, GrupoSanguineo, IdARP) Values ('" + objeperso.Documento + "','" + objeperso.Nombre + "','" + objeperso.Apellido + "','" + objeperso.Telefono + "','" + objeperso.Email + "','" + objeperso.Direccion + "','" + objeperso.GrupoSanguineo + "','" + objeperso.IdARP + "')";
            conexion = conex.mtdconexion();

            cmdregper = new SqlCommand(inser,conexion);
            conexion.Open();
            int reg = cmdregper.ExecuteNonQuery();
            conexion.Close();
            return reg; 

        }

        public object mtdlistar(string docum = "", string nombre = "", string apelli = "", string tel = "", string email = "", string direccion = "", string grup = "")
        {

            string consul = "";

            if (docum != "")
            {
                consul = "Select * From Personal Where Documento = '" + docum + "'";

            } else if (nombre != "")
            {
                consul = "Select * From Personal Where Nombre = '" + nombre + "'";
            } else if (apelli != "")
            {
                consul = "Select * From Personal Where Apellido = '" + apelli + "'";
            } else if (tel != "")
            {
                consul = "Select * From Personal Where Telefono = '" + tel + "' ";
            } else if (email != "")
            {
                consul = "Select * From Personal Where Email = '" + email + "' ";

            } else if (direccion != "")
            {
                consul = "Select * From Personal Where Direccion = '" + direccion + "' ";
            }
            else if (grup != "")
            {
                consul = "Select * From Personal Where GrupoSanguineo = '" + grup + "' ";
            }
            else
            {
                consul = "Select * From Personal";
            }

            DataTable tblPer = new DataTable();
            conexion = conex.mtdconexion();
            adapper = new SqlDataAdapter(consul, conexion);
            conexion.Open();
            adapper.Fill(tblPer); 
            conexion.Close();

            List<EClPersonal> list = new List<EClPersonal>();

            foreach (DataRow fil in tblPer.Rows)
            {
                EClPersonal objeperosona = new EClPersonal();

                //objeperosona.IdPersonal = int.Parse(fil["IdPersonal"].ToString());
                objeperosona.Documento = fil["Documento"].ToString();
                objeperosona.Nombre = fil["Nombre"].ToString();
                objeperosona.Apellido = fil["Apellido"].ToString();
                objeperosona.Telefono = fil["Telefono"].ToString();
                objeperosona.Email = fil["Email"].ToString();
                objeperosona.Direccion = fil["Direccion"].ToString();
                objeperosona.GrupoSanguineo = fil["GrupoSanguineo"].ToString();
                objeperosona.IdARP = int.Parse(fil["IdARP"].ToString());

                list.Add(objeperosona);

            }

            return list; 
        }
    }
}
