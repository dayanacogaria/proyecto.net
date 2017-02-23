using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Recursos_Humanos.Entity;

namespace Recursos_Humanos.Data
{
    class ClArl
    {
        //----------------Método para realizar Conexion con BD---------------------------
        SqlConnection conexion;
        public ClArl()
        {
            conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ShieldEnterpriseDB.mdf;Integrated Security=True;Connect Timeout=30");
        }


        //----------------------Método para Registrar ARL-------------------------------
        SqlCommand comandoRegistro;
        public int mtdRegistArl(EArl objEArl)
        {
            string consulta = "Insert Into ARL (ARL) Values ('" + objEArl.ARL + "')";
            conexion.Open();
            comandoRegistro = new SqlCommand(consulta, conexion);
           int reg=  comandoRegistro.ExecuteNonQuery();
            conexion.Close();
            return reg; 
        }

        //----------------------Método para listar ARL-------------------------------
        SqlDataAdapter adaparl; 
        public object mtdlistararl(string Arl="")
        {
            string sql = "";
            if (Arl != "")
            {
                sql = "Select * From ARL Where ARL = '" + Arl + "'";
            }
            else
            {
                sql = "Select * From ARL";
            }

            DataTable tblarp = new DataTable();
            conexion.Open();
            adaparl = new SqlDataAdapter(sql, conexion);
            adaparl.Fill(tblarp);
            conexion.Close();

            List<EArl> lista = new List<EArl>();

            foreach (DataRow fila in tblarp.Rows)
            {
                EArl objarl = new EArl();

                objarl.IdArl = int.Parse(fila["IdArl"].ToString());
                objarl.ARL = fila["ARL"].ToString();

                lista.Add(objarl);

            }

            return lista; 

        }


                //-------------------- Método para Modificar un Registro-------------------------------------
        SqlCommand comandoUpdate;
        public void mtdUpdateARL(string consulta)
        {
            conexion.Open();
            comandoUpdate = new SqlCommand(consulta, conexion);
            comandoUpdate.ExecuteNonQuery();
            conexion.Close();
        }
        //----------------------Método para eliminar un registro-----------------------------------------------
        SqlCommand comandoDelete;
        public void mtdDeleteARL(string consulta)
        {
            conexion.Open();
            comandoDelete = new SqlCommand(consulta, conexion);
            comandoDelete.ExecuteNonQuery();
            conexion.Close();
        }
        //----------------------Método para Buscar por IdArl-----------------------------------------------
        SqlDataAdapter adapt;
        DataTable tblarl; 

        public List<EArl> mtdbuscaridarl (int id)
        {
            List<EArl> listaid = new List<EArl>();

            string consulta = "Select ARL From ARL where IdArl ="+id+"";
            conexion.Open();
            adapt = new SqlDataAdapter(consulta,conexion);
            tblarl = new DataTable();
            adaparl.Fill(tblarl);
            conexion.Close();


            foreach (DataRow fila in tblarl.Rows)
            {

                EArl arl = new EArl();

                arl.ARL = fila["ARL"].ToString();

                listaid.Add(arl);


            }


            return listaid; 













        }

    }
}
