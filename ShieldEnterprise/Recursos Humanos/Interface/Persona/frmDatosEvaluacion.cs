using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recursos_Humanos.Data;
using Recursos_Humanos.Entity;
using Recursos_Humanos.Interface;

namespace Recursos_Humanos.Interface.Persona
{
    public partial class frmDatosEvaluacion : Form
    {
        public frmDatosEvaluacion(int a1, int a2 , int a3 ,int a4, int a5)
        {
            InitializeComponent();
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
            this.a4 = a4;
            this.a5 = a5;
            


        }
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        int a5 = 0;
     
        int puntos = 0  ; 
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEvaluarPersona d = new frmEvaluarPersona();
            d.Show();
            this.Hide(); 
    
        }

        ClEvaluacion R = new ClEvaluacion(); 
        private void btnmos_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim() == "" || txtdoc.Text.Trim() == "" || txtape.Text.Trim() == "" || txtnom.Text.Trim() == "")
            {
                MessageBox.Show("Realice la evaluacion correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                puntos = a1 + a2 + a3 + a4 + a5;
                txtpuntaje.Text = Convert.ToString(puntos);

                EEvaluacion eu = new EEvaluacion();

                eu.IdPersona = Convert.ToInt32(txtid.Text);
                eu.Puntaje = txtpuntaje.Text;

                string sql = "Insert Into Evaluacion (IdPersona, Puntaje) values ('" + eu.IdPersona + "', '" + eu.Puntaje + "')";
                R.mtdRegistrar(sql);

                
                MessageBox.Show("Registro guardado exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            
           
        }
    }
}

