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


namespace Recursos_Humanos.Interface.Persona
{
    public partial class frmEvaluarPersona : Form
    {
        public frmEvaluarPersona()
        {
            InitializeComponent();
        }
        //int id = 0;
        //string docu;
        //string nom;
        //string apell; 
        
     
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtid1.Text.Trim() == "")
                {
                    MessageBox.Show("Digite un Id para Buscar en el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    ClPersona searchId = new ClPersona();
                    List<EPersona> listReceptId = new List<EPersona>();

                    listReceptId = searchId.mtdBuscarIdPersona(int.Parse(txtid1.Text));

                    txtdoc.Text = listReceptId[0].Documento.ToString();
                    txtnom.Text = listReceptId[0].Nombre.ToString();
                    txtapellido.Text = listReceptId[0].Apellido.ToString();
                   


                }
            }

            catch (Exception)
            {
                MessageBox.Show("El Id no se encuentra en la base de datos", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncomenzar_Click(object sender, EventArgs e)
        {
            //txtid.Text = Convert.ToString(id);
            //txtdoc.Text = docu;
            //txtnom.Text = nom;
            //txtapellido.Text = apell; 


            if (txtapellido.Text==""&& txtnom.Text==""&& txtdoc.Text=="")
            {
                MessageBox.Show("Buscar el empleado a evaluar ");
                
            }
            else
            {

                frmEvaluarOrientacion d = new frmEvaluarOrientacion();


                //frmDatosEvaluacion fr = new frmDatosEvaluacion(a1,a2,a3,a4,a5);

                d.txtid.Text = txtid1.Text;  ; 
               
                d.txtdoc.Text = txtdoc.Text; 
                d.txtnom.Text = txtnom.Text;
                d.txtapell.Text = txtapellido.Text;

                d.Show();
                this.Hide();

                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListarEvaluados d = new frmListarEvaluados();
            d.Show();
            this.Hide(); 

        }
    }
}
