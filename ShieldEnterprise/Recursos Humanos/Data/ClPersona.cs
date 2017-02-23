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

    class ClPersona
    {

        //----------------Método para realizar Conexion con BD---------------------------
        SqlConnection conexion;
        public ClPersona()
        {
           conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ShieldEnterpriseDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        //----------------------Método para Registrar-------------------------------
        SqlCommand comandoRegistro;
        public void mtdRegistrar(string consulta)
        {
            conexion.Open();
            comandoRegistro = new SqlCommand(consulta, conexion);
            comandoRegistro.ExecuteNonQuery();
            conexion.Close();
        }
        //------------------------Método para Listar-----------------------------------
        SqlDataAdapter adaptListar;
        DataTable tablaDatos;
        public List<EPersona> mtdListarPersona (string consulta)
        {
            conexion.Open();
            adaptListar = new SqlDataAdapter(consulta, conexion);
            tablaDatos = new DataTable();
            adaptListar.Fill(tablaDatos);
            conexion.Close();

            List<EPersona> listaPersona = new List<EPersona>();

            foreach (DataRow fila in tablaDatos.Rows)
            {
                EPersona C = new EPersona();
             

                C.IdPersona = fila["IdPersona"].ToString();
                C.Documento = fila["Documento"].ToString();
                C.Nombre = fila["Nombre"].ToString();
                C.Apellido = fila["Apellido"].ToString();
                C.Direccion = fila["Direccion"].ToString();
                C.Telefono = fila["Telefono"].ToString();
                C.Email = fila["Email"].ToString();
                C.ARL = fila["ARL"].ToString();

                listaPersona.Add(C);
                
            }

            return listaPersona;
        }
        //-------------------- Método para Modificar un Registro-------------------------------------
        SqlCommand comandoUpdate;
        public void mtdUpdatePersona (string consulta)
        {
            conexion.Open();
            comandoUpdate = new SqlCommand(consulta, conexion);
            comandoUpdate.ExecuteNonQuery();
            conexion.Close();             
        }
        //----------------------Método para eliminar un registro-----------------------------------------------
        SqlCommand comandoDelete;
        public void mtdDeletePersona(string consulta)
        {
            conexion.Open();
            comandoDelete = new SqlCommand(consulta, conexion);
            comandoDelete.ExecuteNonQuery();
            conexion.Close();
        }
        //----------------------Método para Buscar por IdPersona-----------------------------------------------
        SqlDataAdapter adaptId;
        DataTable tablaId;
        public List<EPersona> mtdBuscarIdPersona(int Id)
        {
            List<EPersona> listId = new List<EPersona>();

            string consulta = "Select Documento, Nombre, Apellido, Direccion, Telefono, Email from Persona where IdPersona ="+Id+"";
            conexion.Open();
            adaptId = new SqlDataAdapter(consulta, conexion);
            tablaId = new DataTable();
            adaptId.Fill(tablaId);
            conexion.Close();

            foreach (DataRow fila in tablaId.Rows)
            {
                EPersona EId = new EPersona();

                EId.Documento = fila["Documento"].ToString();
                EId.Nombre = fila["Nombre"].ToString();
                EId.Apellido = fila["Apellido"].ToString();
                EId.Direccion = fila["Direccion"].ToString();
                EId.Telefono = fila["Telefono"].ToString();
                EId.Email = fila["Email"].ToString();

                listId.Add(EId);
            }
            return listId;
        }
    }
}
