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

namespace Recursos_Humanos.Interface
{
    public partial class frmListarPersona : Form
    {
        public frmListarPersona()
        {
            InitializeComponent();
        }

        private void frmListarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnListarPersona_Click(object sender, EventArgs e)
        {
            ClPersona C = new ClPersona();
            dgvListaPersona.DataSource = C.mtdListarPersona("select Persona.IdPersona, Persona.Documento, Persona.Nombre, Persona.Apellido,Persona.Direccion,Persona.Telefono,Persona.Email,ARL.ARL from Persona inner join ARL on ARL.IdArl=Persona.IdArl ");
        }
               
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmRegistroPersona registro = new frmRegistroPersona();
            this.Hide();
            registro.Show();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {         
            frmModifPersona U = new frmModifPersona();
            U.Show();           
        }    
               
        private void btnShowModif_Click(object sender, EventArgs e)
        {
            frmModifPersona U = new frmModifPersona();
            U.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarPersona D = new frmEliminarPersona();
            D.Show();            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ClPersona per = new ClPersona();
            EPersona ep = new EPersona(); 
             
            if (txtFilDoc.Text != "" && txtnom.Text != "" && txtFillApe.Text!="")
            {
                MessageBox.Show("Solo puede por buscar por un solo campo ");

            }
            else

            {
                
                if (txtFilDoc.Text != "")
                {
                    ep.Documento = txtFilDoc.Text;
                    dgvListaPersona.DataSource = per.mtdListarPersona("select Persona.IdPersona, Persona.Documento, Persona.Nombre, Persona.Apellido,Persona.Direccion,Persona.Telefono,Persona.Email,ARL.ARL from Persona inner join ARL on ARL.IdArl=Persona.IdArl where Persona.Documento = '" + ep.Documento+"' ");
                    txtFilDoc.Clear();
                }
                else if (txtnom.Text != "")
                {
                    ep.Nombre = txtnom.Text;
                    dgvListaPersona.DataSource = per.mtdListarPersona("select Persona.IdPersona, Persona.Documento, Persona.Nombre, Persona.Apellido,Persona.Direccion,Persona.Telefono,Persona.Email,ARL.ARL from Persona inner join ARL on ARL.IdArl=Persona.IdArl where Persona.Nombre = '" + ep.Nombre + "'  ");
                    txtnom.Clear();
                }

                else if (txtFillApe.Text != "")
                {
                    ep.Apellido = txtFillApe.Text;
                    dgvListaPersona.DataSource = per.mtdListarPersona("select Persona.IdPersona, Persona.Documento, Persona.Nombre, Persona.Apellido,Persona.Direccion,Persona.Telefono,Persona.Email,ARL.ARL from Persona inner join ARL on ARL.IdArl=Persona.IdArl where Persona.Apellido = '" + ep.Apellido + "'  ");
                    txtFillApe.Clear();
                }

                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEvaluarPersona d = new frmEvaluarPersona();
            d.Show();
        }
    }
} 
