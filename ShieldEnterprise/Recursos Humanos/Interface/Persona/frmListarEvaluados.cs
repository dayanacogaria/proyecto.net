using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recursos_Humanos.Interface;
using Recursos_Humanos.Entity;
using Recursos_Humanos.Data;
using Recursos_Humanos.Interface.Persona;


namespace Recursos_Humanos.Interface.Persona
{
    public partial class frmListarEvaluados : Form
    {
        public frmListarEvaluados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEvaluarPersona d = new frmEvaluarPersona();
            d.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClEvaluacion eva = new ClEvaluacion();
            dgveva.DataSource = eva.mtdeval("select  Evaluacion.IdEvaluacion,Evaluacion.IdPersona,Persona.Documento, Persona.Nombre, Persona.Apellido,  Evaluacion.Puntaje from Persona inner join Evaluacion on Persona.IdPersona=Evaluacion.IdPersona"); 
        }
    }
}
