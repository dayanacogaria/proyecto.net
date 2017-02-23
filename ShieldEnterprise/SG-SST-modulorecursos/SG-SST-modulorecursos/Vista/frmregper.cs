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
    public partial class frmregper : Form
    {
        public frmregper()
        {
            InitializeComponent();
        }
        EClPersonal objEperso = new EClPersonal();
        LClPersonal objLPerso = new LClPersonal();

        private void btnregper_Click(object sender, EventArgs e)
        {
            if (txtdocu.Text.Trim() == "" || txtnom.Text == "" || txtape.Text == "" || txttel.Text == "" || txtemail.Text == "" || txtdir.Text == "" || txtgrup.Text == "")
            {
                MessageBox.Show("Registre datos Correctamente ");
            }
            else
            {                       
                objEperso.Documento = txtdocu.Text;
                objEperso.Nombre = txtnom.Text;
                objEperso.Apellido = txtape.Text;
                objEperso.Telefono = txttel.Text;
                objEperso.Email = txtemail.Text;
                objEperso.Direccion = txtdir.Text;
                objEperso.GrupoSanguineo = txtgrup.Text;
                objEperso.IdARP = Convert.ToInt32(cmbarp.SelectedValue.ToString());

                objLPerso.mtddatos(objEperso);
                MessageBox.Show("Persona Registrada");
                txtdocu.Clear();
                txtnom.Clear();
                txtape.Clear();
                txttel.Clear();
                txtemail.Clear();
                txtdir.Clear();
                txtgrup.Clear();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListarPersonal objElistar = new frmListarPersonal();

            objElistar.Show();
            this.Hide();
        }

        private void frmRegPersonal_Load(object sender, EventArgs e)
        {
            DClARP objARP = new DClARP();

            cmbarp.DataSource = objARP.mtdlistararp();
            cmbarp.ValueMember = "IdARP";
            cmbarp.DisplayMember = "ARP";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
