using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SG_SST_modulorecursos.Entidades;
using SG_SST_modulorecursos.Datos;
using SG_SST_modulorecursos.Logica; 

namespace SG_SST_modulorecursos.Vista
{
    public partial class frmListarPersonal : Form
    {
        public frmListarPersonal()
        {
            InitializeComponent();
        }
        LClPersonal objLPersonal = new LClPersonal(); 
        private void frmListarPersonal_Load(object sender, EventArgs e)
        {
            dgvpersonal.DataSource = objLPersonal.mtdlistar(); 

            

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            dgvpersonal.DataSource = objLPersonal.mtdlistar();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
           frmregper objPer = new frmregper();
          objPer.Show();
            this.Hide();
           
        }   
 
        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            if (cmbfiltrar.Text == "Documento")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistardocu(txtpalabra.Text); 
            }else if (cmbfiltrar.Text == "Nombre")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistarnom(txtpalabra.Text); 

            }
            else if (cmbfiltrar.Text=="Apellido ")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistarape(txtpalabra.Text); 

            } else if (cmbfiltrar.Text == "Telefono")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistartel(txtpalabra.Text); 
            } else if (cmbfiltrar.Text == "Email")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistaremail(txtpalabra.Text); 

            } else if (cmbfiltrar.Text == "Direccion")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistardic(txtpalabra.Text); 

            } else if (cmbfiltrar.Text == "GrupoSanguineo")
            {
                dgvpersonal.DataSource = objLPersonal.mtdlistargru(txtpalabra.Text); 
            }


        }
    }
}
