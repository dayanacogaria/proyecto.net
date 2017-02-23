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

    class ClEvaluacion
    {//----------------Método para realizar Conexion con BD---------------------------
        SqlConnection conexion;
        public ClEvaluacion()
        {
            conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\ShieldEnterpriseDB.mdf;Integrated Security=True;Connect Timeout=30");
        }
        //----------------------Método para Registrar Evaluacion -------------------------------
        SqlCommand comandoRegistro;
        public void mtdRegistrar(string consulta)
        {
            conexion.Open();
            comandoRegistro = new SqlCommand(consulta, conexion);
            comandoRegistro.ExecuteNonQuery();
            conexion.Close();
        }
        //----------------------Método para Listar Evaluacion -------------------------------
        SqlDataAdapter adapeva;
        DataTable tbleva;

        public List<EEvaluacion> mtdeval(string consulta)
        {
            conexion.Open();
            adapeva = new SqlDataAdapter(consulta, conexion);
            tbleva = new DataTable();
            adapeva.Fill(tbleva);
            conexion.Close();

            List<EEvaluacion> lista = new List<EEvaluacion>();

            foreach (DataRow fila in tbleva.Rows)
            {
                EEvaluacion evaluar = new EEvaluacion();
                evaluar.IdEvaluacion = Convert.ToInt32(fila["IdEvaluacion"].ToString());
                evaluar.IdPersona = Convert.ToInt32(fila["IdPersona"].ToString());
                evaluar.Documento = (fila["Documento"].ToString());
                evaluar.Nombre= (fila["Nombre"].ToString());
                evaluar.Apellido = (fila["Apellido"].ToString());
                evaluar.Puntaje = fila["Puntaje"].ToString();

                lista.Add(evaluar); 
           }
            return lista; 
        }
    }
}
