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
using Recursos_Humanos.BusinessLogic; 


namespace Recursos_Humanos.Interface.Persona
{
    public partial class frmARL : Form
    {
        public frmARL()
        {
            InitializeComponent();
        }
       
        private void frmARL_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = arl.mtdlistar();

        }
        LArl larl = new LArl();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Faltan algunos campos por completar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                EArl ARL = new EArl();
                ARL.ARL = textBox1.Text;

                larl.mttdatos(ARL);
                MessageBox.Show("ARL registrada correctamente");
                textBox1.Clear(); 




            }


        }
        LArl arl = new LArl();

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = arl.mtdlistar(); 


        }

        private void btnbus_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtid.Text.Trim()=="")
                {
                    MessageBox.Show("Digite un Id para modificar en el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    ClArl arl = new ClArl();
                    List<EArl> lista = new List<EArl>();

                    lista = arl.mtdbuscaridarl(int.Parse(txtid.Text));

                    txtarl.Text = lista[0].ARL.ToString(); 


                }

            }
            catch (Exception)
            {

                MessageBox.Show("El Id no se encuentra en la base de datos", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegistroPersona d = new frmRegistroPersona();
            d.Show();
            Hide(); 
        }

        private void btnmodi_Click(object sender, EventArgs e)
        {
            if (txtarl.Text.Trim()=="")
            {
                MessageBox.Show("Faltan algunos campos por completar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (MessageBox.Show("Esta a punto de cambiar un registro, desea continuar?", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ClArl arl = new ClArl();
                    EArl eu = new EArl();

                   int Id = 0;
                    Id = int.Parse(txtid.Text);

                    eu.ARL = txtarl.Text;

                    string sql = "Update ARL set ARL='" + eu.ARL + "' Where IdArl='" +Id+ "'";
                    arl.mtdUpdateARL(sql);
                    MessageBox.Show("Registro guardado exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    




                }

            }
        }

        private void btnelim_Click(object sender, EventArgs e)
        {
            if (txtarl.Text.Trim()=="")
            {
                MessageBox.Show("Digite un Id para eliminar en el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Esta a punto de eliminar un registro, desea continuar?", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ClArl d = new ClArl();
                    int Id = 0;
                    Id = int.Parse(txtid.Text); 
                    string sql = "Delete from ARL where IdArl = " + Id +"";
                    d.mtdDeleteARL(sql);
                    MessageBox.Show("El Registro ha sido eliminado!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }


        }
    }
}
