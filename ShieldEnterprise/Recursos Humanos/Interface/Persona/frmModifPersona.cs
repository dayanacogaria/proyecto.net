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

namespace Recursos_Humanos.Interface
{
    public partial class frmModifPersona : Form
    {
        public frmModifPersona()
        {
            InitializeComponent();            
        }
        private void frmModifPersona_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {            
            if (txtDoc.Text.Trim() == "" || txtNom.Text.Trim() == "" || txtApe.Text.Trim() == "" || txtDir.Text.Trim() == "" || txtTel.Text.Trim() == "" || txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Faltan algunos campos por completar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (MessageBox.Show("Esta a punto de cambiar un registro, desea continuar?", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ClPersona U = new ClPersona();
                    EPersona EU = new EPersona();

                    int Id = 0;
                    Id = int.Parse(txtId.Text);

                    EU.Documento = txtDoc.Text;
                    EU.Nombre = txtNom.Text;
                    EU.Apellido = txtApe.Text;
                    EU.Direccion = txtDir.Text;
                    EU.Telefono = txtTel.Text;
                    EU.Email = txtEmail.Text;
                    EU.ARL = (cmboarl.Text); 

                    string sql = "Update Persona Set Documento='" + EU.Documento + "', Nombre='" + EU.Nombre + "', Apellido='" + EU.Apellido + "', Direccion='" + EU.Direccion + "', Telefono='" + EU.Telefono + "', Email='" + EU.Email + "' where IdPersona =" + Id + "";
                    U.mtdUpdatePersona(sql);

                    MessageBox.Show("Registro guardado exitosamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }                       
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim() == "")
                {
                    MessageBox.Show("Digite un Id para modificar en el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    ClPersona searchId = new ClPersona();
                    List<EPersona> listReceptId = new List<EPersona>();

                    listReceptId = searchId.mtdBuscarIdPersona(int.Parse(txtId.Text));

                    txtDoc.Text = listReceptId[0].Documento.ToString();
                    txtNom.Text = listReceptId[0].Nombre.ToString();
                    txtApe.Text = listReceptId[0].Apellido.ToString();
                    txtDir.Text = listReceptId[0].Direccion.ToString();
                    txtTel.Text = listReceptId[0].Telefono.ToString();
                    txtEmail.Text = listReceptId[0].Email.ToString();
                    cmboarl.Text = listReceptId[0].ARL.ToString(); 
                }                      
            }

            catch (Exception)
            {
                MessageBox.Show("El Id no se encuentra en la base de datos", "◄ ALERTA | ShieldTech Team ►", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}
